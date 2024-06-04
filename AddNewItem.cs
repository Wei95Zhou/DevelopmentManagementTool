using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProjecetsConfigParser;

namespace DevelopmentManagementTool
{
    public partial class AddNewItem : Form
    {
        PlatformParser prjParser = new PlatformParser("./config/ProjectList.cfg");
        public AddNewItem()
        {
            InitializeComponent();
            //InitializeDataGridView();
            InitializeInvolvedModelsCheckListBoxes();
            initAllObjects();
            platformModelsDict = new Dictionary<string, List<string>>();
        }

        private void initAllObjects()
        {
            //Version Selection Box initialization
            VerSelBox.Items.Clear();
            VerSelBox.Items.AddRange(new string[] { "24A", "24B", "25A", "25B" });

            Part1SelBox.Items.Clear();
            Part1SelBox.Items.AddRange(new string[] { "C", "D", "M" });
            Part2SelBox.Enabled = false;
            Part3SelBox.Enabled = false;

            StatusSelBox.Items.Clear();
            StatusSelBox.Items.AddRange(new string[] { "方案讨论", "开发测试", "完成", "移交", "中止" });

            PlanTimePicker.Format = DateTimePickerFormat.Custom;
            PlanTimePicker.CustomFormat = "yy/MM/dd";
            PlanTimePicker.ShowUpDown = false;

            InvolvedPlatsChkListBox.Items.Clear();
            List<string> allPlatforms = prjParser.GetAllPlatforms();
            Console.WriteLine("All Platforms:");
            foreach (string platform in allPlatforms)
            {
                InvolvedPlatsChkListBox.Items.Add(platform);
            }

            return;
        }

        private void UpdateFeatureId()
        {
            // 检查 VerSelBox 和 Part1SelBox 是否都有选中的项
            if (VerSelBox.SelectedItem != null && Part1SelBox.SelectedItem != null)
            {
                string featureId = VerSelBox.SelectedItem.ToString() + "-" + Part1SelBox.SelectedItem.ToString();

                // 检查 Part2SelBox 和 Part3SelBox 是否也有选中的项
                if (Part2SelBox.SelectedItem != null)
                {
                    featureId += Part2SelBox.SelectedItem.ToString();
                }

                if (Part3SelBox.SelectedItem != null)
                {
                    featureId += Part3SelBox.SelectedItem.ToString();
                }

                // 更新 FeatureIdTextBox 的文本
                TraceIdTextBox.Text = featureId;
            }
        }

        private void Part1SelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part2SelBox.Items.Clear();
            Part3SelBox.Items.Clear();
            Part2SelBox.Text = "";
            Part3SelBox.Text = "";
            Part2SelBox.Enabled = false;
            Part3SelBox.Enabled = false;

            if("C" == Part1SelBox.SelectedItem.ToString())
            {
                Part2SelBox.Enabled = true;
                Part2SelBox.Items.AddRange(new string[] { "D", "M", "" });
            }
            else if("D" == Part1SelBox.SelectedItem.ToString())
            {
                Part2SelBox.Enabled = true;
                Part2SelBox.Items.AddRange(new string[] { "C", "M", "" });
            }
            else if("M" == Part1SelBox.SelectedItem.ToString())
            {
                Part2SelBox.Enabled = true;
                Part2SelBox.Items.AddRange(new string[] { "C", "D", "" });
            }

            //实现从文件中自动获取ID的功能
            UpdateFeatureId();
            return;
        }
        private void Part2SelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part3SelBox.Items.Clear();
            Part3SelBox.Text = "";
            Part3SelBox.Enabled = false;

