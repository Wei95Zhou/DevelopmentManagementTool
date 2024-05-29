﻿namespace DevelopmentManagementTool
{
    partial class AddNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvolvedPlatsChkListBox = new System.Windows.Forms.CheckedListBox();
            this.VerLabel = new System.Windows.Forms.Label();
            this.VerSelBox = new System.Windows.Forms.ComboBox();
            this.Part1Label = new System.Windows.Forms.Label();
            this.Part1SelBox = new System.Windows.Forms.ComboBox();
            this.Part2Label = new System.Windows.Forms.Label();
            this.Part3Label = new System.Windows.Forms.Label();
            this.Part2SelBox = new System.Windows.Forms.ComboBox();
            this.Part3SelBox = new System.Windows.Forms.ComboBox();
            this.JiraKeyLabel = new System.Windows.Forms.Label();
            this.JiraKeyTextBox = new System.Windows.Forms.TextBox();
            this.JiraLinkLabel = new System.Windows.Forms.Label();
            this.JiraLinkTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusSelBox = new System.Windows.Forms.ComboBox();
            this.FeatureBrifeLabel = new System.Windows.Forms.Label();
            this.FeatureBrifeTextBox = new System.Windows.Forms.TextBox();
            this.InvolvedPlatsLabel = new System.Windows.Forms.Label();
            this.InvolvedModelsTextBox = new System.Windows.Forms.Label();
            this.InvolvedModelsChkListBox1 = new System.Windows.Forms.CheckedListBox();
            this.MainDeveloperLabel = new System.Windows.Forms.Label();
            this.MainDeveloperSelBox = new System.Windows.Forms.ComboBox();
            this.PlanTimeLabel = new System.Windows.Forms.Label();
            this.PlanTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitClLabel = new System.Windows.Forms.Label();
            this.SubmitClTextBox = new System.Windows.Forms.TextBox();
            this.ReviewLogLabel = new System.Windows.Forms.Label();
            this.ReviewLogTextBox = new System.Windows.Forms.TextBox();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.GenerateBnt = new System.Windows.Forms.Button();
            this.TraceIdLabel = new System.Windows.Forms.Label();
            this.FeatureIdTextBox = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ExitAddItemBtn = new System.Windows.Forms.Button();
            this.InvolvedModelsChkListBox2 = new System.Windows.Forms.CheckedListBox();
            this.InvolvedModelsChkListBox3 = new System.Windows.Forms.CheckedListBox();
            this.InvolvedModelsChkListBox4 = new System.Windows.Forms.CheckedListBox();
            this.InvolvedModelsChkListBox5 = new System.Windows.Forms.CheckedListBox();
            this.InvolvedModelsChkListBox6 = new System.Windows.Forms.CheckedListBox();
            this.InvolvedModelsLabel1 = new System.Windows.Forms.Label();
            this.InvolvedModelsLabel2 = new System.Windows.Forms.Label();
            this.InvolvedModelsLabel3 = new System.Windows.Forms.Label();
            this.InvolvedModelsLabel4 = new System.Windows.Forms.Label();
            this.InvolvedModelsLabel5 = new System.Windows.Forms.Label();
            this.InvolvedModelsLabel6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlatsCol,
            this.ModelCol});
            this.dataGridView1.Location = new System.Drawing.Point(84, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 172);
            this.dataGridView1.TabIndex = 0;
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
            // InvolvedPlatsChkListBox
            // 
            this.InvolvedPlatsChkListBox.CheckOnClick = true;
            this.InvolvedPlatsChkListBox.FormattingEnabled = true;
            this.InvolvedPlatsChkListBox.Location = new System.Drawing.Point(74, 245);
            this.InvolvedPlatsChkListBox.Name = "InvolvedPlatsChkListBox";
            this.InvolvedPlatsChkListBox.Size = new System.Drawing.Size(120, 84);
            this.InvolvedPlatsChkListBox.TabIndex = 1;
            this.InvolvedPlatsChkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.InvolvedPlatsChkListBox_ItemCheck);
            // 
            // VerLabel
            // 
            this.VerLabel.AutoSize = true;
            this.VerLabel.Location = new System.Drawing.Point(72, 32);
            this.VerLabel.Name = "VerLabel";
            this.VerLabel.Size = new System.Drawing.Size(29, 12);
            this.VerLabel.TabIndex = 2;
            this.VerLabel.Text = "版本";
            // 
            // VerSelBox
            // 
            this.VerSelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerSelBox.FormattingEnabled = true;
            this.VerSelBox.Location = new System.Drawing.Point(72, 48);
            this.VerSelBox.Name = "VerSelBox";
            this.VerSelBox.Size = new System.Drawing.Size(41, 20);
            this.VerSelBox.TabIndex = 4;
            this.VerSelBox.SelectedIndexChanged += new System.EventHandler(this.VerSelBox_SelectedIndexChanged);
            // 
            // Part1Label
            // 
            this.Part1Label.AutoSize = true;
            this.Part1Label.Location = new System.Drawing.Point(117, 32);
            this.Part1Label.Name = "Part1Label";
            this.Part1Label.Size = new System.Drawing.Size(35, 12);
            this.Part1Label.TabIndex = 5;
            this.Part1Label.Text = "方向1";
            // 
            // Part1SelBox
            // 
            this.Part1SelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Part1SelBox.FormattingEnabled = true;
            this.Part1SelBox.Location = new System.Drawing.Point(119, 48);
            this.Part1SelBox.Name = "Part1SelBox";
            this.Part1SelBox.Size = new System.Drawing.Size(41, 20);
            this.Part1SelBox.TabIndex = 6;
            this.Part1SelBox.SelectedIndexChanged += new System.EventHandler(this.Part1SelBox_SelectedIndexChanged);
            // 
            // Part2Label
            // 
            this.Part2Label.AutoSize = true;
            this.Part2Label.Location = new System.Drawing.Point(166, 32);
            this.Part2Label.Name = "Part2Label";
            this.Part2Label.Size = new System.Drawing.Size(35, 12);
            this.Part2Label.TabIndex = 7;
            this.Part2Label.Text = "方向2";
            // 
            // Part3Label
            // 
            this.Part3Label.AutoSize = true;
            this.Part3Label.Location = new System.Drawing.Point(215, 32);
            this.Part3Label.Name = "Part3Label";
            this.Part3Label.Size = new System.Drawing.Size(35, 12);
            this.Part3Label.TabIndex = 8;
            this.Part3Label.Text = "方向3";
            // 
            // Part2SelBox
            // 
            this.Part2SelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Part2SelBox.FormattingEnabled = true;
            this.Part2SelBox.Location = new System.Drawing.Point(168, 48);
            this.Part2SelBox.Name = "Part2SelBox";
            this.Part2SelBox.Size = new System.Drawing.Size(41, 20);
            this.Part2SelBox.TabIndex = 9;
            this.Part2SelBox.SelectedIndexChanged += new System.EventHandler(this.Part2SelBox_SelectedIndexChanged);
            // 
            // Part3SelBox
            // 
            this.Part3SelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Part3SelBox.FormattingEnabled = true;
            this.Part3SelBox.Location = new System.Drawing.Point(215, 48);
            this.Part3SelBox.Name = "Part3SelBox";
            this.Part3SelBox.Size = new System.Drawing.Size(41, 20);
            this.Part3SelBox.TabIndex = 10;
            // 
            // JiraKeyLabel
            // 
            this.JiraKeyLabel.AutoSize = true;
            this.JiraKeyLabel.Location = new System.Drawing.Point(70, 119);
            this.JiraKeyLabel.Name = "JiraKeyLabel";
            this.JiraKeyLabel.Size = new System.Drawing.Size(53, 12);
            this.JiraKeyLabel.TabIndex = 11;
            this.JiraKeyLabel.Text = "Jira Key";
            // 
            // JiraKeyTextBox
            // 
            this.JiraKeyTextBox.Location = new System.Drawing.Point(72, 135);
            this.JiraKeyTextBox.Name = "JiraKeyTextBox";
            this.JiraKeyTextBox.Size = new System.Drawing.Size(66, 21);
            this.JiraKeyTextBox.TabIndex = 12;
            // 
            // JiraLinkLabel
            // 
            this.JiraLinkLabel.AutoSize = true;
            this.JiraLinkLabel.Location = new System.Drawing.Point(142, 120);
            this.JiraLinkLabel.Name = "JiraLinkLabel";
            this.JiraLinkLabel.Size = new System.Drawing.Size(59, 12);
            this.JiraLinkLabel.TabIndex = 13;
            this.JiraLinkLabel.Text = "Jira Link";
            // 
            // JiraLinkTextBox
            // 
            this.JiraLinkTextBox.Location = new System.Drawing.Point(144, 135);
            this.JiraLinkTextBox.Name = "JiraLinkTextBox";
            this.JiraLinkTextBox.Size = new System.Drawing.Size(112, 21);
            this.JiraLinkTextBox.TabIndex = 14;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(70, 162);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(29, 12);
            this.StatusLabel.TabIndex = 15;
            this.StatusLabel.Text = "状态";
            // 
            // StatusSelBox
            // 
            this.StatusSelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusSelBox.FormattingEnabled = true;
            this.StatusSelBox.Location = new System.Drawing.Point(72, 177);
            this.StatusSelBox.Name = "StatusSelBox";
            this.StatusSelBox.Size = new System.Drawing.Size(83, 20);
            this.StatusSelBox.TabIndex = 16;
            // 
            // FeatureBrifeLabel
            // 
            this.FeatureBrifeLabel.AutoSize = true;
            this.FeatureBrifeLabel.Location = new System.Drawing.Point(161, 162);
            this.FeatureBrifeLabel.Name = "FeatureBrifeLabel";
            this.FeatureBrifeLabel.Size = new System.Drawing.Size(53, 12);
            this.FeatureBrifeLabel.TabIndex = 17;
            this.FeatureBrifeLabel.Text = "需求简述";
            // 
            // FeatureBrifeTextBox
            // 
            this.FeatureBrifeTextBox.Location = new System.Drawing.Point(161, 177);
            this.FeatureBrifeTextBox.Name = "FeatureBrifeTextBox";
            this.FeatureBrifeTextBox.Size = new System.Drawing.Size(100, 21);
            this.FeatureBrifeTextBox.TabIndex = 18;
            // 
            // InvolvedPlatsLabel
            // 
            this.InvolvedPlatsLabel.AutoSize = true;
            this.InvolvedPlatsLabel.Location = new System.Drawing.Point(72, 227);
            this.InvolvedPlatsLabel.Name = "InvolvedPlatsLabel";
            this.InvolvedPlatsLabel.Size = new System.Drawing.Size(53, 12);
            this.InvolvedPlatsLabel.TabIndex = 19;
            this.InvolvedPlatsLabel.Text = "涉及平台";
            // 
            // InvolvedModelsTextBox
            // 
            this.InvolvedModelsTextBox.AutoSize = true;
            this.InvolvedModelsTextBox.Location = new System.Drawing.Point(889, 32);
            this.InvolvedModelsTextBox.Name = "InvolvedModelsTextBox";
            this.InvolvedModelsTextBox.Size = new System.Drawing.Size(53, 12);
            this.InvolvedModelsTextBox.TabIndex = 21;
            this.InvolvedModelsTextBox.Text = "涉及机型";
            // 
            // InvolvedModelsChkListBox1
            // 
            this.InvolvedModelsChkListBox1.CheckOnClick = true;
            this.InvolvedModelsChkListBox1.FormattingEnabled = true;
            this.InvolvedModelsChkListBox1.Location = new System.Drawing.Point(587, 60);
            this.InvolvedModelsChkListBox1.Name = "InvolvedModelsChkListBox1";
            this.InvolvedModelsChkListBox1.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox1.TabIndex = 23;
            this.InvolvedModelsChkListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.InvolvedModelsChkListBox_ItemCheck);
            // 
            // MainDeveloperLabel
            // 
            this.MainDeveloperLabel.AutoSize = true;
            this.MainDeveloperLabel.Location = new System.Drawing.Point(990, 32);
            this.MainDeveloperLabel.Name = "MainDeveloperLabel";
            this.MainDeveloperLabel.Size = new System.Drawing.Size(59, 12);
            this.MainDeveloperLabel.TabIndex = 24;
            this.MainDeveloperLabel.Text = "开发Owner";
            // 
            // MainDeveloperSelBox
            // 
            this.MainDeveloperSelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainDeveloperSelBox.FormattingEnabled = true;
            this.MainDeveloperSelBox.Location = new System.Drawing.Point(992, 48);
            this.MainDeveloperSelBox.Name = "MainDeveloperSelBox";
            this.MainDeveloperSelBox.Size = new System.Drawing.Size(83, 20);
            this.MainDeveloperSelBox.TabIndex = 27;
            // 
            // PlanTimeLabel
            // 
            this.PlanTimeLabel.AutoSize = true;
            this.PlanTimeLabel.Location = new System.Drawing.Point(1082, 32);
            this.PlanTimeLabel.Name = "PlanTimeLabel";
            this.PlanTimeLabel.Size = new System.Drawing.Size(53, 12);
            this.PlanTimeLabel.TabIndex = 28;
            this.PlanTimeLabel.Text = "计划时间";
            // 
            // PlanTimePicker
            // 
            this.PlanTimePicker.CustomFormat = "yy/MM/dd";
            this.PlanTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PlanTimePicker.Location = new System.Drawing.Point(1084, 48);
            this.PlanTimePicker.Name = "PlanTimePicker";
            this.PlanTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlanTimePicker.Size = new System.Drawing.Size(72, 21);
            this.PlanTimePicker.TabIndex = 29;
            this.PlanTimePicker.Value = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            this.PlanTimePicker.ValueChanged += new System.EventHandler(this.PlanTimePicker_ValueChanged);
            // 
            // SubmitClLabel
            // 
            this.SubmitClLabel.AutoSize = true;
            this.SubmitClLabel.Location = new System.Drawing.Point(1160, 32);
            this.SubmitClLabel.Name = "SubmitClLabel";
            this.SubmitClLabel.Size = new System.Drawing.Size(41, 12);
            this.SubmitClLabel.TabIndex = 30;
            this.SubmitClLabel.Text = "上库CL";
            // 
            // SubmitClTextBox
            // 
            this.SubmitClTextBox.Location = new System.Drawing.Point(1162, 48);
            this.SubmitClTextBox.Name = "SubmitClTextBox";
            this.SubmitClTextBox.Size = new System.Drawing.Size(67, 21);
            this.SubmitClTextBox.TabIndex = 31;
            // 
            // ReviewLogLabel
            // 
            this.ReviewLogLabel.AutoSize = true;
            this.ReviewLogLabel.Location = new System.Drawing.Point(1235, 32);
            this.ReviewLogLabel.Name = "ReviewLogLabel";
            this.ReviewLogLabel.Size = new System.Drawing.Size(53, 12);
            this.ReviewLogLabel.TabIndex = 32;
            this.ReviewLogLabel.Text = "评审记录";
            // 
            // ReviewLogTextBox
            // 
            this.ReviewLogTextBox.Location = new System.Drawing.Point(1235, 47);
            this.ReviewLogTextBox.Name = "ReviewLogTextBox";
            this.ReviewLogTextBox.Size = new System.Drawing.Size(67, 21);
            this.ReviewLogTextBox.TabIndex = 33;
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(1308, 32);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(29, 12);
            this.RemarksLabel.TabIndex = 34;
            this.RemarksLabel.Text = "备注";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(1310, 47);
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(67, 21);
            this.RemarksTextBox.TabIndex = 35;
            // 
            // GenerateBnt
            // 
            this.GenerateBnt.Location = new System.Drawing.Point(1274, 201);
            this.GenerateBnt.Name = "GenerateBnt";
            this.GenerateBnt.Size = new System.Drawing.Size(75, 23);
            this.GenerateBnt.TabIndex = 36;
            this.GenerateBnt.Text = "生成需求";
            this.GenerateBnt.UseVisualStyleBackColor = true;
            // 
            // TraceIdLabel
            // 
            this.TraceIdLabel.AutoSize = true;
            this.TraceIdLabel.Location = new System.Drawing.Point(75, 88);
            this.TraceIdLabel.Name = "TraceIdLabel";
            this.TraceIdLabel.Size = new System.Drawing.Size(53, 12);
            this.TraceIdLabel.TabIndex = 37;
            this.TraceIdLabel.Text = "Trace ID";
            // 
            // FeatureIdTextBox
            // 
            this.FeatureIdTextBox.Location = new System.Drawing.Point(127, 85);
            this.FeatureIdTextBox.Name = "FeatureIdTextBox";
            this.FeatureIdTextBox.ReadOnly = true;
            this.FeatureIdTextBox.Size = new System.Drawing.Size(129, 21);
            this.FeatureIdTextBox.TabIndex = 38;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(537, 539);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(75, 23);
            this.AddItemBtn.TabIndex = 39;
            this.AddItemBtn.Text = "确认添加";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            // 
            // ExitAddItemBtn
            // 
            this.ExitAddItemBtn.Location = new System.Drawing.Point(681, 539);
            this.ExitAddItemBtn.Name = "ExitAddItemBtn";
            this.ExitAddItemBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitAddItemBtn.TabIndex = 40;
            this.ExitAddItemBtn.Text = "取消";
            this.ExitAddItemBtn.UseVisualStyleBackColor = true;
            // 
            // InvolvedModelsChkListBox2
            // 
            this.InvolvedModelsChkListBox2.CheckOnClick = true;
            this.InvolvedModelsChkListBox2.FormattingEnabled = true;
            this.InvolvedModelsChkListBox2.Location = new System.Drawing.Point(590, 162);
            this.InvolvedModelsChkListBox2.Name = "InvolvedModelsChkListBox2";
            this.InvolvedModelsChkListBox2.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox2.TabIndex = 41;
            this.InvolvedModelsChkListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.InvolvedModelsChkListBox_ItemCheck);
            // 
            // InvolvedModelsChkListBox3
            // 
            this.InvolvedModelsChkListBox3.CheckOnClick = true;
            this.InvolvedModelsChkListBox3.FormattingEnabled = true;
            this.InvolvedModelsChkListBox3.Location = new System.Drawing.Point(728, 162);
            this.InvolvedModelsChkListBox3.Name = "InvolvedModelsChkListBox3";
            this.InvolvedModelsChkListBox3.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox3.TabIndex = 42;
            // 
            // InvolvedModelsChkListBox4
            // 
            this.InvolvedModelsChkListBox4.CheckOnClick = true;
            this.InvolvedModelsChkListBox4.FormattingEnabled = true;
            this.InvolvedModelsChkListBox4.Location = new System.Drawing.Point(864, 162);
            this.InvolvedModelsChkListBox4.Name = "InvolvedModelsChkListBox4";
            this.InvolvedModelsChkListBox4.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox4.TabIndex = 43;
            // 
            // InvolvedModelsChkListBox5
            // 
            this.InvolvedModelsChkListBox5.CheckOnClick = true;
            this.InvolvedModelsChkListBox5.FormattingEnabled = true;
            this.InvolvedModelsChkListBox5.Location = new System.Drawing.Point(1005, 162);
            this.InvolvedModelsChkListBox5.Name = "InvolvedModelsChkListBox5";
            this.InvolvedModelsChkListBox5.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox5.TabIndex = 44;
            // 
            // InvolvedModelsChkListBox6
            // 
            this.InvolvedModelsChkListBox6.CheckOnClick = true;
            this.InvolvedModelsChkListBox6.FormattingEnabled = true;
            this.InvolvedModelsChkListBox6.Location = new System.Drawing.Point(587, 271);
            this.InvolvedModelsChkListBox6.Name = "InvolvedModelsChkListBox6";
            this.InvolvedModelsChkListBox6.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox6.TabIndex = 45;
            // 
            // InvolvedModelsLabel1
            // 
            this.InvolvedModelsLabel1.AutoSize = true;
            this.InvolvedModelsLabel1.Location = new System.Drawing.Point(585, 45);
            this.InvolvedModelsLabel1.Name = "InvolvedModelsLabel1";
            this.InvolvedModelsLabel1.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel1.TabIndex = 46;
            this.InvolvedModelsLabel1.Text = "-";
            // 
            // InvolvedModelsLabel2
            // 
            this.InvolvedModelsLabel2.AutoSize = true;
            this.InvolvedModelsLabel2.Location = new System.Drawing.Point(588, 147);
            this.InvolvedModelsLabel2.Name = "InvolvedModelsLabel2";
            this.InvolvedModelsLabel2.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel2.TabIndex = 47;
            this.InvolvedModelsLabel2.Text = "-";
            // 
            // InvolvedModelsLabel3
            // 
            this.InvolvedModelsLabel3.AutoSize = true;
            this.InvolvedModelsLabel3.Location = new System.Drawing.Point(726, 147);
            this.InvolvedModelsLabel3.Name = "InvolvedModelsLabel3";
            this.InvolvedModelsLabel3.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel3.TabIndex = 48;
            this.InvolvedModelsLabel3.Text = "-";
            // 
            // InvolvedModelsLabel4
            // 
            this.InvolvedModelsLabel4.AutoSize = true;
            this.InvolvedModelsLabel4.Location = new System.Drawing.Point(862, 144);
            this.InvolvedModelsLabel4.Name = "InvolvedModelsLabel4";
            this.InvolvedModelsLabel4.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel4.TabIndex = 49;
            this.InvolvedModelsLabel4.Text = "-";
            // 
            // InvolvedModelsLabel5
            // 
            this.InvolvedModelsLabel5.AutoSize = true;
            this.InvolvedModelsLabel5.Location = new System.Drawing.Point(1003, 147);
            this.InvolvedModelsLabel5.Name = "InvolvedModelsLabel5";
            this.InvolvedModelsLabel5.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel5.TabIndex = 50;
            this.InvolvedModelsLabel5.Text = "-";
            // 
            // InvolvedModelsLabel6
            // 
            this.InvolvedModelsLabel6.AutoSize = true;
            this.InvolvedModelsLabel6.Location = new System.Drawing.Point(588, 256);
            this.InvolvedModelsLabel6.Name = "InvolvedModelsLabel6";
            this.InvolvedModelsLabel6.Size = new System.Drawing.Size(11, 12);
            this.InvolvedModelsLabel6.TabIndex = 51;
            this.InvolvedModelsLabel6.Text = "-";
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 591);
            this.Controls.Add(this.InvolvedModelsLabel6);
            this.Controls.Add(this.InvolvedModelsLabel5);
            this.Controls.Add(this.InvolvedModelsLabel4);
            this.Controls.Add(this.InvolvedModelsLabel3);
            this.Controls.Add(this.InvolvedModelsLabel2);
            this.Controls.Add(this.InvolvedModelsLabel1);
            this.Controls.Add(this.InvolvedModelsChkListBox6);
            this.Controls.Add(this.InvolvedModelsChkListBox5);
            this.Controls.Add(this.InvolvedModelsChkListBox4);
            this.Controls.Add(this.InvolvedModelsChkListBox3);
            this.Controls.Add(this.InvolvedModelsChkListBox2);
            this.Controls.Add(this.ExitAddItemBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.FeatureIdTextBox);
            this.Controls.Add(this.TraceIdLabel);
            this.Controls.Add(this.GenerateBnt);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.ReviewLogTextBox);
            this.Controls.Add(this.ReviewLogLabel);
            this.Controls.Add(this.SubmitClTextBox);
            this.Controls.Add(this.SubmitClLabel);
            this.Controls.Add(this.PlanTimePicker);
            this.Controls.Add(this.PlanTimeLabel);
            this.Controls.Add(this.MainDeveloperSelBox);
            this.Controls.Add(this.MainDeveloperLabel);
            this.Controls.Add(this.InvolvedModelsChkListBox1);
            this.Controls.Add(this.InvolvedModelsTextBox);
            this.Controls.Add(this.InvolvedPlatsLabel);
            this.Controls.Add(this.FeatureBrifeTextBox);
            this.Controls.Add(this.FeatureBrifeLabel);
            this.Controls.Add(this.StatusSelBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.JiraLinkTextBox);
            this.Controls.Add(this.JiraLinkLabel);
            this.Controls.Add(this.JiraKeyTextBox);
            this.Controls.Add(this.JiraKeyLabel);
            this.Controls.Add(this.Part3SelBox);
            this.Controls.Add(this.Part2SelBox);
            this.Controls.Add(this.Part3Label);
            this.Controls.Add(this.Part2Label);
            this.Controls.Add(this.Part1SelBox);
            this.Controls.Add(this.Part1Label);
            this.Controls.Add(this.VerSelBox);
            this.Controls.Add(this.VerLabel);
            this.Controls.Add(this.InvolvedPlatsChkListBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddNewItem";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox InvolvedPlatsChkListBox;
        private System.Windows.Forms.Label VerLabel;
        private System.Windows.Forms.ComboBox VerSelBox;
        private System.Windows.Forms.Label Part1Label;
        private System.Windows.Forms.ComboBox Part1SelBox;
        private System.Windows.Forms.Label Part2Label;
        private System.Windows.Forms.Label Part3Label;
        private System.Windows.Forms.ComboBox Part2SelBox;
        private System.Windows.Forms.ComboBox Part3SelBox;
        private System.Windows.Forms.Label JiraKeyLabel;
        private System.Windows.Forms.TextBox JiraKeyTextBox;
        private System.Windows.Forms.Label JiraLinkLabel;
        private System.Windows.Forms.TextBox JiraLinkTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusSelBox;
        private System.Windows.Forms.Label FeatureBrifeLabel;
        private System.Windows.Forms.TextBox FeatureBrifeTextBox;
        private System.Windows.Forms.Label InvolvedPlatsLabel;
        private System.Windows.Forms.Label InvolvedModelsTextBox;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox1;
        private System.Windows.Forms.Label MainDeveloperLabel;
        private System.Windows.Forms.ComboBox MainDeveloperSelBox;
        private System.Windows.Forms.Label PlanTimeLabel;
        private System.Windows.Forms.DateTimePicker PlanTimePicker;
        private System.Windows.Forms.Label SubmitClLabel;
        private System.Windows.Forms.TextBox SubmitClTextBox;
        private System.Windows.Forms.Label ReviewLogLabel;
        private System.Windows.Forms.TextBox ReviewLogTextBox;
        private System.Windows.Forms.Label RemarksLabel;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Button GenerateBnt;
        private System.Windows.Forms.Label TraceIdLabel;
        private System.Windows.Forms.TextBox FeatureIdTextBox;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button ExitAddItemBtn;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox2;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox3;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox4;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelCol;
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox6;
        private System.Windows.Forms.Label InvolvedModelsLabel1;
        private System.Windows.Forms.Label InvolvedModelsLabel2;
        private System.Windows.Forms.Label InvolvedModelsLabel3;
        private System.Windows.Forms.Label InvolvedModelsLabel4;
        private System.Windows.Forms.Label InvolvedModelsLabel5;
        private System.Windows.Forms.Label InvolvedModelsLabel6;
    }
}