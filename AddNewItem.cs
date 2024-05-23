using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjecetsConfigParser;

namespace DevelopmentManagementTool
{
    public partial class AddNewItem : Form
    {
        PlatformParser prjParser = new PlatformParser("./config/ProjectList.cfg");
        FileParser parser = new FileParser("./config/ProjectList.cfg");
        public AddNewItem()
        {
            InitializeComponent();
            //InitializeDataGridView();
            InitializeInvolvedModelsCheckListBoxes();
            initAllObjects();
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
            List<string> allPlatforms = parser.GetAllPlatforms();
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

        private List<CheckedListBox> involvedModelsCheckListBoxes;
        private Dictionary<string, CheckedListBox> platformToModelChkListBoxMap;

        private void InitializeInvolvedModelsCheckListBoxes()
        {
            involvedModelsCheckListBoxes = new List<CheckedListBox>
            {
                InvolvedModelsChkListBox1,
                InvolvedModelsChkListBox2,
                InvolvedModelsChkListBox3,
                InvolvedModelsChkListBox4,
                InvolvedModelsChkListBox5,
                InvolvedModelsChkListBox6
            };

            // 初始化字典
            platformToModelChkListBoxMap = new Dictionary<string, CheckedListBox>();

            // 初始状态下，禁用所有的控件
            foreach (var checkListBox in involvedModelsCheckListBoxes)
            {
                checkListBox.Enabled = false;
            }
        }

        private void InvolvedPlatsChkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 获取被操作的项的文本
            string selectedPlatform = InvolvedPlatsChkListBox.Items[e.Index].ToString();

            // 检查操作是勾选还是取消勾选
            if (e.NewValue == CheckState.Checked)
            {
                // 在DataGridView中添加新行
                dataGridView1.Rows.Add(selectedPlatform);

                // 查找并启用第一个可用的CheckBox
                var unusedModelChkBox = involvedModelsCheckListBoxes.FirstOrDefault(c => !c.Enabled);
                if (unusedModelChkBox != null)
                {
                    platformToModelChkListBoxMap.Add(selectedPlatform, unusedModelChkBox);
                    unusedModelChkBox.Enabled = true;
                    unusedModelChkBox.Items.Clear();
                    List<ModelInfo> modelsForPlatform = parser.GetModelsByPlatform(selectedPlatform);
                    foreach (var model in modelsForPlatform)
                    {
                        unusedModelChkBox.Items.Add(model.Name);
                    }
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // 查找并移除DataGridView中对应的所有行
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedPlatform)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                // 通过变量查找 CheckedListBox 实例
                if (platformToModelChkListBoxMap.ContainsKey(selectedPlatform))
                {
                    CheckedListBox currentModelChkBox = platformToModelChkListBoxMap[selectedPlatform];
                    currentModelChkBox.Enabled = false;
                    currentModelChkBox.Items.Clear();
                    platformToModelChkListBoxMap.Remove(selectedPlatform);
                    // 使用 listBox...
                }
                else
                {
                    // 找不到匹配的 CheckedListBox
                }

            }
        }

        private void InvolvedModelsChkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // 获取被操作的项的文本
            string selectedModel = InvolvedModelsChkListBox1.Items[e.Index].ToString();

            // 检查操作是勾选还是取消勾选
            if (e.NewValue == CheckState.Checked)
            {
                // 在DataGridView中添加新行
                dataGridView1.Rows.Add(selectedModel);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // 查找并移除DataGridView中对应的行
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedModel)
                    {
                        dataGridView1.Rows.Remove(row);
                        break; // 找到并删除后，不再继续循环
                    }
                }
            }
        }

    }
    
}