            if ((("C" == Part1SelBox.SelectedItem.ToString()) && ("D" == Part2SelBox.SelectedItem.ToString()))
                || (("D" == Part1SelBox.SelectedItem.ToString()) && ("C" == Part2SelBox.SelectedItem.ToString())))
            {
                Part3SelBox.Enabled = true;
                Part3SelBox.Items.AddRange(new string[] { "M", "" });
            }
            else if ((("C" == Part1SelBox.SelectedItem.ToString()) && ("M" == Part2SelBox.SelectedItem.ToString()))
                || (("M" == Part1SelBox.SelectedItem.ToString()) && ("C" == Part2SelBox.SelectedItem.ToString())))
            {
                Part3SelBox.Enabled = true;
                Part3SelBox.Items.AddRange(new string[] { "D", "" });
            }
            else if ((("D" == Part1SelBox.SelectedItem.ToString()) && ("M" == Part2SelBox.SelectedItem.ToString()))
                || (("M" == Part1SelBox.SelectedItem.ToString()) && ("D" == Part2SelBox.SelectedItem.ToString())))
            {
                Part3SelBox.Enabled = true;
                Part3SelBox.Items.AddRange(new string[] { "C", "" });
            }
            UpdateFeatureId();
            return;
        }

        private void PlanTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PlanTimePicker.Enabled = false;
            PlanTimePicker.Enabled = true;
            return;
        }

        private class CheckedListBoxWithLabel
        {
            public CheckedListBox CheckedListBox { get; set; }
            public ComboBox ComboBox { get; set; }
            public System.Windows.Forms.Label Label { get; set; }
        }
        private List<CheckedListBoxWithLabel> involvedModelsCheckListBoxes;

        private void InitializeInvolvedModelsCheckListBoxes()
        {
            involvedModelsCheckListBoxes = new List<CheckedListBoxWithLabel>
            {
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox1, ComboBox = MainDeveloperSelBox1, Label = InvolvedModelsLabel1 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox2, ComboBox = MainDeveloperSelBox2, Label = InvolvedModelsLabel2 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox3, ComboBox = MainDeveloperSelBox3, Label = InvolvedModelsLabel3 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox4, ComboBox = MainDeveloperSelBox4, Label = InvolvedModelsLabel4 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox5, ComboBox = MainDeveloperSelBox5, Label = InvolvedModelsLabel5 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox6, ComboBox = MainDeveloperSelBox6, Label = InvolvedModelsLabel6 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox7, ComboBox = MainDeveloperSelBox7, Label = InvolvedModelsLabel7 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox8, ComboBox = MainDeveloperSelBox8, Label = InvolvedModelsLabel8 }
            };

            // 初始化状态，禁用所有的控件
            foreach (var item in involvedModelsCheckListBoxes)
            {
                item.CheckedListBox.Enabled = false;
                item.ComboBox.Enabled = false;
                item.Label.Enabled = false;
            }
        }

        private void InvolvedPlatsChkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 获取被操作的项的文本
            string selectedPlatform = InvolvedPlatsChkListBox.Items[e.Index].ToString();

            // 检查操作是勾选还是取消勾选
            if (e.NewValue == CheckState.Checked)
            {
                // 查找并启用第一个可用的 CheckBox 及其对应的 Label
                var unusedModel = involvedModelsCheckListBoxes.FirstOrDefault(c => !c.CheckedListBox.Enabled);
                if (unusedModel != null)
                {
                    unusedModel.Label.Enabled = true;
                    unusedModel.Label.Text = selectedPlatform; // 更新 Label 的文本
                    unusedModel.ComboBox.Enabled = true;
                    unusedModel.ComboBox.Items.Clear();
                    unusedModel.ComboBox.Items.Add(""); // 添加一个空项
                    unusedModel.ComboBox.Items.AddRange(prjParser.GetAllResponsiblePersons().ToArray());
                    unusedModel.CheckedListBox.Enabled = true;
                    unusedModel.CheckedListBox.Items.Clear();
                    List<ModelInfo> modelsForPlatform = prjParser.GetModelsByPlatform(selectedPlatform);
                    foreach (var model in modelsForPlatform)
                    {
                        unusedModel.CheckedListBox.Items.Add(model.Name);
                    }
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // 通过变量查找 CheckedListBoxWithLabel 实例
                var currentModel = involvedModelsCheckListBoxes.FirstOrDefault(c => c.Label.Text == selectedPlatform);
                if (currentModel != null)
                {
                    currentModel.CheckedListBox.Enabled = false;
                    currentModel.Label.Enabled = false;
                    currentModel.ComboBox.Enabled = false;
                    currentModel.CheckedListBox.Items.Clear();
                    currentModel.Label.Text = "-"; // 清空 Label 的文本
                    currentModel.ComboBox.Items.Clear();

                    // 移除取消选择的平台对应的记录
                    if (platformModelsDict.ContainsKey(selectedPlatform))
                    {
                        platformModelsDict.Remove(selectedPlatform);
                    }

                    // 更新 DataGridView 中的数据
                    UpdateDataGridView();
                }
            }
        }

        // 字典用于跟踪每个平台对应的机型列表
        private Dictionary<string, List<string>> platformModelsDict;

        private void InvolvedModelsChkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 获取被操作的项的文本
            string selectedModel = ((CheckedListBox)sender).Items[e.Index].ToString();

            // 获取当前所选的平台
            string selectedPlatform = string.Empty;
            foreach (var modelWithLabel in involvedModelsCheckListBoxes)
            {
                if (modelWithLabel.CheckedListBox == sender)
                {
                    selectedPlatform = modelWithLabel.Label.Text;
                    break;
                }
            }

            // 根据平台更新机型列表
            if (!platformModelsDict.ContainsKey(selectedPlatform))
            {
                platformModelsDict[selectedPlatform] = new List<string>();
            }

            // 检查操作是勾选还是取消勾选
            if (e.NewValue == CheckState.Checked)
            {
                // 将机型添加到平台的机型列表中
                platformModelsDict[selectedPlatform].Add(selectedModel);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // 从平台的机型列表中移除机型
                platformModelsDict[selectedPlatform].Remove(selectedModel);
            }

            // 更新 DataGridView 中的数据
            UpdateDataGridView();
        }

        // 更新 DataGridView 中的数据
        private void UpdateDataGridView()
        {
            // 清空 DataGridView 中的数据
            NewFeatureDetailTbl.Rows.Clear();

            // 遍历字典，为每个平台添加新行
            foreach (var kvp in platformModelsDict)
            {
                string platform = kvp.Key;
                List<string> models = kvp.Value;

                // 将每个机型添加到新行
                foreach (string model in models)
                {
                    //dataGridView1.Rows.Add(platform, model);
                    int rowIndex = NewFeatureDetailTbl.Rows.Add(platform, model);

                    // 设置 StatusCol 列的值为列表中第一个选项
                    DataGridViewComboBoxCell statusCell = (DataGridViewComboBoxCell)NewFeatureDetailTbl.Rows[rowIndex].Cells["StatusCol"];
                    statusCell.Value = statusCell.Items[0];

                    // 设置 JiraIdCol 列的值为 JiraKeyTextBox 中的文本，并将 JiraLinkTextBox 中的文本作为链接
                    DataGridViewLinkCell jiraIdCell = (DataGridViewLinkCell)NewFeatureDetailTbl.Rows[rowIndex].Cells["JiraIdCol"];
                    jiraIdCell.Value = JiraKeyTextBox.Text;
                    jiraIdCell.Tag = JiraLinkTextBox.Text;

                    // 设置 PlanTimeCol 列的值为 PlanTimePicker 获取到的时间
                    DataGridViewCell planTimeCell = NewFeatureDetailTbl.Rows[rowIndex].Cells["PlanTimeCol"];
                    planTimeCell.Value = PlanTimePicker.Value.ToString("yy-MM-dd");

                    // 设置 OwnerCol 列的下拉框选项和默认值
                    DataGridViewComboBoxCell ownerCell = (DataGridViewComboBoxCell)NewFeatureDetailTbl.Rows[rowIndex].Cells["OwnerCol"];
                    // 添加 GetAllResponsiblePersons 函数返回的数据作为选项
                    ownerCell.Items.AddRange(prjParser.GetAllResponsiblePersons().ToArray());
                    foreach (var item in involvedModelsCheckListBoxes)
                    {
                        if (item.Label.Text == platform)
                        {
                            if ((item.ComboBox.SelectedItem == null) ||(item.ComboBox.SelectedItem.ToString() == ""))
                            {
                                ownerCell.Value = prjParser.GetResponsiblePerson(platform, model);
                            }
                            else
                            {
                                ownerCell.Value = item.ComboBox.SelectedItem.ToString(); 
                            }
                        }
                    }
                }
            }
        }

        private void VerSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFeatureId();
        }


        private void Part3SelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFeatureId();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 检查用户是否点击了链接列（假设链接列的名称为 "JiraIdCol"）
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && NewFeatureDetailTbl.Columns[e.ColumnIndex].Name == "JiraIdCol")
            {
                // 获取链接地址（存储在 Tag 属性中）
                object link = NewFeatureDetailTbl.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (link != null)
                {
                    string url = link.ToString();

                    // 使用默认浏览器打开链接
                    System.Diagnostics.Process.Start(url);
                }
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            string xmlData = ConvertToXml(TraceIdTextBox.Text, JiraKeyTextBox.Text, JiraLinkTextBox.Text, StatusSelBox.SelectedItem.ToString(), FeatureBrifeTextBox.Text, NewFeatureDetailTbl);
            string filePath = TraceIdTextBox.Text + ".xml";
            SaveXmlToFile(xmlData, filePath);
        }

        public string ConvertToXml(string sTraceId, string sJiraKey, string sJiraLink, string sStatus, string sFeatureBrife, DataGridView dataGridView)
        {
            if (string.IsNullOrEmpty(sTraceId) || string.IsNullOrEmpty(sJiraKey) || string.IsNullOrEmpty(sJiraLink) || string.IsNullOrEmpty(sStatus) || string.IsNullOrEmpty(sFeatureBrife))
            {
                MessageBox.Show("请填写所有必需字段：TraceId， JiraKey， JiraLink， 状态，需求简述。\n如果没有，请填写“-”。");
                return string.Empty;
            }

            // 创建一个 XML 文档对象
            XmlDocument xmlDocument = new XmlDocument();

            // 创建根节点
            XmlElement rootElement = xmlDocument.CreateElement("FeatureData");
            xmlDocument.AppendChild(rootElement);

            // 创建并添加其他字符串作为额外的子节点
            XmlElement additionalDataElement = xmlDocument.CreateElement("TraceId");
            additionalDataElement.InnerText = sTraceId;
            rootElement.AppendChild(additionalDataElement);

            XmlElement jiraIdElement = xmlDocument.CreateElement("JiraId");
            additionalDataElement = xmlDocument.CreateElement("JiraKey");
            additionalDataElement.InnerText = sJiraKey;
            jiraIdElement.AppendChild(additionalDataElement);
            additionalDataElement = xmlDocument.CreateElement("JiraLink");
            additionalDataElement.InnerText = sJiraLink;
            jiraIdElement.AppendChild(additionalDataElement);
            rootElement.AppendChild(jiraIdElement);

            additionalDataElement = xmlDocument.CreateElement("Status");
            additionalDataElement.InnerText = sStatus;
            rootElement.AppendChild(additionalDataElement);

            additionalDataElement = xmlDocument.CreateElement("FeatureBrife");
            additionalDataElement.InnerText = sFeatureBrife;
            rootElement.AppendChild(additionalDataElement);

            // 创建一个 DataTable 并将 DataGridView 中的数据填充到 DataTable 中
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            // 使用 DataSet 将 DataTable 转换为 XML
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            // 创建子节点并添加 DataGridView 数据
            XmlElement dataGridViewElement = xmlDocument.CreateElement("DetailedInfoTable");
            rootElement.AppendChild(dataGridViewElement);

            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)
            {
                Formatting = Formatting.Indented
            };

            dataSet.WriteXml(xmlTextWriter);
            xmlTextWriter.Close();

            // 将 DataGridView 数据作为子节点添加到根节点下
            dataGridViewElement.InnerXml = stringWriter.ToString();

            // 将 XML 文档转换为字符串并返回
            string xmlString = xmlDocument.OuterXml;
            return xmlString;
        }

        // 将转换后的 XML 数据保存到文件
        public void SaveXmlToFile(string xmlData, string filePath)
        {
            // 将 XML 数据写入文件
            File.WriteAllText(filePath, xmlData);
        }

        private void GenerateBnt_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
    
}
