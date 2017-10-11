namespace libraryCard
{
    partial class settingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Defaults");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Overdue Options");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Preference Settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.settingsTree = new System.Windows.Forms.TreeView();
            this.comboboxDefaultsPanel = new System.Windows.Forms.Panel();
            this.comboBoxCheckIn_sett = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBookVsDvd_sett_edit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBookVsDvd_sett = new System.Windows.Forms.ComboBox();
            this.comboBoxID_ISBN_sett = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.overdueOptionsPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.overdueDvdCost_sett = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.untilOverdue_sett = new System.Windows.Forms.NumericUpDown();
            this.overdueBookCost_sett = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.comboboxDefaultsPanel.SuspendLayout();
            this.overdueOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueDvdCost_sett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.untilOverdue_sett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBookCost_sett)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTree
            // 
            this.settingsTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsTree.Location = new System.Drawing.Point(20, 111);
            this.settingsTree.Margin = new System.Windows.Forms.Padding(4);
            this.settingsTree.Name = "settingsTree";
            treeNode1.Name = "comboBoxDefaults";
            treeNode1.Text = "Defaults";
            treeNode2.Name = "overdueOptions";
            treeNode2.Text = "Overdue Options";
            treeNode3.BackColor = System.Drawing.Color.Transparent;
            treeNode3.ForeColor = System.Drawing.Color.DimGray;
            treeNode3.Name = "preferenceTab";
            treeNode3.Text = "Preference Settings";
            this.settingsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.settingsTree.Size = new System.Drawing.Size(266, 487);
            this.settingsTree.TabIndex = 0;
            this.settingsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.settingsTree_AfterSelect);
            // 
            // comboboxDefaultsPanel
            // 
            this.comboboxDefaultsPanel.Controls.Add(this.comboBoxCheckIn_sett);
            this.comboboxDefaultsPanel.Controls.Add(this.label4);
            this.comboboxDefaultsPanel.Controls.Add(this.comboBookVsDvd_sett_edit);
            this.comboboxDefaultsPanel.Controls.Add(this.label3);
            this.comboboxDefaultsPanel.Controls.Add(this.comboBookVsDvd_sett);
            this.comboboxDefaultsPanel.Controls.Add(this.comboBoxID_ISBN_sett);
            this.comboboxDefaultsPanel.Controls.Add(this.label2);
            this.comboboxDefaultsPanel.Controls.Add(this.label1);
            this.comboboxDefaultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxDefaultsPanel.Location = new System.Drawing.Point(286, 111);
            this.comboboxDefaultsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxDefaultsPanel.Name = "comboboxDefaultsPanel";
            this.comboboxDefaultsPanel.Size = new System.Drawing.Size(745, 487);
            this.comboboxDefaultsPanel.TabIndex = 2;
            // 
            // comboBoxCheckIn_sett
            // 
            this.comboBoxCheckIn_sett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckIn_sett.FormattingEnabled = true;
            this.comboBoxCheckIn_sett.Items.AddRange(new object[] {
            "Book using ID",
            "DVD using ID"});
            this.comboBoxCheckIn_sett.Location = new System.Drawing.Point(460, 273);
            this.comboBoxCheckIn_sett.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCheckIn_sett.Name = "comboBoxCheckIn_sett";
            this.comboBoxCheckIn_sett.Size = new System.Drawing.Size(250, 32);
            this.comboBoxCheckIn_sett.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Default choice in \"Check-In\" window:";
            // 
            // comboBookVsDvd_sett_edit
            // 
            this.comboBookVsDvd_sett_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookVsDvd_sett_edit.FormattingEnabled = true;
            this.comboBookVsDvd_sett_edit.Items.AddRange(new object[] {
            "Book",
            "DVD"});
            this.comboBookVsDvd_sett_edit.Location = new System.Drawing.Point(460, 125);
            this.comboBookVsDvd_sett_edit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBookVsDvd_sett_edit.Name = "comboBookVsDvd_sett_edit";
            this.comboBookVsDvd_sett_edit.Size = new System.Drawing.Size(134, 32);
            this.comboBookVsDvd_sett_edit.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Default choice in \"Edit Book/DVD\" window:";
            // 
            // comboBookVsDvd_sett
            // 
            this.comboBookVsDvd_sett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookVsDvd_sett.FormattingEnabled = true;
            this.comboBookVsDvd_sett.Items.AddRange(new object[] {
            "Book",
            "DVD"});
            this.comboBookVsDvd_sett.Location = new System.Drawing.Point(460, 53);
            this.comboBookVsDvd_sett.Margin = new System.Windows.Forms.Padding(4);
            this.comboBookVsDvd_sett.Name = "comboBookVsDvd_sett";
            this.comboBookVsDvd_sett.Size = new System.Drawing.Size(134, 32);
            this.comboBookVsDvd_sett.TabIndex = 4;
            // 
            // comboBoxID_ISBN_sett
            // 
            this.comboBoxID_ISBN_sett.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_ISBN_sett.FormattingEnabled = true;
            this.comboBoxID_ISBN_sett.Items.AddRange(new object[] {
            "Book using ISBN",
            "Book using ID",
            "DVD using ID"});
            this.comboBoxID_ISBN_sett.Location = new System.Drawing.Point(460, 199);
            this.comboBoxID_ISBN_sett.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxID_ISBN_sett.Name = "comboBoxID_ISBN_sett";
            this.comboBoxID_ISBN_sett.Size = new System.Drawing.Size(250, 32);
            this.comboBoxID_ISBN_sett.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default choice in \"Check-Out\" window:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default choice in \"Add\" window:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 487);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // overdueOptionsPanel
            // 
            this.overdueOptionsPanel.Controls.Add(this.label9);
            this.overdueOptionsPanel.Controls.Add(this.overdueDvdCost_sett);
            this.overdueOptionsPanel.Controls.Add(this.label10);
            this.overdueOptionsPanel.Controls.Add(this.label7);
            this.overdueOptionsPanel.Controls.Add(this.label5);
            this.overdueOptionsPanel.Controls.Add(this.untilOverdue_sett);
            this.overdueOptionsPanel.Controls.Add(this.overdueBookCost_sett);
            this.overdueOptionsPanel.Controls.Add(this.label6);
            this.overdueOptionsPanel.Controls.Add(this.label8);
            this.overdueOptionsPanel.Controls.Add(this.splitter1);
            this.overdueOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overdueOptionsPanel.Location = new System.Drawing.Point(286, 111);
            this.overdueOptionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.overdueOptionsPanel.Name = "overdueOptionsPanel";
            this.overdueOptionsPanel.Size = new System.Drawing.Size(745, 487);
            this.overdueOptionsPanel.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "$";
            // 
            // overdueDvdCost_sett
            // 
            this.overdueDvdCost_sett.DecimalPlaces = 2;
            this.overdueDvdCost_sett.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.overdueDvdCost_sett.Location = new System.Drawing.Point(471, 232);
            this.overdueDvdCost_sett.Margin = new System.Windows.Forms.Padding(4);
            this.overdueDvdCost_sett.Name = "overdueDvdCost_sett";
            this.overdueDvdCost_sett.Size = new System.Drawing.Size(105, 29);
            this.overdueDvdCost_sett.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cost per day after DVD\'s overdue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Days";
            // 
            // untilOverdue_sett
            // 
            this.untilOverdue_sett.Location = new System.Drawing.Point(471, 84);
            this.untilOverdue_sett.Margin = new System.Windows.Forms.Padding(4);
            this.untilOverdue_sett.Name = "untilOverdue_sett";
            this.untilOverdue_sett.Size = new System.Drawing.Size(105, 29);
            this.untilOverdue_sett.TabIndex = 30;
            // 
            // overdueBookCost_sett
            // 
            this.overdueBookCost_sett.DecimalPlaces = 2;
            this.overdueBookCost_sett.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.overdueBookCost_sett.Location = new System.Drawing.Point(471, 158);
            this.overdueBookCost_sett.Margin = new System.Windows.Forms.Padding(4);
            this.overdueBookCost_sett.Name = "overdueBookCost_sett";
            this.overdueBookCost_sett.Size = new System.Drawing.Size(105, 29);
            this.overdueBookCost_sett.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cost per day after book\'s overdue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Until overdue period";
            // 
            // applyButton
            // 
            this.applyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.applyButton.Location = new System.Drawing.Point(517, 501);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(116, 41);
            this.applyButton.TabIndex = 23;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(669, 501);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 41);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // settingsForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1051, 618);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.overdueOptionsPanel);
            this.Controls.Add(this.comboboxDefaultsPanel);
            this.Controls.Add(this.settingsTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.comboboxDefaultsPanel.ResumeLayout(false);
            this.comboboxDefaultsPanel.PerformLayout();
            this.overdueOptionsPanel.ResumeLayout(false);
            this.overdueOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueDvdCost_sett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.untilOverdue_sett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overdueBookCost_sett)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingsTree;
        private System.Windows.Forms.Panel comboboxDefaultsPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel overdueOptionsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCheckIn_sett;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBookVsDvd_sett_edit;
        private System.Windows.Forms.ComboBox comboBookVsDvd_sett;
        private System.Windows.Forms.ComboBox comboBoxID_ISBN_sett;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.NumericUpDown untilOverdue_sett;
        private System.Windows.Forms.NumericUpDown overdueBookCost_sett;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown overdueDvdCost_sett;
        private System.Windows.Forms.Label label10;
    }
}