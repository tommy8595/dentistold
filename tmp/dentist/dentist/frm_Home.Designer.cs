namespace dentist
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Money = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.btn_Home_Setting = new System.Windows.Forms.Button();
            this.pn_Home = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.dgv_Home_Appointment = new System.Windows.Forms.DataGridView();
            this.patidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_app_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getPatientCurrentAppDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pn_Money = new System.Windows.Forms.Panel();
            this.btn_Expense = new System.Windows.Forms.Button();
            this.btn_Income = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.fun_getPatientCurrentAppDateTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPatientCurrentAppDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pn_Menu.SuspendLayout();
            this.pn_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_Appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientCurrentAppDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pn_Money.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(2, 151);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(296, 41);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Patient
            // 
            this.btn_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient.FlatAppearance.BorderSize = 0;
            this.btn_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient.ForeColor = System.Drawing.Color.White;
            this.btn_Patient.Image = ((System.Drawing.Image)(resources.GetObject("btn_Patient.Image")));
            this.btn_Patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Patient.Location = new System.Drawing.Point(2, 202);
            this.btn_Patient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(296, 41);
            this.btn_Patient.TabIndex = 2;
            this.btn_Patient.UseVisualStyleBackColor = false;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product.Image")));
            this.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Location = new System.Drawing.Point(2, 254);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(296, 41);
            this.btn_Product.TabIndex = 3;
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Money
            // 
            this.btn_Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Money.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Money.FlatAppearance.BorderSize = 0;
            this.btn_Money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Money.ForeColor = System.Drawing.Color.White;
            this.btn_Money.Image = ((System.Drawing.Image)(resources.GetObject("btn_Money.Image")));
            this.btn_Money.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Money.Location = new System.Drawing.Point(2, 305);
            this.btn_Money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Money.Name = "btn_Money";
            this.btn_Money.Size = new System.Drawing.Size(296, 41);
            this.btn_Money.TabIndex = 4;
            this.btn_Money.UseVisualStyleBackColor = false;
            this.btn_Money.Click += new System.EventHandler(this.btn_Money_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Image = ((System.Drawing.Image)(resources.GetObject("btn_Staff.Image")));
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staff.Location = new System.Drawing.Point(2, 356);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(296, 41);
            this.btn_Staff.TabIndex = 5;
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.pictureBox1.Location = new System.Drawing.Point(9, 197);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 1);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 248);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 1);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.pictureBox3.Location = new System.Drawing.Point(9, 299);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(284, 1);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.pictureBox4.Location = new System.Drawing.Point(9, 350);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(284, 1);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.pictureBox5.Location = new System.Drawing.Point(9, 401);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(284, 1);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Report.Image")));
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Location = new System.Drawing.Point(2, 407);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(296, 41);
            this.btn_Report.TabIndex = 10;
            this.btn_Report.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(2, 2);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(296, 109);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.pn_Menu.Controls.Add(this.btn_Home_Setting);
            this.pn_Menu.Controls.Add(this.pictureBox6);
            this.pn_Menu.Controls.Add(this.btn_Report);
            this.pn_Menu.Controls.Add(this.pictureBox5);
            this.pn_Menu.Controls.Add(this.pictureBox4);
            this.pn_Menu.Controls.Add(this.pictureBox3);
            this.pn_Menu.Controls.Add(this.pictureBox2);
            this.pn_Menu.Controls.Add(this.pictureBox1);
            this.pn_Menu.Controls.Add(this.btn_Staff);
            this.pn_Menu.Controls.Add(this.btn_Money);
            this.pn_Menu.Controls.Add(this.btn_Product);
            this.pn_Menu.Controls.Add(this.btn_Patient);
            this.pn_Menu.Controls.Add(this.btn_Home);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Menu.Location = new System.Drawing.Point(0, 0);
            this.pn_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(300, 692);
            this.pn_Menu.TabIndex = 0;
            // 
            // btn_Home_Setting
            // 
            this.btn_Home_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Home_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Home_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Home_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home_Setting.Image")));
            this.btn_Home_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home_Setting.Location = new System.Drawing.Point(26, 635);
            this.btn_Home_Setting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home_Setting.Name = "btn_Home_Setting";
            this.btn_Home_Setting.Size = new System.Drawing.Size(245, 41);
            this.btn_Home_Setting.TabIndex = 11;
            this.btn_Home_Setting.UseVisualStyleBackColor = false;
            this.btn_Home_Setting.Click += new System.EventHandler(this.btn_Home_Setting_Click);
            // 
            // pn_Home
            // 
            this.pn_Home.BackColor = System.Drawing.Color.White;
            this.pn_Home.Controls.Add(this.label1);
            this.pn_Home.Controls.Add(this.btnEditPatient);
            this.pn_Home.Controls.Add(this.label32);
            this.pn_Home.Controls.Add(this.dgv_Home_Appointment);
            this.pn_Home.Controls.Add(this.panel2);
            this.pn_Home.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Home.Location = new System.Drawing.Point(300, 0);
            this.pn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Home.Name = "pn_Home";
            this.pn_Home.Size = new System.Drawing.Size(886, 693);
            this.pn_Home.TabIndex = 2;
            this.pn_Home.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Home_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 89;
            this.label1.Text = "label1";
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnEditPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPatient.FlatAppearance.BorderSize = 0;
            this.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.ForeColor = System.Drawing.Color.White;
            this.btnEditPatient.Location = new System.Drawing.Point(664, 177);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(179, 32);
            this.btnEditPatient.TabIndex = 88;
            this.btnEditPatient.Text = "ពត៌មានលំអិត";
            this.btnEditPatient.UseVisualStyleBackColor = false;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(42, 177);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 27);
            this.label32.TabIndex = 36;
            this.label32.Text = "ការណាត់ជួប";
            // 
            // dgv_Home_Appointment
            // 
            this.dgv_Home_Appointment.AllowUserToAddRows = false;
            this.dgv_Home_Appointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgv_Home_Appointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Home_Appointment.AutoGenerateColumns = false;
            this.dgv_Home_Appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Home_Appointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.dgv_Home_Appointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Home_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home_Appointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patidDataGridViewTextBoxColumn,
            this.pat_app_time,
            this.fullnameKhDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.pattelDataGridViewTextBoxColumn});
            this.dgv_Home_Appointment.DataSource = this.fun_getPatientCurrentAppDateBindingSource;
            this.dgv_Home_Appointment.Location = new System.Drawing.Point(47, 213);
            this.dgv_Home_Appointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Home_Appointment.MultiSelect = false;
            this.dgv_Home_Appointment.Name = "dgv_Home_Appointment";
            this.dgv_Home_Appointment.ReadOnly = true;
            this.dgv_Home_Appointment.RowHeadersWidth = 51;
            this.dgv_Home_Appointment.RowTemplate.Height = 30;
            this.dgv_Home_Appointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Home_Appointment.Size = new System.Drawing.Size(796, 463);
            this.dgv_Home_Appointment.TabIndex = 26;
            // 
            // patidDataGridViewTextBoxColumn
            // 
            this.patidDataGridViewTextBoxColumn.DataPropertyName = "pat_id";
            this.patidDataGridViewTextBoxColumn.FillWeight = 30F;
            this.patidDataGridViewTextBoxColumn.HeaderText = "ល.ស";
            this.patidDataGridViewTextBoxColumn.Name = "patidDataGridViewTextBoxColumn";
            this.patidDataGridViewTextBoxColumn.ReadOnly = true;
            this.patidDataGridViewTextBoxColumn.Visible = false;
            // 
            // pat_app_time
            // 
            this.pat_app_time.DataPropertyName = "pat_app_time";
            this.pat_app_time.FillWeight = 50F;
            this.pat_app_time.HeaderText = "ម៉ោងណាត់ជួប";
            this.pat_app_time.Name = "pat_app_time";
            this.pat_app_time.ReadOnly = true;
            // 
            // fullnameKhDataGridViewTextBoxColumn
            // 
            this.fullnameKhDataGridViewTextBoxColumn.DataPropertyName = "fullnameKh";
            this.fullnameKhDataGridViewTextBoxColumn.FillWeight = 80F;
            this.fullnameKhDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះ(ខ្មែរ)";
            this.fullnameKhDataGridViewTextBoxColumn.Name = "fullnameKhDataGridViewTextBoxColumn";
            this.fullnameKhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.FillWeight = 80F;
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pattelDataGridViewTextBoxColumn
            // 
            this.pattelDataGridViewTextBoxColumn.DataPropertyName = "pat_tel";
            this.pattelDataGridViewTextBoxColumn.HeaderText = "ល.ទូរស័ព្ទ";
            this.pattelDataGridViewTextBoxColumn.Name = "pattelDataGridViewTextBoxColumn";
            this.pattelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fun_getPatientCurrentAppDateBindingSource
            // 
            this.fun_getPatientCurrentAppDateBindingSource.DataMember = "fun_getPatientCurrentAppDate";
            this.fun_getPatientCurrentAppDateBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 111);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(4, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 106);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pn_Money
            // 
            this.pn_Money.BackColor = System.Drawing.Color.White;
            this.pn_Money.Controls.Add(this.btn_Expense);
            this.pn_Money.Controls.Add(this.btn_Income);
            this.pn_Money.Controls.Add(this.panel4);
            this.pn_Money.Location = new System.Drawing.Point(300, 0);
            this.pn_Money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Money.Name = "pn_Money";
            this.pn_Money.Size = new System.Drawing.Size(886, 693);
            this.pn_Money.TabIndex = 3;
            // 
            // btn_Expense
            // 
            this.btn_Expense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Expense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense.FlatAppearance.BorderSize = 0;
            this.btn_Expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense.ForeColor = System.Drawing.Color.White;
            this.btn_Expense.Location = new System.Drawing.Point(445, 134);
            this.btn_Expense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Expense.Name = "btn_Expense";
            this.btn_Expense.Size = new System.Drawing.Size(382, 536);
            this.btn_Expense.TabIndex = 5;
            this.btn_Expense.Text = "ប្រាក់ចំណាយ";
            this.btn_Expense.UseVisualStyleBackColor = false;
            this.btn_Expense.Click += new System.EventHandler(this.btn_Expense_Click);
            // 
            // btn_Income
            // 
            this.btn_Income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Income.FlatAppearance.BorderSize = 0;
            this.btn_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Income.ForeColor = System.Drawing.Color.White;
            this.btn_Income.Location = new System.Drawing.Point(31, 134);
            this.btn_Income.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Income.Name = "btn_Income";
            this.btn_Income.Size = new System.Drawing.Size(382, 536);
            this.btn_Income.TabIndex = 4;
            this.btn_Income.Text = "ប្រាក់ចំណូល";
            this.btn_Income.UseVisualStyleBackColor = false;
            this.btn_Income.Click += new System.EventHandler(this.btn_Income_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(886, 111);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(4, 2);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(120, 106);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // fun_getPatientCurrentAppDateTableAdapter
            // 
            this.fun_getPatientCurrentAppDateTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 692);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.pn_Home);
            this.Controls.Add(this.pn_Money);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Activated += new System.EventHandler(this.frm_Home_Activated);
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pn_Menu.ResumeLayout(false);
            this.pn_Home.ResumeLayout(false);
            this.pn_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home_Appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientCurrentAppDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pn_Money.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Money;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Panel pn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel pn_Money;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Home_Setting;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgv_Home_Appointment;
        private System.Windows.Forms.Button btn_Expense;
        private System.Windows.Forms.Button btn_Income;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fun_getPatientCurrentAppDateBindingSource;
        private Dentist_DSTableAdapters.fun_getPatientCurrentAppDateTableAdapter fun_getPatientCurrentAppDateTableAdapter;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn patidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_app_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}