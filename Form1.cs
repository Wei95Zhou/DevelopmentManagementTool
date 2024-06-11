using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

        /*private void RefreshSummaryTbl()
        {
            List<FeatureItemXmlData> dataList = xmlOper.ParseSummaryXml("SummaryXml.xml");

            // 清除 DataGridView 中的所有行数据
            FeatureSummaryTbl.Rows.Clear();

            // 遍历 dataList
            foreach (var featureItemXmlData1 in dataList)
            {
                // 遍历 featureItemXmlData.DataTable 中的每一行，并将其添加到 DataGridView 中
                foreach (DataRow row in featureItemXmlData1.DataTable.Rows)
                {
                    // 创建新行数据
                    DataGridViewRow newRow = new DataGridViewRow();

                    // 设置第1列
                    newRow.Cells.Add(new DataGridViewTextBoxCell());
                    newRow.Cells[0].Value = row[0];

                    // 构建网址和设置第2列
                    string baseUrl = "https://your.jira.website/"; // 你的 Jira 网址
                    if (!string.IsNullOrEmpty(row[1].ToString()))
                    {
                        string jiraLink2 = baseUrl + row[1].ToString();
                        DataGridViewLinkCell linkCell2 = new DataGridViewLinkCell();
                        linkCell2.Tag = jiraLink2;
                        linkCell2.Value = row[1].ToString();
                        newRow.Cells.Add(linkCell2);
                    }
                    else
                    {
                        newRow.Cells.Add(new DataGridViewTextBoxCell());
                    }

                    // 设置第3到第8列
                    for (int i = 2; i <= 7; i++)
                    {
                        newRow.Cells.Add(new DataGridViewTextBoxCell());
                        newRow.Cells[i].Value = row[i - 1];
                    }

                    // 构建网址和设置第9列
                    if (!string.IsNullOrEmpty(row[8].ToString()))
                    {
                        string jiraLink9 = baseUrl + row[8].ToString();
                        DataGridViewLinkCell linkCell9 = new DataGridViewLinkCell();
                        linkCell9.Tag = jiraLink9;
                        linkCell9.Value = row[8].ToString();
                        newRow.Cells.Add(linkCell9);
                    }
                    else
                    {
                        newRow.Cells.Add(new DataGridViewTextBoxCell());
                    }

                    // 设置第10列及之后的列
                    for (int i = 9; i < row.ItemArray.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(row[i].ToString()))
                        {
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                            newRow.Cells[i].Value = row[i];
                        }
                        else
                        {
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                        }
                    }

                    // 将新的行数据添加到 DataGridView 中
                    FeatureSummaryTbl.Rows.Add(newRow);
                }
            }

            // 刷新 DataGridView
            FeatureSummaryTbl.Refresh();
        }*/

        private void RefreshSummaryTbl()
        {
            List<FeatureItemXmlData> dataList = xmlOper.ParseSummaryXml("SummaryXml.xml");

            // 清除 DataGridView 中的所有行数据
            FeatureSummaryTbl.Rows.Clear();
            //FeatureSummaryTbl.Columns.Clear();

            // 遍历 dataList
            foreach (var featureItemXmlData1 in dataList)
            {
                // 遍历 featureItemXmlData.DataTable 中的每一行，并将其添加到 DataGridView 中
                foreach (DataRow row in featureItemXmlData1.DataTable.Rows)
                {
                    FeatureSummaryTbl.Rows.Add(row.ItemArray);
                }
            }

            // 刷新 DataGridView
            FeatureSummaryTbl.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeatureItemXmlData featureItemXmlData;
            xmlOper.LoadDataFromXml("24B-C.xml", out featureItemXmlData);
            /*MessageBox.Show(featureItemXmlData.TraceId + " " + featureItemXmlData.JiraKey + " " + featureItemXmlData.JiraLink
                    + " " + featureItemXmlData.FeatureStatus + " " + featureItemXmlData.FeatureSource + " " + featureItemXmlData.FeatureBrief);*/

            RefreshSummaryTbl();
        }

        private void FeatureSummaryTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*******************************在这里构建链接并打开*********************************
            // 检查用户点击的单元格是否为 DataGridViewLinkCell 类型，并且确保点击的是链接单元格的内容而不是边框或其他部分
            if (FeatureSummaryTbl.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell linkCell && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string url = linkCell.Tag?.ToString();
                MessageBox.Show("打开链接: " + url);

                if (!string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("打开链接: " + url);
                    try
                    {
                        System.Diagnostics.Process.Start("qq.com");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("无法打开链接: " + ex.Message);
                    }
                }
            }
        }
    }
}
