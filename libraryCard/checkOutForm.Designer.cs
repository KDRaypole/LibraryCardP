namespace libraryCard
{
    partial class checkOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkOutForm));
            this.bookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBoxID_ISBN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIdBox = new System.Windows.Forms.GroupBox();
            this.bookIsbnBox = new System.Windows.Forms.GroupBox();
            this.repeatedIDs = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookISBN = new System.Windows.Forms.TextBox();
            this.customerID_2 = new System.Windows.Forms.TextBox();
            this.dvdIdBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dvdID = new System.Windows.Forms.TextBox();
            this.customerID_3 = new System.Windows.Forms.TextBox();
            this.bookIdBox.SuspendLayout();
            this.bookIsbnBox.SuspendLayout();
            this.dvdIdBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(174, 114);
            this.bookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(285, 29);
            this.bookID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Book ID";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(172, 37);
            this.customerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(286, 29);
            this.customerID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer ID";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(303, 441);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(149, 441);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 41);
            this.button4.TabIndex = 22;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxID_ISBN
            // 
            this.comboBoxID_ISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID_ISBN.FormattingEnabled = true;
            this.comboBoxID_ISBN.Items.AddRange(new object[] {
            "Book using ISBN",
            "Book using ID",
            "DVD using ID"});
            this.comboBoxID_ISBN.Location = new System.Drawing.Point(205, 120);
            this.comboBoxID_ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxID_ISBN.Name = "comboBoxID_ISBN";
            this.comboBoxID_ISBN.Size = new System.Drawing.Size(285, 32);
            this.comboBoxID_ISBN.TabIndex = 1;
            this.comboBoxID_ISBN.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_ISBN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Check Out";
            // 
            // bookIdBox
            // 
            this.bookIdBox.Controls.Add(this.label2);
            this.bookIdBox.Controls.Add(this.label1);
            this.bookIdBox.Controls.Add(this.bookID);
            this.bookIdBox.Controls.Add(this.customerID);
            this.bookIdBox.Location = new System.Drawing.Point(29, 175);
            this.bookIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIdBox.Name = "bookIdBox";
            this.bookIdBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIdBox.Size = new System.Drawing.Size(501, 170);
            this.bookIdBox.TabIndex = 2;
            this.bookIdBox.TabStop = false;
            // 
            // bookIsbnBox
            // 
            this.bookIsbnBox.Controls.Add(this.repeatedIDs);
            this.bookIsbnBox.Controls.Add(this.label8);
            this.bookIsbnBox.Controls.Add(this.label4);
            this.bookIsbnBox.Controls.Add(this.label5);
            this.bookIsbnBox.Controls.Add(this.bookISBN);
            this.bookIsbnBox.Controls.Add(this.customerID_2);
            this.bookIsbnBox.Location = new System.Drawing.Point(29, 175);
            this.bookIsbnBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIsbnBox.Name = "bookIsbnBox";
            this.bookIsbnBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookIsbnBox.Size = new System.Drawing.Size(501, 238);
            this.bookIsbnBox.TabIndex = 2;
            this.bookIsbnBox.TabStop = false;
            // 
            // repeatedIDs
            // 
            this.repeatedIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repeatedIDs.Enabled = false;
            this.repeatedIDs.FormattingEnabled = true;
            this.repeatedIDs.Location = new System.Drawing.Point(176, 175);
            this.repeatedIDs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repeatedIDs.Name = "repeatedIDs";
            this.repeatedIDs.Size = new System.Drawing.Size(230, 32);
            this.repeatedIDs.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Book ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Customer ID";
            // 
            // bookISBN
            // 
            this.bookISBN.Location = new System.Drawing.Point(174, 114);
            this.bookISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookISBN.Name = "bookISBN";
            this.bookISBN.Size = new System.Drawing.Size(285, 29);
            this.bookISBN.TabIndex = 5;
            this.bookISBN.TextChanged += new System.EventHandler(this.bookISBN_TextChanged);
            // 
            // customerID_2
            // 
            this.customerID_2.Location = new System.Drawing.Point(172, 37);
            this.customerID_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID_2.Name = "customerID_2";
            this.customerID_2.Size = new System.Drawing.Size(286, 29);
            this.customerID_2.TabIndex = 3;
            // 
            // dvdIdBox
            // 
            this.dvdIdBox.Controls.Add(this.label6);
            this.dvdIdBox.Controls.Add(this.label7);
            this.dvdIdBox.Controls.Add(this.dvdID);
            this.dvdIdBox.Controls.Add(this.customerID_3);
            this.dvdIdBox.Location = new System.Drawing.Point(29, 175);
            this.dvdIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdIdBox.Name = "dvdIdBox";
            this.dvdIdBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdIdBox.Size = new System.Drawing.Size(501, 170);
            this.dvdIdBox.TabIndex = 2;
            this.dvdIdBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "DVD ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customer ID";
            // 
            // dvdID
            // 
            this.dvdID.Location = new System.Drawing.Point(174, 114);
            this.dvdID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdID.Name = "dvdID";
            this.dvdID.Size = new System.Drawing.Size(285, 29);
            this.dvdID.TabIndex = 5;
            // 
            // customerID_3
            // 
            this.customerID_3.Location = new System.Drawing.Point(172, 37);
            this.customerID_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID_3.Name = "customerID_3";
            this.customerID_3.Size = new System.Drawing.Size(286, 29);
            this.customerID_3.TabIndex = 3;
            // 
            // checkOutForm
            // 
            this.AcceptButton = this.button4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(557, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxID_ISBN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bookIsbnBox);
            this.Controls.Add(this.bookIdBox);
            this.Controls.Add(this.dvdIdBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "checkOutForm";
            this.Padding = new System.Windows.Forms.Padding(20, 111, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Checking Out";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.bookIdBox.ResumeLayout(false);
            this.bookIdBox.PerformLayout();
            this.bookIsbnBox.ResumeLayout(false);
            this.bookIsbnBox.PerformLayout();
            this.dvdIdBox.ResumeLayout(false);
            this.dvdIdBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxID_ISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox bookIdBox;
        private System.Windows.Forms.GroupBox bookIsbnBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookISBN;
        private System.Windows.Forms.TextBox customerID_2;
        private System.Windows.Forms.GroupBox dvdIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dvdID;
        private System.Windows.Forms.TextBox customerID_3;
        private System.Windows.Forms.ComboBox repeatedIDs;
        private System.Windows.Forms.Label label8;
    }
}