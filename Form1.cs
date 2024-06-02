using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopmentManagementTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddNewItem addNewItem = new AddNewItem();
            addNewItem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportFromCSV(FeatureSummaryTbl, "exported_data.csv");
        }

        private void ImportFromCSV(DataGridView dataGridView, string filePath)
        {
            // 读取 CSV 文件的所有行
            string[] lines = File.ReadAllLines(filePath);

            // 清空 DataGridView 中的现有数据
            dataGridView.Rows.Clear();

            // 从索引为 1 的行开始，跳过第一行
            for (int i = 1; i < lines.Length; i++)
            {
                // 分割行数据为单元格值
                string[] cells = lines[i].Split(',');

                // 添加新行并填充数据
                int rowIndex = dataGridView.Rows.Add(cells);
            }
        }
    }
}
