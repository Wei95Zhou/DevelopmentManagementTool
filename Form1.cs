using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Renci.SshNet;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlOperator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static XmlOperator.XmlOper;
using RemoteManagement;

namespace DevelopmentManagementTool
{
    public partial class Form1 : Form
    {
        private XmlOper xmlOper;
        public Form1()
        {
            InitializeComponent();
            xmlOper = new XmlOper("SummaryXml.xml");
            RefreshSummaryTbl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
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
                xmlOper.AddXmlDataToSummaryXml(newFeatureFile);

                RefreshSummaryTbl();
            };

            // 显示新窗口
            addNewItem.Show();
        }

        private void RefreshSummaryTbl()
        {
            List<FeatureItemXmlData> dataList = xmlOper.ParseSummaryXml();

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

        private void FeatureSummaryTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //*******************************在这里构建链接并打开*********************************
            // 检查用户点击的单元格是否为 DataGridViewLinkCell 类型，并且确保点击的是链接单元格的内容而不是边框或其他部分
            if (FeatureSummaryTbl.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell linkCell && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string url = linkCell.Value?.ToString();

                if (!string.IsNullOrEmpty(url))
                {
                    //MessageBox.Show("打开链接: " + url);
                    try
                    {
                        //System.Diagnostics.Process.Start("explorer.exe", "qq.com");
                    }
                    catch (Exception ex)
                    {
                        //TODO
                        //MessageBox.Show("无法打开链接: " + ex.Message);
                    }
                }
            }
        }

        private void UploadFileToServer()
        {
            SftpOp serverSftpOp = new SftpOp("109.104.116.8", "fwpart", "fwtest2021");

            if (true == serverSftpOp.Connect())
            {
                if (false == serverSftpOp.UploadFile("SummaryXml.xml", "~/DevelopmentManagementTool/\"SummaryXml.xml\""))
                {
                    MessageBox.Show("上传到服务器失败！");
                }
                serverSftpOp.Disconnect();
            }
        }

        private void DownloadFileFromServer()
        {
            SftpOp serverSftpOp = new SftpOp("109.104.116.8", "fwpart", "fwtest2021");

            if(true == serverSftpOp.Connect())
            {
                //考虑在脚本里实现文件下载过程的调用，这样可以更好进行进度条的控制
                if (false == serverSftpOp.DownloadFile("~/DevelopmentManagementTool/\"SummaryXml.xml\"", Directory.GetCurrentDirectory()))
                {
                    MessageBox.Show("下载需求文件失败！");
                }
                serverSftpOp.Disconnect();
            }
        }

        private void DownloadAndShowBtn_Click(object sender, EventArgs e)
        {
            DownloadFileFromServer();
            RefreshSummaryTbl();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            //TODO: 要先更新SummaryXml.xml
            UploadFileToServer();
        }
    }
}
