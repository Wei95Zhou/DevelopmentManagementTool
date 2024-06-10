using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlOperator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static XmlOperator.XmlOper;

namespace DevelopmentManagementTool
{
    public partial class Form1 : Form
    {
        private XmlOper xmlOper;
        public Form1()
        {
            InitializeComponent();
            xmlOper = new XmlOper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            FeatureItemXmlData featureItemXmlData;

            string newFeatureFile = "";
            // 创建新窗口实例
            AddNewItem addNewItem = new AddNewItem();

            // 禁用原来的窗口
            this.Enabled = false;

            // 在新窗口关闭时启用原来的窗口，并获取传递的字符串
            addNewItem.FormClosed += (s, args) =>
            {
                // 获取传递的字符串
                newFeatureFile = addNewItem.NewFeatureFile;

                // 启用原来的窗口
                this.Enabled = true;

                // 如果 newFeatureFile 是 "-" 或者空字符串，则直接退出函数
                if (string.IsNullOrEmpty(newFeatureFile) || newFeatureFile == "-")
                    return;

                // 在新窗口关闭后执行 XML 操作
                xmlOper.AddXmlDataToSummaryXml(newFeatureFile, "SummaryXml.xml");

                xmlOper.LoadDataFromXml(newFeatureFile, out featureItemXmlData);
                MessageBox.Show(featureItemXmlData.TraceId + " " + featureItemXmlData.JiraKey + " " + featureItemXmlData.JiraLink 
                    + " " + featureItemXmlData.FeatureStatus + " " + featureItemXmlData.FeatureSource + " " + featureItemXmlData.FeatureBrief);
            };

            // 显示新窗口
            addNewItem.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FeatureItemXmlData featureItemXmlData;
            xmlOper.LoadDataFromXml("24B-C.xml", out featureItemXmlData);
            MessageBox.Show(featureItemXmlData.TraceId + " " + featureItemXmlData.JiraKey + " " + featureItemXmlData.JiraLink
                    + " " + featureItemXmlData.FeatureStatus + " " + featureItemXmlData.FeatureSource + " " + featureItemXmlData.FeatureBrief);

            // 假设 dataGridView1 是你的 DataGridView 控件

            // 创建并添加 DataGridView 列
            DataGridViewTextBoxColumn columnTraceId = new DataGridViewTextBoxColumn();
            columnTraceId.DataPropertyName = "TraceId";
            columnTraceId.HeaderText = "TraceId";
            dataGridView1.Columns.Add(columnTraceId);

            DataGridViewTextBoxColumn columnJiraKey = new DataGridViewTextBoxColumn();
            columnJiraKey.DataPropertyName = "JiraKey";
            columnJiraKey.HeaderText = "JiraKey";
            dataGridView1.Columns.Add(columnJiraKey);

            DataGridViewTextBoxColumn columnJiraLink = new DataGridViewTextBoxColumn();
            columnJiraLink.DataPropertyName = "JiraLink";
            columnJiraLink.HeaderText = "JiraLink";
            dataGridView1.Columns.Add(columnJiraLink);

            DataGridViewTextBoxColumn columnFeatureSource = new DataGridViewTextBoxColumn();
            columnFeatureSource.DataPropertyName = "FeatureSource";
            columnFeatureSource.HeaderText = "FeatureSource";
            dataGridView1.Columns.Add(columnFeatureSource);

            DataGridViewTextBoxColumn columnFeatureStatus = new DataGridViewTextBoxColumn();
            columnFeatureStatus.DataPropertyName = "FeatureStatus";
            columnFeatureStatus.HeaderText = "FeatureStatus";
            dataGridView1.Columns.Add(columnFeatureStatus);

            DataGridViewTextBoxColumn columnFeatureBrief = new DataGridViewTextBoxColumn();
            columnFeatureBrief.DataPropertyName = "FeatureBrief";
            columnFeatureBrief.HeaderText = "FeatureBrief";
            dataGridView1.Columns.Add(columnFeatureBrief);

            // 绑定 DataTable 到 DataGridView，前面的数据将会显示在合并的单元格中
            dataGridView1.DataSource = featureItemXmlData.DataTable;

            // 将合并的单元格设置为第一行的单元格
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = dataGridView1.Columns[i].HeaderText;
            }
        }
    }
}
