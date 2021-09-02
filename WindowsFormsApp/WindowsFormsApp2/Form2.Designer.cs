
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentGrp = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.agebox = new System.Windows.Forms.TextBox();
            this.grpBoxHostel = new System.Windows.Forms.GroupBox();
            this.rdbtnYes = new System.Windows.Forms.RadioButton();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.labelAgeCal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelImg = new System.Windows.Forms.Label();
            this.labelHostel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDob = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelMob = new System.Windows.Forms.Label();
            this.rdbtnOther = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelCurrentyr = new System.Windows.Forms.Label();
            this.labelDoj = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNoYrs = new System.Windows.Forms.Label();
            this.labelDepart = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepart = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDOJ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCurrentyr = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMob = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDOB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFees = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHostel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInterest = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderimage = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.StudentGrp.SuspendLayout();
            this.grpBoxHostel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurrentyr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.updateToolStripMenuItem.Text = "View";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.departmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // StudentGrp
            // 
            this.StudentGrp.Controls.Add(this.textBox4);
            this.StudentGrp.Controls.Add(this.checkedListBox1);
            this.StudentGrp.Controls.Add(this.agebox);
            this.StudentGrp.Controls.Add(this.grpBoxHostel);
            this.StudentGrp.Controls.Add(this.labelAgeCal);
            this.StudentGrp.Controls.Add(this.btnCancel);
            this.StudentGrp.Controls.Add(this.btnRegister);
            this.StudentGrp.Controls.Add(this.btnReset);
            this.StudentGrp.Controls.Add(this.btnBrowse);
            this.StudentGrp.Controls.Add(this.pictureBox1);
            this.StudentGrp.Controls.Add(this.labelImg);
            this.StudentGrp.Controls.Add(this.labelHostel);
            this.StudentGrp.Controls.Add(this.textBox6);
            this.StudentGrp.Controls.Add(this.labelFees);
            this.StudentGrp.Controls.Add(this.labelInterest);
            this.StudentGrp.Controls.Add(this.labelAge);
            this.StudentGrp.Controls.Add(this.dateTimePicker2);
            this.StudentGrp.Controls.Add(this.dateTimePicker1);
            this.StudentGrp.Controls.Add(this.labelDob);
            this.StudentGrp.Controls.Add(this.textBox7);
            this.StudentGrp.Controls.Add(this.labelMob);
            this.StudentGrp.Controls.Add(this.rdbtnOther);
            this.StudentGrp.Controls.Add(this.rdbtnFemale);
            this.StudentGrp.Controls.Add(this.rdbtnMale);
            this.StudentGrp.Controls.Add(this.comboBox1);
            this.StudentGrp.Controls.Add(this.labelGender);
            this.StudentGrp.Controls.Add(this.textBox5);
            this.StudentGrp.Controls.Add(this.labelCurrentyr);
            this.StudentGrp.Controls.Add(this.labelDoj);
            this.StudentGrp.Controls.Add(this.textBox2);
            this.StudentGrp.Controls.Add(this.labelNoYrs);
            this.StudentGrp.Controls.Add(this.labelDepart);
            this.StudentGrp.Controls.Add(this.textBox3);
            this.StudentGrp.Controls.Add(this.labelEmail);
            this.StudentGrp.Controls.Add(this.textBox1);
            this.StudentGrp.Controls.Add(this.labelName);
            this.StudentGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentGrp.Location = new System.Drawing.Point(21, 83);
            this.StudentGrp.Name = "StudentGrp";
            this.StudentGrp.Size = new System.Drawing.Size(1316, 603);
            this.StudentGrp.TabIndex = 2;
            this.StudentGrp.TabStop = false;
            this.StudentGrp.Text = "Student Registration";
            this.StudentGrp.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(881, 368);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(257, 30);
            this.textBox4.TabIndex = 75;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sports",
            "Music",
            "Reading books",
            "Tracking"});
            this.checkedListBox1.Location = new System.Drawing.Point(881, 253);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(257, 92);
            this.checkedListBox1.TabIndex = 50;
            this.checkedListBox1.Validating += new System.ComponentModel.CancelEventHandler(this.checkedListBox1_Validating);
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(881, 163);
            this.agebox.Multiline = true;
            this.agebox.Name = "agebox";
            this.agebox.ReadOnly = true;
            this.agebox.Size = new System.Drawing.Size(257, 31);
            this.agebox.TabIndex = 49;
            // 
            // grpBoxHostel
            // 
            this.grpBoxHostel.Controls.Add(this.rdbtnYes);
            this.grpBoxHostel.Controls.Add(this.rdbtnNo);
            this.grpBoxHostel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBoxHostel.Location = new System.Drawing.Point(881, 404);
            this.grpBoxHostel.Name = "grpBoxHostel";
            this.grpBoxHostel.Size = new System.Drawing.Size(257, 65);
            this.grpBoxHostel.TabIndex = 48;
            this.grpBoxHostel.TabStop = false;
            this.grpBoxHostel.Validating += new System.ComponentModel.CancelEventHandler(this.grpBoxHostel_Validating);
            // 
            // rdbtnYes
            // 
            this.rdbtnYes.AutoSize = true;
            this.rdbtnYes.Checked = true;
            this.rdbtnYes.Location = new System.Drawing.Point(0, 26);
            this.rdbtnYes.Name = "rdbtnYes";
            this.rdbtnYes.Size = new System.Drawing.Size(58, 24);
            this.rdbtnYes.TabIndex = 23;
            this.rdbtnYes.TabStop = true;
            this.rdbtnYes.Text = "Yes";
            this.rdbtnYes.UseVisualStyleBackColor = true;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Location = new System.Drawing.Point(105, 26);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(51, 24);
            this.rdbtnNo.TabIndex = 22;
            this.rdbtnNo.Text = "No";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // labelAgeCal
            // 
            this.labelAgeCal.AutoSize = true;
            this.labelAgeCal.Location = new System.Drawing.Point(877, 171);
            this.labelAgeCal.Name = "labelAgeCal";
            this.labelAgeCal.Size = new System.Drawing.Size(0, 20);
            this.labelAgeCal.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1082, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(713, 496);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(104, 43);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(896, 496);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 43);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(453, 434);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 35);
            this.btnBrowse.TabIndex = 42;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images2;
            this.pictureBox1.Location = new System.Drawing.Point(220, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Validating += new System.ComponentModel.CancelEventHandler(this.pictureBox1_Validating);
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Location = new System.Drawing.Point(61, 375);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(54, 20);
            this.labelImg.TabIndex = 40;
            this.labelImg.Text = "Image";
            // 
            // labelHostel
            // 
            this.labelHostel.AutoSize = true;
            this.labelHostel.Location = new System.Drawing.Point(723, 430);
            this.labelHostel.Name = "labelHostel";
            this.labelHostel.Size = new System.Drawing.Size(58, 20);
            this.labelHostel.TabIndex = 37;
            this.labelHostel.Text = "Hostel";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1645, 365);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(257, 30);
            this.textBox6.TabIndex = 36;
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Location = new System.Drawing.Point(722, 372);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(46, 20);
            this.labelFees.TabIndex = 35;
            this.labelFees.Text = "Fees";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(722, 267);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(65, 20);
            this.labelInterest.TabIndex = 30;
            this.labelInterest.Text = "Interest";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(723, 166);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 28;
            this.labelAge.Text = "Age";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(881, 112);
            this.dateTimePicker2.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1997, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(257, 27);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker2_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 261);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 8, 7, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 27);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(722, 115);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(105, 20);
            this.labelDob.TabIndex = 24;
            this.labelDob.Text = "Date of Birth";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(881, 62);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(257, 31);
            this.textBox7.TabIndex = 23;
            this.textBox7.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // labelMob
            // 
            this.labelMob.AutoSize = true;
            this.labelMob.Location = new System.Drawing.Point(722, 65);
            this.labelMob.Name = "labelMob";
            this.labelMob.Size = new System.Drawing.Size(88, 20);
            this.labelMob.TabIndex = 22;
            this.labelMob.Text = "Mobile No.";
            // 
            // rdbtnOther
            // 
            this.rdbtnOther.AutoSize = true;
            this.rdbtnOther.Location = new System.Drawing.Point(1076, 212);
            this.rdbtnOther.Name = "rdbtnOther";
            this.rdbtnOther.Size = new System.Drawing.Size(72, 24);
            this.rdbtnOther.TabIndex = 21;
            this.rdbtnOther.Text = "Other";
            this.rdbtnOther.UseVisualStyleBackColor = true;
            this.rdbtnOther.Validating += new System.ComponentModel.CancelEventHandler(this.rdbtnOther_Validating);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(972, 212);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(85, 24);
            this.rdbtnFemale.TabIndex = 20;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            this.rdbtnFemale.Validating += new System.ComponentModel.CancelEventHandler(this.rdbtnOther_Validating);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Checked = true;
            this.rdbtnMale.Location = new System.Drawing.Point(881, 212);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(66, 24);
            this.rdbtnMale.TabIndex = 19;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtnMale_CheckedChanged);
            this.rdbtnMale.Validating += new System.ComponentModel.CancelEventHandler(this.rdbtnOther_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(220, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(723, 217);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 20);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "Gender";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 314);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(257, 31);
            this.textBox5.TabIndex = 15;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // labelCurrentyr
            // 
            this.labelCurrentyr.AutoSize = true;
            this.labelCurrentyr.Location = new System.Drawing.Point(61, 317);
            this.labelCurrentyr.Name = "labelCurrentyr";
            this.labelCurrentyr.Size = new System.Drawing.Size(104, 20);
            this.labelCurrentyr.TabIndex = 14;
            this.labelCurrentyr.Text = "Current Year";
            // 
            // labelDoj
            // 
            this.labelDoj.AutoSize = true;
            this.labelDoj.Location = new System.Drawing.Point(61, 267);
            this.labelDoj.Name = "labelDoj";
            this.labelDoj.Size = new System.Drawing.Size(122, 20);
            this.labelDoj.TabIndex = 12;
            this.labelDoj.Text = "Date of Joining";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 213);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 31);
            this.textBox2.TabIndex = 11;
            // 
            // labelNoYrs
            // 
            this.labelNoYrs.AutoSize = true;
            this.labelNoYrs.Location = new System.Drawing.Point(61, 216);
            this.labelNoYrs.Name = "labelNoYrs";
            this.labelNoYrs.Size = new System.Drawing.Size(73, 20);
            this.labelNoYrs.TabIndex = 10;
            this.labelNoYrs.Text = "Duration";
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.Location = new System.Drawing.Point(61, 166);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(97, 20);
            this.labelDepart.TabIndex = 8;
            this.labelDepart.Text = "Department";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 112);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 31);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(61, 115);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(113, 20);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Student Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(61, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Student Name";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderDepart
            // 
            this.errorProviderDepart.ContainerControl = this;
            // 
            // errorProviderDOJ
            // 
            this.errorProviderDOJ.ContainerControl = this;
            // 
            // errorProviderCurrentyr
            // 
            this.errorProviderCurrentyr.ContainerControl = this;
            // 
            // errorProviderMob
            // 
            this.errorProviderMob.ContainerControl = this;
            // 
            // errorProviderDOB
            // 
            this.errorProviderDOB.ContainerControl = this;
            // 
            // errorProviderFees
            // 
            this.errorProviderFees.ContainerControl = this;
            // 
            // errorProviderGender
            // 
            this.errorProviderGender.ContainerControl = this;
            // 
            // errorProviderHostel
            // 
            this.errorProviderHostel.ContainerControl = this;
            // 
            // errorProviderInterest
            // 
            this.errorProviderInterest.ContainerControl = this;
            // 
            // errorProviderimage
            // 
            this.errorProviderimage.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 652);
            this.Controls.Add(this.StudentGrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StudentGrp.ResumeLayout(false);
            this.StudentGrp.PerformLayout();
            this.grpBoxHostel.ResumeLayout(false);
            this.grpBoxHostel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurrentyr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.GroupBox StudentGrp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelMob;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelCurrentyr;
        private System.Windows.Forms.Label labelDoj;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNoYrs;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.Label labelHostel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderDepart;
        private System.Windows.Forms.ErrorProvider errorProviderDOJ;
        private System.Windows.Forms.ErrorProvider errorProviderCurrentyr;
        private System.Windows.Forms.ErrorProvider errorProviderMob;
        private System.Windows.Forms.ErrorProvider errorProviderDOB;
        private System.Windows.Forms.Label labelAgeCal;
        private System.Windows.Forms.ErrorProvider errorProviderFees;
        private System.Windows.Forms.GroupBox grpBoxHostel;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.ErrorProvider errorProviderGender;
        private System.Windows.Forms.RadioButton rdbtnYes;
        private System.Windows.Forms.ErrorProvider errorProviderHostel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ErrorProvider errorProviderInterest;
        private System.Windows.Forms.ErrorProvider errorProviderimage;
        private System.Windows.Forms.RadioButton rdbtnOther;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        public System.Windows.Forms.TextBox textBox4;
    }
}