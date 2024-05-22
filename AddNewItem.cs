using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
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

            initAllObjects();
        }

        private void VerSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Part1SelBox.Items.Add("C");
            Part1SelBox.Items.Add("D");
            Part1SelBox.Items.Add("M");
            Part1SelBox.Items.Add("-");
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
            IEnumerable<string> allPlatforms = prjParser.GetAllPlatforms();
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
                Part2SelBox.Items.Add("D");
                Part2SelBox.Items.Add("M");
                Part2SelBox.Items.Add("-");
            }
            else if("D" == Part1SelBox.SelectedItem.ToString())
            {
                Part2SelBox.Enabled = true;
                Part2SelBox.Items.Add("C");
                Part2SelBox.Items.Add("M");
                Part2SelBox.Items.Add("-");
            }
            else if("M" == Part1SelBox.SelectedItem.ToString())
            {
                Part2SelBox.Enabled = true;
                Part2SelBox.Items.Add("C");
                Part2SelBox.Items.Add("D");
                Part2SelBox.Items.Add("-");
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
                Part3SelBox.Items.Add("M");
                Part3SelBox.Items.Add("-");
            }
            else if ((("C" == Part1SelBox.SelectedItem.ToString()) && ("M" == Part2SelBox.SelectedItem.ToString()))
                || (("M" == Part1SelBox.SelectedItem.ToString()) && ("C" == Part2SelBox.SelectedItem.ToString())))
            {
                Part3SelBox.Enabled = true;
                Part3SelBox.Items.Add("D");
                Part3SelBox.Items.Add("-");
            }
            else if ((("D" == Part1SelBox.SelectedItem.ToString()) && ("M" == Part2SelBox.SelectedItem.ToString()))
                || (("M" == Part1SelBox.SelectedItem.ToString()) && ("D" == Part2SelBox.SelectedItem.ToString())))
            {
                Part3SelBox.Enabled = true;
                Part3SelBox.Items.Add("C");
                Part3SelBox.Items.Add("-");
            }
            return;
        }

        private void PlanTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PlanTimePicker.Enabled = false;
            PlanTimePicker.Enabled = true;
            return;
        }

        private void InvolvedPlatsChkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvolvedModelsChkListBox.Items.Clear();
            IEnumerable<string> models = prjParser.GetModelsByPlatform(InvolvedPlatsChkListBox.SelectedItem.ToString());
            foreach (string model in models)
            {
                InvolvedModelsChkListBox.Items.Add(model);
            }
        }
    }
    
}
