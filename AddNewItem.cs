using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

        private void VerSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            // 创建一个带有 ComboBox 的列
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "开发Owner";

            // 添加一些选项到 ComboBox
            comboBoxColumn.Items.Add("Option 1");
            comboBoxColumn.Items.Add("Option 2");
            comboBoxColumn.Items.Add("Option 3");

            // 将列添加到 DataGridView
            dataGridView1.Columns.Add(comboBoxColumn);

            // 添加一些示例行
            dataGridView1.Rows.Add(new object[] { "Option 1" });
            dataGridView1.Rows.Add(new object[] { "Option 2" });
            dataGridView1.Rows.Add(new object[] { "Option 3" });
        }

        private void initAllObjects()
        {
            //Version Selection Box initialization
            VerSelBox.Items.Clear();
            VerSelBox.Items.Add("24A");
            VerSelBox.Items.Add("24B");
            VerSelBox.Items.Add("25A");
            VerSelBox.Items.Add("25B");

            Part1SelBox.Items.Clear();
            Part2SelBox.Items.AddRange(new string[] { "C", "D", "M" });
            Part2SelBox.Enabled = false;
            Part3SelBox.Enabled = false;

            StatusSelBox.Items.Clear();
            StatusSelBox.Items.Add("方案讨论");
            StatusSelBox.Items.Add("开发编码");
            StatusSelBox.Items.Add("上库IV测试");
            StatusSelBox.Items.Add("完成");
            StatusSelBox.Items.Add("中止");

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
            FeatureIdTextBox.Text = "0";
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
                new CheckedListBoxWithLabel { CheckedListBox = InvolvedModelsChkListBox6, Label = InvolvedModelsLabel6 }
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
                    dataGridView1.Rows.Add(platform, model);
                }
            }
        }

    }
    
}
