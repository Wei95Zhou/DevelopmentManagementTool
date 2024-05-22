namespace DevelopmentManagementTool
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
            this.InvolvedModelsChkListBox = new System.Windows.Forms.CheckedListBox();
            this.MainDeveloperLabel = new System.Windows.Forms.Label();
            this.InvolvedPlatsSelBox = new System.Windows.Forms.ComboBox();
            this.InvolvedModelsSelBox = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // InvolvedPlatsChkListBox
            // 
            this.InvolvedPlatsChkListBox.CheckOnClick = true;
            this.InvolvedPlatsChkListBox.FormattingEnabled = true;
            this.InvolvedPlatsChkListBox.Location = new System.Drawing.Point(74, 242);
            this.InvolvedPlatsChkListBox.Name = "InvolvedPlatsChkListBox";
            this.InvolvedPlatsChkListBox.Size = new System.Drawing.Size(120, 84);
            this.InvolvedPlatsChkListBox.TabIndex = 1;
            this.InvolvedPlatsChkListBox.SelectedIndexChanged += new System.EventHandler(this.InvolvedPlatsChkListBox_SelectedIndexChanged);
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
            this.Part2SelBox.FormattingEnabled = true;
            this.Part2SelBox.Location = new System.Drawing.Point(168, 48);
            this.Part2SelBox.Name = "Part2SelBox";
            this.Part2SelBox.Size = new System.Drawing.Size(41, 20);
            this.Part2SelBox.TabIndex = 9;
            this.Part2SelBox.SelectedIndexChanged += new System.EventHandler(this.Part2SelBox_SelectedIndexChanged);
            // 
            // Part3SelBox
            // 
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
            this.InvolvedModelsTextBox.Location = new System.Drawing.Point(588, 44);
            this.InvolvedModelsTextBox.Name = "InvolvedModelsTextBox";
            this.InvolvedModelsTextBox.Size = new System.Drawing.Size(53, 12);
            this.InvolvedModelsTextBox.TabIndex = 21;
            this.InvolvedModelsTextBox.Text = "涉及机型";
            // 
            // InvolvedModelsChkListBox
            // 
            this.InvolvedModelsChkListBox.CheckOnClick = true;
            this.InvolvedModelsChkListBox.FormattingEnabled = true;
            this.InvolvedModelsChkListBox.Location = new System.Drawing.Point(587, 60);
            this.InvolvedModelsChkListBox.Name = "InvolvedModelsChkListBox";
            this.InvolvedModelsChkListBox.Size = new System.Drawing.Size(120, 84);
            this.InvolvedModelsChkListBox.TabIndex = 23;
            // 
            // MainDeveloperLabel
            // 
            this.MainDeveloperLabel.AutoSize = true;
            this.MainDeveloperLabel.Location = new System.Drawing.Point(714, 44);
            this.MainDeveloperLabel.Name = "MainDeveloperLabel";
            this.MainDeveloperLabel.Size = new System.Drawing.Size(59, 12);
            this.MainDeveloperLabel.TabIndex = 24;
            this.MainDeveloperLabel.Text = "开发Owner";
            // 
            // InvolvedPlatsSelBox
            // 
            this.InvolvedPlatsSelBox.FormattingEnabled = true;
            this.InvolvedPlatsSelBox.Location = new System.Drawing.Point(72, 335);
            this.InvolvedPlatsSelBox.Name = "InvolvedPlatsSelBox";
            this.InvolvedPlatsSelBox.Size = new System.Drawing.Size(118, 20);
            this.InvolvedPlatsSelBox.TabIndex = 25;
            // 
            // InvolvedModelsSelBox
            // 
            this.InvolvedModelsSelBox.FormattingEnabled = true;
            this.InvolvedModelsSelBox.Location = new System.Drawing.Point(590, 21);
            this.InvolvedModelsSelBox.Name = "InvolvedModelsSelBox";
            this.InvolvedModelsSelBox.Size = new System.Drawing.Size(117, 20);
            this.InvolvedModelsSelBox.TabIndex = 26;
            // 
            // MainDeveloperSelBox
            // 
            this.MainDeveloperSelBox.FormattingEnabled = true;
            this.MainDeveloperSelBox.Location = new System.Drawing.Point(716, 60);
            this.MainDeveloperSelBox.Name = "MainDeveloperSelBox";
            this.MainDeveloperSelBox.Size = new System.Drawing.Size(83, 20);
            this.MainDeveloperSelBox.TabIndex = 27;
            // 
            // PlanTimeLabel
            // 
            this.PlanTimeLabel.AutoSize = true;
            this.PlanTimeLabel.Location = new System.Drawing.Point(806, 44);
            this.PlanTimeLabel.Name = "PlanTimeLabel";
            this.PlanTimeLabel.Size = new System.Drawing.Size(53, 12);
            this.PlanTimeLabel.TabIndex = 28;
            this.PlanTimeLabel.Text = "计划时间";
            // 
            // PlanTimePicker
            // 
            this.PlanTimePicker.CustomFormat = "yy/MM/dd";
            this.PlanTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PlanTimePicker.Location = new System.Drawing.Point(808, 60);
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
            this.SubmitClLabel.Location = new System.Drawing.Point(884, 44);
            this.SubmitClLabel.Name = "SubmitClLabel";
            this.SubmitClLabel.Size = new System.Drawing.Size(41, 12);
            this.SubmitClLabel.TabIndex = 30;
            this.SubmitClLabel.Text = "上库CL";
            // 
            // SubmitClTextBox
            // 
            this.SubmitClTextBox.Location = new System.Drawing.Point(886, 60);
            this.SubmitClTextBox.Name = "SubmitClTextBox";
            this.SubmitClTextBox.Size = new System.Drawing.Size(67, 21);
            this.SubmitClTextBox.TabIndex = 31;
            // 
            // ReviewLogLabel
            // 
            this.ReviewLogLabel.AutoSize = true;
            this.ReviewLogLabel.Location = new System.Drawing.Point(959, 44);
            this.ReviewLogLabel.Name = "ReviewLogLabel";
            this.ReviewLogLabel.Size = new System.Drawing.Size(53, 12);
            this.ReviewLogLabel.TabIndex = 32;
            this.ReviewLogLabel.Text = "评审记录";
            // 
            // ReviewLogTextBox
            // 
            this.ReviewLogTextBox.Location = new System.Drawing.Point(959, 59);
            this.ReviewLogTextBox.Name = "ReviewLogTextBox";
            this.ReviewLogTextBox.Size = new System.Drawing.Size(67, 21);
            this.ReviewLogTextBox.TabIndex = 33;
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(1032, 44);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(29, 12);
            this.RemarksLabel.TabIndex = 34;
            this.RemarksLabel.Text = "备注";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(1034, 59);
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
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 591);
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
            this.Controls.Add(this.InvolvedModelsSelBox);
            this.Controls.Add(this.InvolvedPlatsSelBox);
            this.Controls.Add(this.MainDeveloperLabel);
            this.Controls.Add(this.InvolvedModelsChkListBox);
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
        private System.Windows.Forms.CheckedListBox InvolvedModelsChkListBox;
        private System.Windows.Forms.Label MainDeveloperLabel;
        private System.Windows.Forms.ComboBox InvolvedPlatsSelBox;
        private System.Windows.Forms.ComboBox InvolvedModelsSelBox;
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
    }
}