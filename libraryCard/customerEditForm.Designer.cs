namespace libraryCard
{
    partial class customerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerEditForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.zipLab = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.stateLab = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.ComboBox();
            this.cityLab = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.stAdLab = new System.Windows.Forms.Label();
            this.stAd = new System.Windows.Forms.TextBox();
            this.slash1Lab = new System.Windows.Forms.Label();
            this.slash2Lab = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.yLab = new System.Windows.Forms.Label();
            this.mLab = new System.Windows.Forms.Label();
            this.dLab = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.dateBirthLab = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.GroupBox();
            this.lNameBox = new System.Windows.Forms.GroupBox();
            this.phoneBox = new System.Windows.Forms.GroupBox();
            this.DateOfBirthBox = new System.Windows.Forms.GroupBox();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.notesBox = new System.Windows.Forms.GroupBox();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fNameBox.SuspendLayout();
            this.lNameBox.SuspendLayout();
            this.phoneBox.SuspendLayout();
            this.DateOfBirthBox.SuspendLayout();
            this.addressBox.SuspendLayout();
            this.notesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 22);
            this.button2.TabIndex = 101;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 22);
            this.button1.TabIndex = 100;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(93, 64);
            this.id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(143, 20);
            this.id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "What to Edit:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Phone",
            "Address",
            "Date of Birth",
            "Notes"});
            this.comboBox1.Location = new System.Drawing.Point(94, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(14, 24);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fNameLabel.TabIndex = 20;
            this.fNameLabel.Text = "First Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(79, 23);
            this.fName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(113, 20);
            this.fName.TabIndex = 21;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(79, 23);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(113, 20);
            this.lName.TabIndex = 23;
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(14, 24);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lNameLabel.TabIndex = 22;
            this.lNameLabel.Text = "Last Name";
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(79, 23);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(113, 20);
            this.phoneNum.TabIndex = 24;
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(14, 24);
            this.phoneNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(48, 13);
            this.phoneNumLabel.TabIndex = 25;
            this.phoneNumLabel.Text = "Phone #";
            // 
            // zipLab
            // 
            this.zipLab.AutoSize = true;
            this.zipLab.Location = new System.Drawing.Point(95, 113);
            this.zipLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipLab.Name = "zipLab";
            this.zipLab.Size = new System.Drawing.Size(52, 13);
            this.zipLab.TabIndex = 43;
            this.zipLab.Text = "ZIP Code";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(98, 129);
            this.zip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(97, 20);
            this.zip.TabIndex = 39;
            // 
            // stateLab
            // 
            this.stateLab.AutoSize = true;
            this.stateLab.Location = new System.Drawing.Point(17, 113);
            this.stateLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLab.Name = "stateLab";
            this.stateLab.Size = new System.Drawing.Size(32, 13);
            this.stateLab.TabIndex = 42;
            this.stateLab.Text = "State";
            // 
            // state
            // 
            this.state.AutoCompleteCustomSource.AddRange(new string[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.state.FormattingEnabled = true;
            this.state.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.state.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.state.Location = new System.Drawing.Point(20, 128);
            this.state.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(68, 21);
            this.state.TabIndex = 38;
            // 
            // cityLab
            // 
            this.cityLab.AutoSize = true;
            this.cityLab.Location = new System.Drawing.Point(17, 67);
            this.cityLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLab.Name = "cityLab";
            this.cityLab.Size = new System.Drawing.Size(24, 13);
            this.cityLab.TabIndex = 41;
            this.cityLab.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(20, 85);
            this.city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(175, 20);
            this.city.TabIndex = 37;
            // 
            // stAdLab
            // 
            this.stAdLab.AutoSize = true;
            this.stAdLab.Location = new System.Drawing.Point(17, 21);
            this.stAdLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stAdLab.Name = "stAdLab";
            this.stAdLab.Size = new System.Drawing.Size(76, 13);
            this.stAdLab.TabIndex = 40;
            this.stAdLab.Text = "Street Address";
            // 
            // stAd
            // 
            this.stAd.Location = new System.Drawing.Point(20, 44);
            this.stAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stAd.Name = "stAd";
            this.stAd.Size = new System.Drawing.Size(175, 20);
            this.stAd.TabIndex = 36;
            // 
            // slash1Lab
            // 
            this.slash1Lab.AutoSize = true;
            this.slash1Lab.Location = new System.Drawing.Point(82, 67);
            this.slash1Lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slash1Lab.Name = "slash1Lab";
            this.slash1Lab.Size = new System.Drawing.Size(12, 13);
            this.slash1Lab.TabIndex = 55;
            this.slash1Lab.Text = "/";
            // 
            // slash2Lab
            // 
            this.slash2Lab.AutoSize = true;
            this.slash2Lab.Location = new System.Drawing.Point(134, 67);
            this.slash2Lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slash2Lab.Name = "slash2Lab";
            this.slash2Lab.Size = new System.Drawing.Size(12, 13);
            this.slash2Lab.TabIndex = 54;
            this.slash2Lab.Text = "/";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(147, 65);
            this.year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(38, 20);
            this.year.TabIndex = 49;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(94, 65);
            this.day.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(38, 20);
            this.day.TabIndex = 48;
            // 
            // yLab
            // 
            this.yLab.AutoSize = true;
            this.yLab.Location = new System.Drawing.Point(144, 48);
            this.yLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLab.Name = "yLab";
            this.yLab.Size = new System.Drawing.Size(21, 13);
            this.yLab.TabIndex = 53;
            this.yLab.Text = "YY";
            // 
            // mLab
            // 
            this.mLab.AutoSize = true;
            this.mLab.Location = new System.Drawing.Point(41, 48);
            this.mLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLab.Name = "mLab";
            this.mLab.Size = new System.Drawing.Size(25, 13);
            this.mLab.TabIndex = 52;
            this.mLab.Text = "MM";
            // 
            // dLab
            // 
            this.dLab.AutoSize = true;
            this.dLab.Location = new System.Drawing.Point(92, 48);
            this.dLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dLab.Name = "dLab";
            this.dLab.Size = new System.Drawing.Size(23, 13);
            this.dLab.TabIndex = 51;
            this.dLab.Text = "DD";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(41, 65);
            this.month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(38, 20);
            this.month.TabIndex = 47;
            // 
            // dateBirthLab
            // 
            this.dateBirthLab.AutoSize = true;
            this.dateBirthLab.Location = new System.Drawing.Point(20, 24);
            this.dateBirthLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateBirthLab.Name = "dateBirthLab";
            this.dateBirthLab.Size = new System.Drawing.Size(66, 13);
            this.dateBirthLab.TabIndex = 50;
            this.dateBirthLab.Text = "Date of Birth";
            // 
            // fNameBox
            // 
            this.fNameBox.Controls.Add(this.fNameLabel);
            this.fNameBox.Controls.Add(this.fName);
            this.fNameBox.Location = new System.Drawing.Point(20, 117);
            this.fNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fNameBox.Size = new System.Drawing.Size(213, 58);
            this.fNameBox.TabIndex = 56;
            this.fNameBox.TabStop = false;
            // 
            // lNameBox
            // 
            this.lNameBox.Controls.Add(this.lNameLabel);
            this.lNameBox.Controls.Add(this.lName);
            this.lNameBox.Location = new System.Drawing.Point(20, 117);
            this.lNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lNameBox.Size = new System.Drawing.Size(213, 58);
            this.lNameBox.TabIndex = 57;
            this.lNameBox.TabStop = false;
            // 
            // phoneBox
            // 
            this.phoneBox.Controls.Add(this.phoneNumLabel);
            this.phoneBox.Controls.Add(this.phoneNum);
            this.phoneBox.Location = new System.Drawing.Point(20, 117);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneBox.Size = new System.Drawing.Size(213, 58);
            this.phoneBox.TabIndex = 58;
            this.phoneBox.TabStop = false;
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Controls.Add(this.dateBirthLab);
            this.DateOfBirthBox.Controls.Add(this.month);
            this.DateOfBirthBox.Controls.Add(this.yLab);
            this.DateOfBirthBox.Controls.Add(this.slash1Lab);
            this.DateOfBirthBox.Controls.Add(this.slash2Lab);
            this.DateOfBirthBox.Controls.Add(this.day);
            this.DateOfBirthBox.Controls.Add(this.mLab);
            this.DateOfBirthBox.Controls.Add(this.dLab);
            this.DateOfBirthBox.Controls.Add(this.year);
            this.DateOfBirthBox.Location = new System.Drawing.Point(20, 117);
            this.DateOfBirthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateOfBirthBox.Size = new System.Drawing.Size(213, 104);
            this.DateOfBirthBox.TabIndex = 58;
            this.DateOfBirthBox.TabStop = false;
            // 
            // addressBox
            // 
            this.addressBox.Controls.Add(this.stAd);
            this.addressBox.Controls.Add(this.city);
            this.addressBox.Controls.Add(this.stateLab);
            this.addressBox.Controls.Add(this.zipLab);
            this.addressBox.Controls.Add(this.state);
            this.addressBox.Controls.Add(this.cityLab);
            this.addressBox.Controls.Add(this.zip);
            this.addressBox.Controls.Add(this.stAdLab);
            this.addressBox.Location = new System.Drawing.Point(20, 117);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Size = new System.Drawing.Size(213, 165);
            this.addressBox.TabIndex = 59;
            this.addressBox.TabStop = false;
            // 
            // notesBox
            // 
            this.notesBox.Controls.Add(this.notes);
            this.notesBox.Controls.Add(this.label6);
            this.notesBox.Location = new System.Drawing.Point(20, 117);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notesBox.Name = "notesBox";
            this.notesBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notesBox.Size = new System.Drawing.Size(213, 165);
            this.notesBox.TabIndex = 60;
            this.notesBox.TabStop = false;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(20, 39);
            this.notes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(175, 112);
            this.notes.TabIndex = 41;
            this.notes.Text = "";
            this.notes.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Notes";
            // 
            // customerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 327);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.DateOfBirthBox);
            this.Controls.Add(this.addressBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "customerEditForm";
            this.Padding = new System.Windows.Forms.Padding(11, 60, 11, 11);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Edit Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.fNameBox.ResumeLayout(false);
            this.fNameBox.PerformLayout();
            this.lNameBox.ResumeLayout(false);
            this.lNameBox.PerformLayout();
            this.phoneBox.ResumeLayout(false);
            this.phoneBox.PerformLayout();
            this.DateOfBirthBox.ResumeLayout(false);
            this.DateOfBirthBox.PerformLayout();
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.notesBox.ResumeLayout(false);
            this.notesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label zipLab;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label stateLab;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.Label cityLab;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label stAdLab;
        private System.Windows.Forms.TextBox stAd;
        private System.Windows.Forms.Label slash1Lab;
        private System.Windows.Forms.Label slash2Lab;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label yLab;
        private System.Windows.Forms.Label mLab;
        private System.Windows.Forms.Label dLab;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label dateBirthLab;
        private System.Windows.Forms.GroupBox fNameBox;
        private System.Windows.Forms.GroupBox lNameBox;
        private System.Windows.Forms.GroupBox phoneBox;
        private System.Windows.Forms.GroupBox DateOfBirthBox;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.GroupBox notesBox;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Label label6;
    }
}