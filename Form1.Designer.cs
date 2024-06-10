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
            this.FeatureSummaryTbl = new System.Windows.Forms.DataGridView();
            this.TraceIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureSourceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureStatusCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RefJiraIdCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FeatureBrifeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevelopStatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JiraIdCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PlanTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MainOwnerChkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureSummaryTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Location = new System.Drawing.Point(250, 58);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "AddNewItem";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ShowItem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeatureSummaryTbl
            // 
            this.FeatureSummaryTbl.AllowUserToAddRows = false;
            this.FeatureSummaryTbl.AllowUserToDeleteRows = false;
            this.FeatureSummaryTbl.AllowUserToResizeRows = false;
            this.FeatureSummaryTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeatureSummaryTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TraceIdCol,
            this.FeatureSourceCol,
            this.FeatureStatusCol,
            this.RefJiraIdCol,
            this.FeatureBrifeCol,
            this.PlatsCol,
            this.ModelCol,
            this.DevelopStatusCol,
            this.JiraIdCol,
            this.PlanTimeCol,
            this.OwnerCol,
            this.MainOwnerChkCol,
            this.ClNoCol,
            this.ReviewCol,
            this.RemarkCol});
            this.FeatureSummaryTbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FeatureSummaryTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.FeatureSummaryTbl.Location = new System.Drawing.Point(0, 333);
            this.FeatureSummaryTbl.Name = "FeatureSummaryTbl";
            this.FeatureSummaryTbl.RowHeadersVisible = false;
            this.FeatureSummaryTbl.RowTemplate.Height = 23;
            this.FeatureSummaryTbl.Size = new System.Drawing.Size(1472, 520);
            this.FeatureSummaryTbl.TabIndex = 2;
            // 
            // TraceIdCol
            // 
            this.TraceIdCol.HeaderText = "TraceID";
            this.TraceIdCol.Name = "TraceIdCol";
            this.TraceIdCol.ReadOnly = true;
            // 
            // FeatureSourceCol
            // 
            this.FeatureSourceCol.HeaderText = "需求来源";
            this.FeatureSourceCol.Name = "FeatureSourceCol";
            // 
            // FeatureStatusCol
            // 
            this.FeatureStatusCol.HeaderText = "需求状态";
            this.FeatureStatusCol.Name = "FeatureStatusCol";
            this.FeatureStatusCol.ReadOnly = true;
            // 
            // RefJiraIdCol
            // 
            this.RefJiraIdCol.HeaderText = "参考JiraID";
            this.RefJiraIdCol.Name = "RefJiraIdCol";
            this.RefJiraIdCol.ReadOnly = true;
            // 
            // FeatureBrifeCol
            // 
            this.FeatureBrifeCol.HeaderText = "需求简述";
            this.FeatureBrifeCol.Name = "FeatureBrifeCol";
            this.FeatureBrifeCol.ReadOnly = true;
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
            // DevelopStatusCol
            // 
            this.DevelopStatusCol.HeaderText = "开发状态";
            this.DevelopStatusCol.Items.AddRange(new object[] {
            "方案讨论",
            "开发编码中",
            "上库IV测试中",
            "完成",
            "中止"});
            this.DevelopStatusCol.Name = "DevelopStatusCol";
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
            // MainOwnerChkCol
            // 
            this.MainOwnerChkCol.HeaderText = "MainOwner";
            this.MainOwnerChkCol.Name = "MainOwnerChkCol";
            this.MainOwnerChkCol.Width = 60;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1448, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 853);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FeatureSummaryTbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addItemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeatureSummaryTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView FeatureSummaryTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraceIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureSourceCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FeatureStatusCol;
        private System.Windows.Forms.DataGridViewLinkColumn RefJiraIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureBrifeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn DevelopStatusCol;
        private System.Windows.Forms.DataGridViewLinkColumn JiraIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanTimeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn OwnerCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MainOwnerChkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkCol;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

