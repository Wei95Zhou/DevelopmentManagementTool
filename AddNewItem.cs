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
                FeatureIdTextBox.Text = featureId;
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
            public System.Windows.Forms.Label Label { get; set; }
        }
        private List<CheckedListBoxWithLabel> involvedModelsCheckListBoxes;

        private void InitializeInvolvedModelsCheckListBoxes()
        {
            involvedModelsCheckListBoxes = new List<CheckedListBoxWithLabel>
            {
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox1, Label = InvolvedModelsLabel1 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox2, Label = InvolvedModelsLabel2 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox3, Label = InvolvedModelsLabel3 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox4, Label = InvolvedModelsLabel4 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox5, Label = InvolvedModelsLabel5 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox6, Label = InvolvedModelsLabel6 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox7, Label = InvolvedModelsLabel7 },
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox8, Label = InvolvedModelsLabel8 }
            };

            // 初始化状态，禁用所有的控件
            foreach (var item in involvedModelsCheckListBoxes)
            {
                item.CheckedListBox.Enabled = false;
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
                    unusedModel.CheckedListBox.Enabled = true;
                    unusedModel.Label.Enabled = true;
                    unusedModel.Label.Text = selectedPlatform; // 更新 Label 的文本
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
                    currentModel.CheckedListBox.Items.Clear();
                    currentModel.Label.Text = "-"; // 清空 Label 的文本

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
            dataGridView1.Rows.Clear();

            // 遍历字典，为每个平台添加新行
            foreach (var kvp in platformModelsDict)
            {
                string platform = kvp.Key;
                List<string> models = kvp.Value;

                // 将每个机型添加到新行
                foreach (string model in models)
                {
                    //dataGridView1.Rows.Add(platform, model);
                    int rowIndex = dataGridView1.Rows.Add(platform, model);

                    // 设置 StatusCol 列的值为列表中第一个选项
                    DataGridViewComboBoxCell statusCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["StatusCol"];
                    statusCell.Value = statusCell.Items[0];

                    // 设置 JiraIdCol 列的值为 JiraKeyTextBox 中的文本，并将 JiraLinkTextBox 中的文本作为链接
                    DataGridViewLinkCell jiraIdCell = (DataGridViewLinkCell)dataGridView1.Rows[rowIndex].Cells["JiraIdCol"];
                    jiraIdCell.Value = JiraKeyTextBox.Text;
                    jiraIdCell.Tag = JiraLinkTextBox.Text;

                    // 设置 PlanTimeCol 列的值为 PlanTimePicker 获取到的时间
                    DataGridViewCell planTimeCell = dataGridView1.Rows[rowIndex].Cells["PlanTimeCol"];
                    planTimeCell.Value = PlanTimePicker.Value.ToString("yy-MM-dd");

                    // 设置 OwnerCol 列的下拉框选项和默认值
                    DataGridViewComboBoxCell ownerCell = (DataGridViewComboBoxCell)dataGridView1.Rows[rowIndex].Cells["OwnerCol"];
                    // 添加 GetAllResponsiblePersons 函数返回的数据作为选项
                    ownerCell.Items.AddRange(prjParser.GetAllResponsiblePersons().ToArray());
                    // 获取 GetResponsiblePerson 方法返回的数据作为默认选项
                    string defaultOwner = prjParser.GetResponsiblePerson(platform, model);
                    ownerCell.Value = defaultOwner;
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
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "JiraIdCol")
            {
                // 获取链接地址（存储在 Tag 属性中）
                object link = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

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
            ExportToCSV(dataGridView1, "exported_data.csv");
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // 创建一个 StringBuilder 来构建 CSV 内容
            StringBuilder csvContent = new StringBuilder();

            // 添加列标题
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                csvContent.Append(column.HeaderText + ",");
            }
            csvContent.AppendLine();

            // 添加行数据
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // 将单元格数据添加到 CSV 内容中
                    csvContent.Append(cell.Value + ",");
                }
                csvContent.AppendLine();
            }

            // 将 CSV 内容写入到文件
            File.WriteAllText(filePath, csvContent.ToString());
        }
    }
    
}
