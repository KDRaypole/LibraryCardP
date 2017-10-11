namespace libraryCard
{
    partial class bookAddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.getData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.condPoor = new System.Windows.Forms.RadioButton();
            this.condFair = new System.Windows.Forms.RadioButton();
            this.condGood = new System.Windows.Forms.RadioButton();
            this.condNew = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pageCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBookVsDvd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addBookPanel = new System.Windows.Forms.Panel();
            this.bookLocation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addDvdPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dvdLocation = new System.Windows.Forms.TextBox();
            this.actors = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dvdDirector = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dvdTitle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dvdGenre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dvdYear = new System.Windows.Forms.TextBox();
            this.addBookPanel.SuspendLayout();
            this.addDvdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(158, 22);
            this.bookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(380, 29);
            this.bookTitle.TabIndex = 1;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author(s)";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(158, 66);
            this.author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(380, 29);
            this.author.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(158, 111);
            this.ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(380, 29);
            this.ISBN.TabIndex = 5;
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(160, 683);
            this.getData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(105, 41);
            this.getData.TabIndex = 12;
            this.getData.Text = "Add";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(304, 683);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(158, 153);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(380, 29);
            this.genre.TabIndex = 6;
            // 
            // condPoor
            // 
            this.condPoor.AutoSize = true;
            this.condPoor.Location = new System.Drawing.Point(189, 622);
            this.condPoor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condPoor.Name = "condPoor";
            this.condPoor.Size = new System.Drawing.Size(78, 29);
            this.condPoor.TabIndex = 11;
            this.condPoor.TabStop = true;
            this.condPoor.Text = "Poor";
            this.condPoor.UseVisualStyleBackColor = true;
            // 
            // condFair
            // 
            this.condFair.AutoSize = true;
            this.condFair.Location = new System.Drawing.Point(189, 587);
            this.condFair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condFair.Name = "condFair";
            this.condFair.Size = new System.Drawing.Size(70, 29);
            this.condFair.TabIndex = 10;
            this.condFair.TabStop = true;
            this.condFair.Text = "Fair";
            this.condFair.UseVisualStyleBackColor = true;
            // 
            // condGood
            // 
            this.condGood.AutoSize = true;
            this.condGood.Location = new System.Drawing.Point(189, 552);
            this.condGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condGood.Name = "condGood";
            this.condGood.Size = new System.Drawing.Size(85, 29);
            this.condGood.TabIndex = 9;
            this.condGood.TabStop = true;
            this.condGood.Text = "Good";
            this.condGood.UseVisualStyleBackColor = true;
            // 
            // condNew
            // 
            this.condNew.AutoSize = true;
            this.condNew.Location = new System.Drawing.Point(189, 517);
            this.condNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.condNew.Name = "condNew";
            this.condNew.Size = new System.Drawing.Size(76, 29);
            this.condNew.TabIndex = 8;
            this.condNew.TabStop = true;
            this.condNew.Text = "New";
            this.condNew.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Condition";
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(158, 199);
            this.pageCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(380, 29);
            this.pageCount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Page Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "?";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // comboBookVsDvd
            // 
            this.comboBookVsDvd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookVsDvd.FormattingEnabled = true;
            this.comboBookVsDvd.Items.AddRange(new object[] {
            "Book",
            "DVD"});
            this.comboBookVsDvd.Location = new System.Drawing.Point(174, 124);
            this.comboBookVsDvd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBookVsDvd.Name = "comboBookVsDvd";
            this.comboBookVsDvd.Size = new System.Drawing.Size(134, 32);
            this.comboBookVsDvd.TabIndex = 20;
            this.comboBookVsDvd.SelectedIndexChanged += new System.EventHandler(this.comboBookVsDvd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Add";
            // 
            // addBookPanel
            // 
            this.addBookPanel.Controls.Add(this.bookLocation);
            this.addBookPanel.Controls.Add(this.label13);
            this.addBookPanel.Controls.Add(this.label6);
            this.addBookPanel.Controls.Add(this.label1);
            this.addBookPanel.Controls.Add(this.pageCount);
            this.addBookPanel.Controls.Add(this.bookTitle);
            this.addBookPanel.Controls.Add(this.label7);
            this.addBookPanel.Controls.Add(this.label2);
            this.addBookPanel.Controls.Add(this.author);
            this.addBookPanel.Controls.Add(this.label3);
            this.addBookPanel.Controls.Add(this.ISBN);
            this.addBookPanel.Controls.Add(this.label4);
            this.addBookPanel.Controls.Add(this.genre);
            this.addBookPanel.Location = new System.Drawing.Point(11, 179);
            this.addBookPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.Size = new System.Drawing.Size(552, 347);
            this.addBookPanel.TabIndex = 2;
            // 
            // bookLocation
            // 
            this.bookLocation.Location = new System.Drawing.Point(158, 244);
            this.bookLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookLocation.Name = "bookLocation";
            this.bookLocation.Size = new System.Drawing.Size(380, 29);
            this.bookLocation.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Location";
            // 
            // addDvdPanel
            // 
            this.addDvdPanel.Controls.Add(this.label12);
            this.addDvdPanel.Controls.Add(this.dvdLocation);
            this.addDvdPanel.Controls.Add(this.actors);
            this.addDvdPanel.Controls.Add(this.label11);
            this.addDvdPanel.Controls.Add(this.label9);
            this.addDvdPanel.Controls.Add(this.dvdDirector);
            this.addDvdPanel.Controls.Add(this.label10);
            this.addDvdPanel.Controls.Add(this.rating);
            this.addDvdPanel.Controls.Add(this.label17);
            this.addDvdPanel.Controls.Add(this.dvdTitle);
            this.addDvdPanel.Controls.Add(this.label19);
            this.addDvdPanel.Controls.Add(this.dvdGenre);
            this.addDvdPanel.Controls.Add(this.label20);
            this.addDvdPanel.Controls.Add(this.dvdYear);
            this.addDvdPanel.Location = new System.Drawing.Point(11, 179);
            this.addDvdPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDvdPanel.Name = "addDvdPanel";
            this.addDvdPanel.Size = new System.Drawing.Size(552, 347);
            this.addDvdPanel.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 294);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Location";
            // 
            // dvdLocation
            // 
            this.dvdLocation.Location = new System.Drawing.Point(158, 286);
            this.dvdLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdLocation.Name = "dvdLocation";
            this.dvdLocation.Size = new System.Drawing.Size(380, 29);
            this.dvdLocation.TabIndex = 8;
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(158, 109);
            this.actors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(380, 29);
            this.actors.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Actors";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Director";
            // 
            // dvdDirector
            // 
            this.dvdDirector.Location = new System.Drawing.Point(158, 65);
            this.dvdDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdDirector.Name = "dvdDirector";
            this.dvdDirector.Size = new System.Drawing.Size(380, 29);
            this.dvdDirector.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rating";
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(158, 242);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(380, 29);
            this.rating.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 30);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "DVD Title";
            // 
            // dvdTitle
            // 
            this.dvdTitle.Location = new System.Drawing.Point(158, 22);
            this.dvdTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdTitle.Name = "dvdTitle";
            this.dvdTitle.Size = new System.Drawing.Size(380, 29);
            this.dvdTitle.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 205);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Genre";
            // 
            // dvdGenre
            // 
            this.dvdGenre.Location = new System.Drawing.Point(158, 198);
            this.dvdGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdGenre.Name = "dvdGenre";
            this.dvdGenre.Size = new System.Drawing.Size(380, 29);
            this.dvdGenre.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 161);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Year";
            // 
            // dvdYear
            // 
            this.dvdYear.Location = new System.Drawing.Point(158, 153);
            this.dvdYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvdYear.Name = "dvdYear";
            this.dvdYear.Size = new System.Drawing.Size(380, 29);
            this.dvdYear.TabIndex = 4;
            // 
            // bookAddForm
            // 
            this.AcceptButton = this.getData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(574, 748);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condNew);
            this.Controls.Add(this.condGood);
            this.Controls.Add(this.condFair);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.condPoor);
            this.Controls.Add(this.comboBookVsDvd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.addDvdPanel);
            this.Controls.Add(this.addBookPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "bookAddForm";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Add Book/DVD";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.bookAddForm_Load);
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            this.addDvdPanel.ResumeLayout(false);
            this.addDvdPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.RadioButton condPoor;
        private System.Windows.Forms.RadioButton condFair;
        private System.Windows.Forms.RadioButton condGood;
        private System.Windows.Forms.RadioButton condNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pageCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBookVsDvd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addBookPanel;
        private System.Windows.Forms.Panel addDvdPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dvdTitle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox dvdGenre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox dvdYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dvdDirector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox actors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bookLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dvdLocation;
    }
}