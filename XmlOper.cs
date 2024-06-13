using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace XmlOperator
{
    public class XmlOper
    {
        private string filePath;
        public XmlOper(string filePath)
        {
            this.filePath = filePath;
        }
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
            SaveXmlToFile(xmlData);
            return filePath;
        }

        private void SaveXmlToFile(string xmlData)
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

        public void AddXmlDataToSummaryXml(string xmlDataFilePath)
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
            if (File.Exists(filePath))
            {
                summaryXmlDocument.Load(filePath);
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
            summaryXmlDocument.Save(filePath);
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

        public List<FeatureItemXmlData> ParseSummaryXml()
        {
            List<FeatureItemXmlData> dataList = new List<FeatureItemXmlData>();
            bool FirstRowFlag = true;

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

                        // 提取所有 FeatureData 节点
                        XmlNodeList featureDataNodes = root.SelectNodes("FeatureData");
                        foreach (XmlNode featureDataNode in featureDataNodes)
                        {
                            FeatureItemXmlData featureItemXmlData = new FeatureItemXmlData();

                            // 提取 FeatureData 节点下的基本信息
                            featureItemXmlData.TraceId = featureDataNode.SelectSingleNode("TraceId")?.InnerText ?? string.Empty;
                            featureItemXmlData.JiraKey = featureDataNode.SelectSingleNode("JiraId/JiraKey")?.InnerText ?? string.Empty;
                            featureItemXmlData.JiraLink = featureDataNode.SelectSingleNode("JiraId/JiraLink")?.InnerText ?? string.Empty;
                            featureItemXmlData.FeatureSource = featureDataNode.SelectSingleNode("FeatureSource")?.InnerText ?? string.Empty;
                            featureItemXmlData.FeatureStatus = featureDataNode.SelectSingleNode("FeatureStatus")?.InnerText ?? string.Empty;
                            featureItemXmlData.FeatureBrief = featureDataNode.SelectSingleNode("FeatureBrief")?.InnerText ?? string.Empty;

                            // 初始化 DataTable 字段
                            featureItemXmlData.DataTable = new DataTable();

                            // 添加前几列
                            featureItemXmlData.DataTable.Columns.Add("TraceId");
                            featureItemXmlData.DataTable.Columns.Add("JiraKey");
                            featureItemXmlData.DataTable.Columns.Add("需求来源");
                            featureItemXmlData.DataTable.Columns.Add("需求状态");
                            featureItemXmlData.DataTable.Columns.Add("需求简述");

                            // 添加后几列
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
                            XmlNodeList specificModelNodes = featureDataNode.SelectNodes("PlatsAndModelsData/SpecificModelData");
                            foreach (XmlNode node in specificModelNodes)
                            {
                                string Plats = node.SelectSingleNode("平台")?.InnerText ?? string.Empty;
                                string Model = node.SelectSingleNode("机型")?.InnerText ?? string.Empty;
                                string DevelopStatus = node.SelectSingleNode("开发状态")?.InnerText ?? string.Empty;
                                string JiraId = node.SelectSingleNode("JiraID")?.InnerText ?? string.Empty;
                                string PlanTime = node.SelectSingleNode("计划时间")?.InnerText ?? string.Empty;
                                string Owner = node.SelectSingleNode("开发Owner")?.InnerText ?? string.Empty;
                                string MainOwnerStr = node.SelectSingleNode("MainOwner")?.InnerText ?? string.Empty;
                                bool MainOwner = !string.IsNullOrEmpty(MainOwnerStr) && MainOwnerStr.ToLower() == "true";
                                string ClNo = node.SelectSingleNode("上库CL")?.InnerText ?? string.Empty;
                                string Review = node.SelectSingleNode("评审记录")?.InnerText ?? string.Empty;
                                string Remark = node.SelectSingleNode("备注")?.InnerText ?? string.Empty;

                                if(true == FirstRowFlag)
                                {
                                    FirstRowFlag = false;
                                    featureItemXmlData.DataTable.Rows.Add(featureItemXmlData.TraceId, featureItemXmlData.JiraKey, featureItemXmlData.FeatureSource, 
                                        featureItemXmlData.FeatureStatus, featureItemXmlData.FeatureBrief, Plats, Model, DevelopStatus, JiraId, PlanTime, Owner, MainOwner, ClNo, Review, Remark);
                                }
                                else
                                    featureItemXmlData.DataTable.Rows.Add("", "", "", "", "", Plats, Model, DevelopStatus, JiraId, PlanTime, Owner, MainOwner, ClNo, Review, Remark);
                            }
                            FirstRowFlag = true;
                            dataList.Add(featureItemXmlData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 如果发生异常，输出错误信息
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataList;
        }

        public int FindMaxTraceIdNumber(string searchString)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                var matchingTraceIds = doc.SelectNodes("//TraceId")
                    .Cast<XmlNode>()
                    .Select(node => node.InnerText)
                    .Where(value => value.StartsWith(searchString))
                    .Select(value =>
                    {
                        int lastHyphenIndex = value.LastIndexOf("-");
                        if (lastHyphenIndex != -1 && int.TryParse(value.Substring(lastHyphenIndex + 1), out int number))
                        {
                            return number;
                        }
                        return 0;
                    });

                return matchingTraceIds.DefaultIfEmpty(0).Max();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return -1; // Handle error case appropriately
            }
        }
    }
}