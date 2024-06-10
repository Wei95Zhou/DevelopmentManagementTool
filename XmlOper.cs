using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace XmlOperator
{
    public class XmlOper
    {
        //此结构体用于新建/修改单个需求后，将需求数据写入XML，传入的数据为DataGridView，写入XML时会转为DataTable结构
        public struct NewItemXmlData
        {
            public string TraceId;
            public string JiraKey;
            public string JiraLink;
            public string FeatureSource;
            public string FeatureStatus;
            public string FeatureBrief;
            public DataGridView FeatureDataGridView;
        }

        //此结构提用于从XML中解析出单个需求数据，为DataTable结构
        public struct FeatureItemXmlData
        {
            public string TraceId;
            public string JiraKey;
            public string JiraLink;
            public string FeatureSource;
            public string FeatureStatus;
            public string FeatureBrief;
            public DataTable DataTable;
        }

        public string SaveNewFeatureToXml(NewItemXmlData newItemData)
        {
            string xmlData = ConvertToXml(newItemData);
            string filePath = newItemData.TraceId + ".xml";
            SaveXmlToFile(xmlData, filePath);
            return filePath;
        }

        private void SaveXmlToFile(string xmlData, string filePath)
        {
            File.WriteAllText(filePath, xmlData, Encoding.Unicode);
        }

        private string ConvertToXml(NewItemXmlData newItemData)
        {
            StringBuilder xmlStringBuilder = new StringBuilder();

            using (XmlWriter xmlWriter = XmlWriter.Create(xmlStringBuilder, new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartElement("FeatureData");

                xmlWriter.WriteElementString("TraceId", newItemData.TraceId);

                xmlWriter.WriteStartElement("JiraId");
                xmlWriter.WriteElementString("JiraKey", newItemData.JiraKey);
                xmlWriter.WriteElementString("JiraLink", newItemData.JiraLink);
                xmlWriter.WriteEndElement(); // Close JiraId element

                xmlWriter.WriteElementString("FeatureSource", newItemData.FeatureSource);
                xmlWriter.WriteElementString("FeatureStatus", newItemData.FeatureStatus);
                xmlWriter.WriteElementString("FeatureBrief", newItemData.FeatureBrief);

                WriteDataGridViewToXml(xmlWriter, newItemData.FeatureDataGridView);

                xmlWriter.WriteEndElement(); // Close FeatureData element
            }

            return xmlStringBuilder.ToString();
        }

        private void WriteDataGridViewToXml(XmlWriter xmlWriter, DataGridView dataGridView)
        {
            DataSet dataSet = new DataSet("PlatsAndModelsData"); // 设置 DataSet 名称为 "FeatureData"

            DataTable dataTable = new DataTable("SpecificModelData");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell is DataGridViewLinkCell linkCell)
                    {
                        // 如果是链接单元格
                        if (linkCell.Value != null)
                        {
                            // 如果链接单元格的值不为空，将链接名和链接标签添加到XML中
                            dataRow[cell.ColumnIndex] = linkCell.Value;
                        }
                        else
                        {
                            // 如果链接单元格的值为空，将链接名和链接标签都设置为空字符串，并添加到XML中
                            dataRow[cell.ColumnIndex] = "";
                        }
                    }
                    else
                    {
                        // 如果不是链接单元格，则获取普通单元格的值
                        dataRow[cell.ColumnIndex] = cell.Value ?? ""; // 如果值为空，则将其转换为空字符串
                    }
                }
                dataTable.Rows.Add(dataRow);
            }

            dataSet.Tables.Add(dataTable);

            dataSet.WriteXml(xmlWriter);
        }

        public void AddXmlDataToSummaryXml(string xmlDataFilePath, string summaryXmlFilePath)
        {
            // 检查要添加的 XML 文件是否存在
            if (!File.Exists(xmlDataFilePath))
            {
                throw new FileNotFoundException("要添加的 XML 文件不存在。", xmlDataFilePath);
            }

            // 解析要添加的 XML 文件
            XmlDocument xmlDocumentToAdd = new XmlDocument();

            // 使用 StreamReader 来读取 XML 文件，并检测其编码
            using (StreamReader sr = new StreamReader(xmlDataFilePath, true))
            {
                xmlDocumentToAdd.Load(sr);
            }

            // 获取要添加的 XML 数据的根元素
            XmlElement xmlElementToAdd = xmlDocumentToAdd.DocumentElement;

            // 加载或创建汇总 XML 文件
            XmlDocument summaryXmlDocument = new XmlDocument();
            if (File.Exists(summaryXmlFilePath))
            {
                summaryXmlDocument.Load(summaryXmlFilePath);
            }
            else
            {
                // 如果汇总 XML 文件不存在，则创建一个新的 XML 文档
                XmlDeclaration xmlDeclaration = summaryXmlDocument.CreateXmlDeclaration("1.0", "UTF-16", null);
                summaryXmlDocument.AppendChild(xmlDeclaration);
                XmlElement rootElement = summaryXmlDocument.CreateElement("SummaryFeatureData");
                summaryXmlDocument.AppendChild(rootElement);
            }

            // 获取汇总 XML 文件的根元素
            XmlElement summaryRootElement = summaryXmlDocument.DocumentElement;

            // 创建一个新的元素，并将要添加的 XML 数据合并到其中
            XmlNode importedNode = summaryXmlDocument.ImportNode(xmlElementToAdd, true);
            summaryRootElement.AppendChild(importedNode);

            // 保存汇总 XML 文件
            summaryXmlDocument.Save(summaryXmlFilePath);
        }

        public void LoadDataFromXml(string filePath, out FeatureItemXmlData featureItemXmlData)
        {
            featureItemXmlData = new FeatureItemXmlData(); // 初始化 FeatureItemXmlData 对象

            try
            {
                // 使用指定的 UTF-16 编码创建 StreamReader
                using (StreamReader streamReader = new StreamReader(filePath, Encoding.Unicode))
                {
                    // 创建 XmlReader 并加载 XML 文件
                    using (XmlReader reader = XmlReader.Create(streamReader))
                    {
                        // 创建一个 XmlDocument 对象
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(reader);

                        // 获取根节点
                        XmlNode root = xmlDoc.DocumentElement;

                        // 提取基本信息，使用 null 合并运算符处理可能为空的情况
                        featureItemXmlData.TraceId = root.SelectSingleNode("TraceId")?.InnerText ?? string.Empty;
                        featureItemXmlData.JiraKey = root.SelectSingleNode("JiraId/JiraKey")?.InnerText ?? string.Empty;
                        featureItemXmlData.JiraLink = root.SelectSingleNode("JiraId/JiraLink")?.InnerText ?? string.Empty;
                        featureItemXmlData.FeatureSource = root.SelectSingleNode("FeatureSource")?.InnerText ?? string.Empty;
                        featureItemXmlData.FeatureStatus = root.SelectSingleNode("FeatureStatus")?.InnerText ?? string.Empty;
                        featureItemXmlData.FeatureBrief = root.SelectSingleNode("FeatureBrief")?.InnerText ?? string.Empty;

                        // 初始化 DataTable 字段
                        featureItemXmlData.DataTable = new DataTable();
                        featureItemXmlData.DataTable.Columns.Add("平台");
                        featureItemXmlData.DataTable.Columns.Add("机型");
                        featureItemXmlData.DataTable.Columns.Add("开发状态");
                        featureItemXmlData.DataTable.Columns.Add("JiraID");
                        featureItemXmlData.DataTable.Columns.Add("计划时间");
                        featureItemXmlData.DataTable.Columns.Add("开发Owner");
                        featureItemXmlData.DataTable.Columns.Add("MainOwner");
                        featureItemXmlData.DataTable.Columns.Add("上库CL");
                        featureItemXmlData.DataTable.Columns.Add("评审记录");
                        featureItemXmlData.DataTable.Columns.Add("备注");

                        // 提取 SpecificModelData 数据并添加到 DataTable 中
                        XmlNodeList specificModelNodes = root.SelectNodes("PlatsAndModelsData/SpecificModelData");
                        foreach (XmlNode node in specificModelNodes)
                        {
                            string Plats = node.SelectSingleNode("平台")?.InnerText ?? string.Empty;
                            string Model = node.SelectSingleNode("机型")?.InnerText ?? string.Empty;
                            string DevelopStatus = node.SelectSingleNode("开发状态")?.InnerText ?? string.Empty;
                            string JiraId = node.SelectSingleNode("JiraID")?.InnerText ?? string.Empty;
                            string PlanTime = node.SelectSingleNode("计划时间")?.InnerText ?? string.Empty;
                            string Owner = node.SelectSingleNode("开发Owner")?.InnerText ?? string.Empty;
                            string MainOwner = node.SelectSingleNode("MainOwner")?.InnerText ?? string.Empty;
                            string ClNo = node.SelectSingleNode("上库CL")?.InnerText ?? string.Empty;
                            string Review = node.SelectSingleNode("评审记录")?.InnerText ?? string.Empty;
                            string Remark = node.SelectSingleNode("备注")?.InnerText ?? string.Empty;

                            featureItemXmlData.DataTable.Rows.Add(Plats, Model, DevelopStatus, JiraId, PlanTime, Owner, MainOwner, ClNo, Review, Remark);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 如果发生异常，输出错误信息
                Console.WriteLine("Error: " + ex.Message);
                // 这里可能需要手动赋值给 featureItemXmlData 以满足 out 参数的要求
                featureItemXmlData = new FeatureItemXmlData();
            }
        }

    }
}