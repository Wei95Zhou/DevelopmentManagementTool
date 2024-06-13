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
            this.DownloadAndShowBtn = new System.Windows.Forms.Button();
            this.FeatureSummaryTbl = new System.Windows.Forms.DataGridView();
            this.TraceIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefJiraIdCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FeatureSourceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureStatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FeatureBrifeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevelopStatusCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JiraIdCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PlanTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainOwnerChkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureSummaryTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Location = new System.Drawing.Point(27, 25);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "添加新需求";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // DownloadAndShowBtn
            // 
            this.DownloadAndShowBtn.Location = new System.Drawing.Point(108, 25);
            this.DownloadAndShowBtn.Name = "DownloadAndShowBtn";
            this.DownloadAndShowBtn.Size = new System.Drawing.Size(75, 23);
            this.DownloadAndShowBtn.TabIndex = 1;
            this.DownloadAndShowBtn.Text = "获取更新";
            this.DownloadAndShowBtn.UseVisualStyleBackColor = true;
            this.DownloadAndShowBtn.Click += new System.EventHandler(this.DownloadAndShowBtn_Click);
            // 
            // FeatureSummaryTbl
            // 
            this.FeatureSummaryTbl.AllowUserToAddRows = false;
            this.FeatureSummaryTbl.AllowUserToDeleteRows = false;
            this.FeatureSummaryTbl.AllowUserToResizeRows = false;
            this.FeatureSummaryTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeatureSummaryTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TraceIdCol,
            this.RefJiraIdCol,
            this.FeatureSourceCol,
            this.FeatureStatusCol,
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
            this.FeatureSummaryTbl.Location = new System.Drawing.Point(0, 71);
            this.FeatureSummaryTbl.Name = "FeatureSummaryTbl";
            this.FeatureSummaryTbl.RowHeadersVisible = false;
            this.FeatureSummaryTbl.RowTemplate.Height = 23;
            this.FeatureSummaryTbl.Size = new System.Drawing.Size(1472, 782);
            this.FeatureSummaryTbl.TabIndex = 2;
            this.FeatureSummaryTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeatureSummaryTbl_CellContentClick);
            // 
            // TraceIdCol
            // 
            this.TraceIdCol.HeaderText = "TraceID";
            this.TraceIdCol.Name = "TraceIdCol";
            this.TraceIdCol.ReadOnly = true;
            this.TraceIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TraceIdCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RefJiraIdCol
            // 
            this.RefJiraIdCol.HeaderText = "参考JiraID";
            this.RefJiraIdCol.Name = "RefJiraIdCol";
            this.RefJiraIdCol.ReadOnly = true;
            // 
            // FeatureSourceCol
            // 
            this.FeatureSourceCol.HeaderText = "需求来源";
            this.FeatureSourceCol.Name = "FeatureSourceCol";
            this.FeatureSourceCol.ReadOnly = true;
            this.FeatureSourceCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatureSourceCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FeatureStatusCol
            // 
            this.FeatureStatusCol.HeaderText = "需求状态";
            this.FeatureStatusCol.Items.AddRange(new object[] {
            "方案讨论",
            "开发测试",
            "完成",
            "移交",
            "中止"});
            this.FeatureStatusCol.Name = "FeatureStatusCol";
            this.FeatureStatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FeatureBrifeCol
            // 
            this.FeatureBrifeCol.HeaderText = "需求简述";
            this.FeatureBrifeCol.Name = "FeatureBrifeCol";
            this.FeatureBrifeCol.ReadOnly = true;
            this.FeatureBrifeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlatsCol
            // 
            this.PlatsCol.HeaderText = "平台";
            this.PlatsCol.Name = "PlatsCol";
            this.PlatsCol.ReadOnly = true;
            this.PlatsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlatsCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ModelCol
            // 
            this.ModelCol.HeaderText = "机型";
            this.ModelCol.Name = "ModelCol";
            this.ModelCol.ReadOnly = true;
            this.ModelCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModelCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.DevelopStatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.PlanTimeCol.ReadOnly = true;
            this.PlanTimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlanTimeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OwnerCol
            // 
            this.OwnerCol.HeaderText = "开发Owner";
            this.OwnerCol.Name = "OwnerCol";
            this.OwnerCol.ReadOnly = true;
            this.OwnerCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OwnerCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainOwnerChkCol
            // 
            this.MainOwnerChkCol.HeaderText = "MainOwner";
            this.MainOwnerChkCol.Name = "MainOwnerChkCol";
            this.MainOwnerChkCol.ReadOnly = true;
            this.MainOwnerChkCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MainOwnerChkCol.Width = 60;
            // 
            // ClNoCol
            // 
            this.ClNoCol.HeaderText = "上库CL";
            this.ClNoCol.Name = "ClNoCol";
            this.ClNoCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClNoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReviewCol
            // 
            this.ReviewCol.HeaderText = "评审记录";
            this.ReviewCol.Name = "ReviewCol";
            this.ReviewCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RemarkCol
            // 
            this.RemarkCol.HeaderText = "备注";
            this.RemarkCol.Name = "RemarkCol";
            this.RemarkCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(189, 25);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 3;
            this.UploadBtn.Text = "上传改动";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 853);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.FeatureSummaryTbl);
            this.Controls.Add(this.DownloadAndShowBtn);
            this.Controls.Add(this.addItemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeatureSummaryTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button DownloadAndShowBtn;
        private System.Windows.Forms.DataGridView FeatureSummaryTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraceIdCol;
        private System.Windows.Forms.DataGridViewLinkColumn RefJiraIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureSourceCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn FeatureStatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureBrifeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn DevelopStatusCol;
        private System.Windows.Forms.DataGridViewLinkColumn JiraIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MainOwnerChkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkCol;
        private System.Windows.Forms.Button UploadBtn;
    }
}

