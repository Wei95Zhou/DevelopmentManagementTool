namespace DevelopmentManagementTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addItemBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JiraIdCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PlanTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ClNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(230, 95);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "AddNewItem";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ShowItem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlatsCol,
            this.ModelCol,
            this.StatusCol,
            this.JiraIdCol,
            this.PlanTimeCol,
            this.OwnerCol,
            this.ClNoCol,
            this.ReviewCol,
            this.RemarkCol});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(22, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 172);
            this.dataGridView1.TabIndex = 2;
            // 
            // PlatsCol
            // 
            this.PlatsCol.HeaderText = "平台";
            this.PlatsCol.Name = "PlatsCol";
            this.PlatsCol.ReadOnly = true;
            // 
            // ModelCol
            // 
            this.ModelCol.HeaderText = "机型";
            this.ModelCol.Name = "ModelCol";
            this.ModelCol.ReadOnly = true;
            // 
            // StatusCol
            // 
            this.StatusCol.HeaderText = "状态";
            this.StatusCol.Items.AddRange(new object[] {
            "方案讨论",
            "开发编码中",
            "上库IV测试中",
            "完成",
            "中止"});
            this.StatusCol.Name = "StatusCol";
            // 
            // JiraIdCol
            // 
            this.JiraIdCol.HeaderText = "JiraID";
            this.JiraIdCol.Name = "JiraIdCol";
            // 
            // PlanTimeCol
            // 
            this.PlanTimeCol.HeaderText = "计划时间";
            this.PlanTimeCol.Name = "PlanTimeCol";
            this.PlanTimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanTimeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OwnerCol
            // 
            this.OwnerCol.HeaderText = "开发Owner";
            this.OwnerCol.Name = "OwnerCol";
            // 
            // ClNoCol
            // 
            this.ClNoCol.HeaderText = "上库CL";
            this.ClNoCol.Name = "ClNoCol";
            // 
            // ReviewCol
            // 
            this.ReviewCol.HeaderText = "评审记录";
            this.ReviewCol.Name = "ReviewCol";
            // 
            // RemarkCol
            // 
            this.RemarkCol.HeaderText = "备注";
            this.RemarkCol.Name = "RemarkCol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addItemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusCol;
        private System.Windows.Forms.DataGridViewLinkColumn JiraIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanTimeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn OwnerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkCol;
    }
}

