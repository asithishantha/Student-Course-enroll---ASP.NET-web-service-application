namespace Assignment2__client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblid = new System.Windows.Forms.Label();
            this.studentdelete = new System.Windows.Forms.Button();
            this.studentedit = new System.Windows.Forms.Button();
            this.studentadd = new System.Windows.Forms.Button();
            this.txtstudentid = new System.Windows.Forms.Label();
            this.textstudentcontactperson = new System.Windows.Forms.TextBox();
            this.textstudentemail = new System.Windows.Forms.TextBox();
            this.textstudentnic = new System.Windows.Forms.TextBox();
            this.textstudentaddress = new System.Windows.Forms.TextBox();
            this.textstudentcontact = new System.Windows.Forms.TextBox();
            this.textstudentname = new System.Windows.Forms.TextBox();
            this.textstudentcode = new System.Windows.Forms.TextBox();
            this.txtstudentcontactperson = new System.Windows.Forms.Label();
            this.txtstudentemail = new System.Windows.Forms.Label();
            this.txtstudentnic = new System.Windows.Forms.Label();
            this.txtstudentaddres = new System.Windows.Forms.Label();
            this.txtstudentcontact = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.Label();
            this.txtstudentcode = new System.Windows.Forms.Label();
            this.gridupdatestudent = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.coursedeletebtn = new System.Windows.Forms.Button();
            this.courseeditbtn = new System.Windows.Forms.Button();
            this.courseaddbtn = new System.Windows.Forms.Button();
            this.textsemesternumber = new System.Windows.Forms.TextBox();
            this.textcoursecredits = new System.Windows.Forms.TextBox();
            this.textcoursename = new System.Windows.Forms.TextBox();
            this.textcoursecode = new System.Windows.Forms.TextBox();
            this.courselblid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textenrollcoursename = new System.Windows.Forms.TextBox();
            this.textenrollcourseid = new System.Windows.Forms.TextBox();
            this.textenrollstudentname = new System.Windows.Forms.TextBox();
            this.textenrollid = new System.Windows.Forms.TextBox();
            this.dgvcourse1 = new System.Windows.Forms.DataGridView();
            this.dgvstudent1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 639);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.lblid);
            this.tabPage1.Controls.Add(this.studentdelete);
            this.tabPage1.Controls.Add(this.studentedit);
            this.tabPage1.Controls.Add(this.studentadd);
            this.tabPage1.Controls.Add(this.txtstudentid);
            this.tabPage1.Controls.Add(this.textstudentcontactperson);
            this.tabPage1.Controls.Add(this.textstudentemail);
            this.tabPage1.Controls.Add(this.textstudentnic);
            this.tabPage1.Controls.Add(this.textstudentaddress);
            this.tabPage1.Controls.Add(this.textstudentcontact);
            this.tabPage1.Controls.Add(this.textstudentname);
            this.tabPage1.Controls.Add(this.textstudentcode);
            this.tabPage1.Controls.Add(this.txtstudentcontactperson);
            this.tabPage1.Controls.Add(this.txtstudentemail);
            this.tabPage1.Controls.Add(this.txtstudentnic);
            this.tabPage1.Controls.Add(this.txtstudentaddres);
            this.tabPage1.Controls.Add(this.txtstudentcontact);
            this.tabPage1.Controls.Add(this.txtstudentname);
            this.tabPage1.Controls.Add(this.txtstudentcode);
            this.tabPage1.Controls.Add(this.gridupdatestudent);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dgvstudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1279, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STUDENT";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(165, 15);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 21;
            // 
            // studentdelete
            // 
            this.studentdelete.Location = new System.Drawing.Point(400, 463);
            this.studentdelete.Name = "studentdelete";
            this.studentdelete.Size = new System.Drawing.Size(90, 32);
            this.studentdelete.TabIndex = 20;
            this.studentdelete.Text = "DELETE";
            this.studentdelete.UseVisualStyleBackColor = true;
            this.studentdelete.Click += new System.EventHandler(this.studentdelete_Click);
            // 
            // studentedit
            // 
            this.studentedit.Location = new System.Drawing.Point(243, 463);
            this.studentedit.Name = "studentedit";
            this.studentedit.Size = new System.Drawing.Size(89, 32);
            this.studentedit.TabIndex = 19;
            this.studentedit.Text = "EDIT";
            this.studentedit.UseVisualStyleBackColor = true;
            this.studentedit.Click += new System.EventHandler(this.studentedit_Click);
            // 
            // studentadd
            // 
            this.studentadd.Location = new System.Drawing.Point(85, 463);
            this.studentadd.Name = "studentadd";
            this.studentadd.Size = new System.Drawing.Size(91, 32);
            this.studentadd.TabIndex = 18;
            this.studentadd.Text = "ADD";
            this.studentadd.UseVisualStyleBackColor = true;
            this.studentadd.Click += new System.EventHandler(this.studentadd_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.AutoSize = true;
            this.txtstudentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentid.Location = new System.Drawing.Point(42, 15);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(72, 17);
            this.txtstudentid.TabIndex = 17;
            this.txtstudentid.Text = "Student Id";
            // 
            // textstudentcontactperson
            // 
            this.textstudentcontactperson.Location = new System.Drawing.Point(158, 350);
            this.textstudentcontactperson.Multiline = true;
            this.textstudentcontactperson.Name = "textstudentcontactperson";
            this.textstudentcontactperson.Size = new System.Drawing.Size(159, 47);
            this.textstudentcontactperson.TabIndex = 16;
            // 
            // textstudentemail
            // 
            this.textstudentemail.Location = new System.Drawing.Point(158, 299);
            this.textstudentemail.Multiline = true;
            this.textstudentemail.Name = "textstudentemail";
            this.textstudentemail.Size = new System.Drawing.Size(159, 45);
            this.textstudentemail.TabIndex = 15;
            // 
            // textstudentnic
            // 
            this.textstudentnic.Location = new System.Drawing.Point(158, 249);
            this.textstudentnic.Multiline = true;
            this.textstudentnic.Name = "textstudentnic";
            this.textstudentnic.Size = new System.Drawing.Size(159, 44);
            this.textstudentnic.TabIndex = 14;
            // 
            // textstudentaddress
            // 
            this.textstudentaddress.Location = new System.Drawing.Point(158, 196);
            this.textstudentaddress.Multiline = true;
            this.textstudentaddress.Name = "textstudentaddress";
            this.textstudentaddress.Size = new System.Drawing.Size(159, 47);
            this.textstudentaddress.TabIndex = 13;
            // 
            // textstudentcontact
            // 
            this.textstudentcontact.Location = new System.Drawing.Point(158, 140);
            this.textstudentcontact.Multiline = true;
            this.textstudentcontact.Name = "textstudentcontact";
            this.textstudentcontact.Size = new System.Drawing.Size(159, 50);
            this.textstudentcontact.TabIndex = 12;
            // 
            // textstudentname
            // 
            this.textstudentname.Location = new System.Drawing.Point(158, 93);
            this.textstudentname.Multiline = true;
            this.textstudentname.Name = "textstudentname";
            this.textstudentname.Size = new System.Drawing.Size(159, 41);
            this.textstudentname.TabIndex = 11;
            this.textstudentname.TextChanged += new System.EventHandler(this.textstudentname_TextChanged);
            // 
            // textstudentcode
            // 
            this.textstudentcode.Location = new System.Drawing.Point(158, 51);
            this.textstudentcode.Multiline = true;
            this.textstudentcode.Name = "textstudentcode";
            this.textstudentcode.Size = new System.Drawing.Size(159, 36);
            this.textstudentcode.TabIndex = 10;
            this.textstudentcode.TextChanged += new System.EventHandler(this.textstudentcode_TextChanged);
            // 
            // txtstudentcontactperson
            // 
            this.txtstudentcontactperson.AutoSize = true;
            this.txtstudentcontactperson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentcontactperson.Location = new System.Drawing.Point(42, 362);
            this.txtstudentcontactperson.Name = "txtstudentcontactperson";
            this.txtstudentcontactperson.Size = new System.Drawing.Size(102, 17);
            this.txtstudentcontactperson.TabIndex = 9;
            this.txtstudentcontactperson.Text = "contact person";
            // 
            // txtstudentemail
            // 
            this.txtstudentemail.AutoSize = true;
            this.txtstudentemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentemail.Location = new System.Drawing.Point(42, 311);
            this.txtstudentemail.Name = "txtstudentemail";
            this.txtstudentemail.Size = new System.Drawing.Size(41, 17);
            this.txtstudentemail.TabIndex = 8;
            this.txtstudentemail.Text = "email";
            // 
            // txtstudentnic
            // 
            this.txtstudentnic.AutoSize = true;
            this.txtstudentnic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentnic.Location = new System.Drawing.Point(42, 254);
            this.txtstudentnic.Name = "txtstudentnic";
            this.txtstudentnic.Size = new System.Drawing.Size(26, 17);
            this.txtstudentnic.TabIndex = 7;
            this.txtstudentnic.Text = "nic";
            // 
            // txtstudentaddres
            // 
            this.txtstudentaddres.AutoSize = true;
            this.txtstudentaddres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentaddres.Location = new System.Drawing.Point(42, 201);
            this.txtstudentaddres.Name = "txtstudentaddres";
            this.txtstudentaddres.Size = new System.Drawing.Size(59, 17);
            this.txtstudentaddres.TabIndex = 6;
            this.txtstudentaddres.Text = "address";
            // 
            // txtstudentcontact
            // 
            this.txtstudentcontact.AutoSize = true;
            this.txtstudentcontact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentcontact.Location = new System.Drawing.Point(42, 140);
            this.txtstudentcontact.Name = "txtstudentcontact";
            this.txtstudentcontact.Size = new System.Drawing.Size(110, 17);
            this.txtstudentcontact.TabIndex = 5;
            this.txtstudentcontact.Text = "Contact Number";
            // 
            // txtstudentname
            // 
            this.txtstudentname.AutoSize = true;
            this.txtstudentname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentname.Location = new System.Drawing.Point(42, 93);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(98, 17);
            this.txtstudentname.TabIndex = 4;
            this.txtstudentname.Text = "Student Name";
            // 
            // txtstudentcode
            // 
            this.txtstudentcode.AutoSize = true;
            this.txtstudentcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtstudentcode.Location = new System.Drawing.Point(42, 51);
            this.txtstudentcode.Name = "txtstudentcode";
            this.txtstudentcode.Size = new System.Drawing.Size(94, 17);
            this.txtstudentcode.TabIndex = 3;
            this.txtstudentcode.Text = "Student Code";
            // 
            // gridupdatestudent
            // 
            this.gridupdatestudent.Location = new System.Drawing.Point(431, 15);
            this.gridupdatestudent.Name = "gridupdatestudent";
            this.gridupdatestudent.Size = new System.Drawing.Size(189, 30);
            this.gridupdatestudent.TabIndex = 2;
            this.gridupdatestudent.Text = "update records";
            this.gridupdatestudent.UseVisualStyleBackColor = true;
            this.gridupdatestudent.Click += new System.EventHandler(this.gridupdatestudent_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(626, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(570, 271);
            this.dataGridView2.TabIndex = 1;
            // 
            // dgvstudent
            // 
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(626, 6);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowTemplate.Height = 24;
            this.dgvstudent.Size = new System.Drawing.Size(570, 265);
            this.dgvstudent.TabIndex = 0;
            this.dgvstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.dgvcourse);
            this.tabPage2.Controls.Add(this.coursedeletebtn);
            this.tabPage2.Controls.Add(this.courseeditbtn);
            this.tabPage2.Controls.Add(this.courseaddbtn);
            this.tabPage2.Controls.Add(this.textsemesternumber);
            this.tabPage2.Controls.Add(this.textcoursecredits);
            this.tabPage2.Controls.Add(this.textcoursename);
            this.tabPage2.Controls.Add(this.textcoursecode);
            this.tabPage2.Controls.Add(this.courselblid);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1279, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "COURSE";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvcourse
            // 
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Location = new System.Drawing.Point(621, 76);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.RowTemplate.Height = 24;
            this.dgvcourse.Size = new System.Drawing.Size(508, 400);
            this.dgvcourse.TabIndex = 13;
            this.dgvcourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcourse_CellClick);
            this.dgvcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcourse_CellContentClick);
            // 
            // coursedeletebtn
            // 
            this.coursedeletebtn.Location = new System.Drawing.Point(446, 437);
            this.coursedeletebtn.Name = "coursedeletebtn";
            this.coursedeletebtn.Size = new System.Drawing.Size(75, 23);
            this.coursedeletebtn.TabIndex = 12;
            this.coursedeletebtn.Text = "DELETE";
            this.coursedeletebtn.UseVisualStyleBackColor = true;
            this.coursedeletebtn.Click += new System.EventHandler(this.coursedeletebtn_Click);
            // 
            // courseeditbtn
            // 
            this.courseeditbtn.Location = new System.Drawing.Point(260, 437);
            this.courseeditbtn.Name = "courseeditbtn";
            this.courseeditbtn.Size = new System.Drawing.Size(75, 23);
            this.courseeditbtn.TabIndex = 11;
            this.courseeditbtn.Text = "EDIT";
            this.courseeditbtn.UseVisualStyleBackColor = true;
            this.courseeditbtn.Click += new System.EventHandler(this.courseeditbtn_Click);
            // 
            // courseaddbtn
            // 
            this.courseaddbtn.Location = new System.Drawing.Point(98, 437);
            this.courseaddbtn.Name = "courseaddbtn";
            this.courseaddbtn.Size = new System.Drawing.Size(75, 23);
            this.courseaddbtn.TabIndex = 10;
            this.courseaddbtn.Text = "ADD";
            this.courseaddbtn.UseVisualStyleBackColor = true;
            this.courseaddbtn.Click += new System.EventHandler(this.courseaddbtn_Click);
            // 
            // textsemesternumber
            // 
            this.textsemesternumber.Location = new System.Drawing.Point(270, 321);
            this.textsemesternumber.Multiline = true;
            this.textsemesternumber.Name = "textsemesternumber";
            this.textsemesternumber.Size = new System.Drawing.Size(134, 47);
            this.textsemesternumber.TabIndex = 9;
            // 
            // textcoursecredits
            // 
            this.textcoursecredits.Location = new System.Drawing.Point(270, 256);
            this.textcoursecredits.Multiline = true;
            this.textcoursecredits.Name = "textcoursecredits";
            this.textcoursecredits.Size = new System.Drawing.Size(134, 43);
            this.textcoursecredits.TabIndex = 8;
            // 
            // textcoursename
            // 
            this.textcoursename.Location = new System.Drawing.Point(270, 183);
            this.textcoursename.Multiline = true;
            this.textcoursename.Name = "textcoursename";
            this.textcoursename.Size = new System.Drawing.Size(134, 43);
            this.textcoursename.TabIndex = 7;
            // 
            // textcoursecode
            // 
            this.textcoursecode.Location = new System.Drawing.Point(270, 116);
            this.textcoursecode.Multiline = true;
            this.textcoursecode.Name = "textcoursecode";
            this.textcoursecode.Size = new System.Drawing.Size(134, 39);
            this.textcoursecode.TabIndex = 6;
            // 
            // courselblid
            // 
            this.courselblid.AutoSize = true;
            this.courselblid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.courselblid.Location = new System.Drawing.Point(267, 55);
            this.courselblid.Name = "courselblid";
            this.courselblid.Size = new System.Drawing.Size(0, 17);
            this.courselblid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(83, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semester Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(83, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(83, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(83, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(83, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textenrollcoursename);
            this.tabPage3.Controls.Add(this.textenrollcourseid);
            this.tabPage3.Controls.Add(this.textenrollstudentname);
            this.tabPage3.Controls.Add(this.textenrollid);
            this.tabPage3.Controls.Add(this.dgvcourse1);
            this.tabPage3.Controls.Add(this.dgvstudent1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1279, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ENROLLMENT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "ENROLL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(840, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "course name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(840, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "course id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(840, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "student name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(840, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "student id";
            // 
            // textenrollcoursename
            // 
            this.textenrollcoursename.Location = new System.Drawing.Point(994, 360);
            this.textenrollcoursename.Multiline = true;
            this.textenrollcoursename.Name = "textenrollcoursename";
            this.textenrollcoursename.Size = new System.Drawing.Size(163, 55);
            this.textenrollcoursename.TabIndex = 5;
            // 
            // textenrollcourseid
            // 
            this.textenrollcourseid.Location = new System.Drawing.Point(994, 276);
            this.textenrollcourseid.Multiline = true;
            this.textenrollcourseid.Name = "textenrollcourseid";
            this.textenrollcourseid.Size = new System.Drawing.Size(163, 52);
            this.textenrollcourseid.TabIndex = 4;
            // 
            // textenrollstudentname
            // 
            this.textenrollstudentname.Location = new System.Drawing.Point(994, 127);
            this.textenrollstudentname.Multiline = true;
            this.textenrollstudentname.Name = "textenrollstudentname";
            this.textenrollstudentname.Size = new System.Drawing.Size(171, 59);
            this.textenrollstudentname.TabIndex = 3;
            // 
            // textenrollid
            // 
            this.textenrollid.Location = new System.Drawing.Point(994, 46);
            this.textenrollid.Multiline = true;
            this.textenrollid.Name = "textenrollid";
            this.textenrollid.Size = new System.Drawing.Size(171, 51);
            this.textenrollid.TabIndex = 2;
            // 
            // dgvcourse1
            // 
            this.dgvcourse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse1.Location = new System.Drawing.Point(63, 276);
            this.dgvcourse1.Name = "dgvcourse1";
            this.dgvcourse1.RowTemplate.Height = 24;
            this.dgvcourse1.Size = new System.Drawing.Size(669, 258);
            this.dgvcourse1.TabIndex = 1;
            this.dgvcourse1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcourse1_cellclick);
            // 
            // dgvstudent1
            // 
            this.dgvstudent1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent1.Location = new System.Drawing.Point(63, 3);
            this.dgvstudent1.Name = "dgvstudent1";
            this.dgvstudent1.RowTemplate.Height = 24;
            this.dgvstudent1.Size = new System.Drawing.Size(669, 244);
            this.dgvstudent1.TabIndex = 0;
            this.dgvstudent1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent1_cellclick);
            this.dgvstudent1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 640);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button studentdelete;
        private System.Windows.Forms.Button studentedit;
        private System.Windows.Forms.Button studentadd;
        private System.Windows.Forms.Label txtstudentid;
        private System.Windows.Forms.TextBox textstudentcontactperson;
        private System.Windows.Forms.TextBox textstudentemail;
        private System.Windows.Forms.TextBox textstudentnic;
        private System.Windows.Forms.TextBox textstudentaddress;
        private System.Windows.Forms.TextBox textstudentcontact;
        private System.Windows.Forms.TextBox textstudentname;
        private System.Windows.Forms.TextBox textstudentcode;
        private System.Windows.Forms.Label txtstudentcontactperson;
        private System.Windows.Forms.Label txtstudentemail;
        private System.Windows.Forms.Label txtstudentnic;
        private System.Windows.Forms.Label txtstudentaddres;
        private System.Windows.Forms.Label txtstudentcontact;
        private System.Windows.Forms.Label txtstudentname;
        private System.Windows.Forms.Label txtstudentcode;
        private System.Windows.Forms.Button gridupdatestudent;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button coursedeletebtn;
        private System.Windows.Forms.Button courseeditbtn;
        private System.Windows.Forms.Button courseaddbtn;
        private System.Windows.Forms.TextBox textsemesternumber;
        private System.Windows.Forms.TextBox textcoursecredits;
        private System.Windows.Forms.TextBox textcoursename;
        private System.Windows.Forms.TextBox textcoursecode;
        private System.Windows.Forms.Label courselblid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.DataGridView dgvcourse1;
        private System.Windows.Forms.DataGridView dgvstudent1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textenrollcoursename;
        private System.Windows.Forms.TextBox textenrollcourseid;
        private System.Windows.Forms.TextBox textenrollstudentname;
        private System.Windows.Forms.TextBox textenrollid;
    }
}

