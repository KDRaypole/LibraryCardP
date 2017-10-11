namespace libraryCard
{
    partial class checkInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkInForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.checkOutIdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCheckIn = new System.Windows.Forms.ComboBox();
            this.bookIdLabel = new System.Windows.Forms.Label();
            this.dvdIdLabel = new System.Windows.Forms.Label();
            this.panelForLabels = new System.Windows.Forms.Panel();
            this.panelForLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(288, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 26;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(198, 181);
            this.idField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(286, 29);
            this.idField.TabIndex = 18;
            // 
            // checkOutIdLabel
            // 
            this.checkOutIdLabel.AutoSize = true;
            this.checkOutIdLabel.Location = new System.Drawing.Point(15, 6);
            this.checkOutIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkOutIdLabel.Name = "checkOutIdLabel";
            this.checkOutIdLabel.Size = new System.Drawing.Size(132, 25);
            this.checkOutIdLabel.TabIndex = 20;
            this.checkOutIdLabel.Text = "Check-Out ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Check In";
            // 
            // comboBoxCheckIn
            // 
            this.comboBoxCheckIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckIn.FormattingEnabled = true;
            this.comboBoxCheckIn.Items.AddRange(new object[] {
            "Book using ID",
            "DVD using ID"});
            this.comboBoxCheckIn.Location = new System.Drawing.Point(198, 120);
            this.comboBoxCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCheckIn.Name = "comboBoxCheckIn";
            this.comboBoxCheckIn.Size = new System.Drawing.Size(285, 32);
            this.comboBoxCheckIn.TabIndex = 30;
            this.comboBoxCheckIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxCheckIn_SelectedIndexChanged);
            // 
            // bookIdLabel
            // 
            this.bookIdLabel.AutoSize = true;
            this.bookIdLabel.Location = new System.Drawing.Point(64, 6);
            this.bookIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookIdLabel.Name = "bookIdLabel";
            this.bookIdLabel.Size = new System.Drawing.Size(81, 25);
            this.bookIdLabel.TabIndex = 32;
            this.bookIdLabel.Text = "Book ID";
            // 
            // dvdIdLabel
            // 
            this.dvdIdLabel.AutoSize = true;
            this.dvdIdLabel.Location = new System.Drawing.Point(68, 6);
            this.dvdIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdIdLabel.Name = "dvdIdLabel";
            this.dvdIdLabel.Size = new System.Drawing.Size(78, 25);
            this.dvdIdLabel.TabIndex = 33;
            this.dvdIdLabel.Text = "DVD ID";
            // 
            // panelForLabels
            // 
            this.panelForLabels.Controls.Add(this.dvdIdLabel);
            this.panelForLabels.Controls.Add(this.bookIdLabel);
            this.panelForLabels.Controls.Add(this.checkOutIdLabel);
            this.panelForLabels.Location = new System.Drawing.Point(42, 181);
            this.panelForLabels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForLabels.Name = "panelForLabels";
            this.panelForLabels.Size = new System.Drawing.Size(150, 41);
            this.panelForLabels.TabIndex = 34;
            // 
            // checkInForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(545, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCheckIn);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelForLabels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "checkInForm";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Checking-In";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.checkInForm_Load);
            this.panelForLabels.ResumeLayout(false);
            this.panelForLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label checkOutIdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCheckIn;
        private System.Windows.Forms.Label bookIdLabel;
        private System.Windows.Forms.Label dvdIdLabel;
        private System.Windows.Forms.Panel panelForLabels;
    }
}