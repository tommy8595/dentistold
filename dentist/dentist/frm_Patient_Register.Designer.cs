namespace dentist
{
    partial class frm_Patient_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Patient_Register));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dtpAppoint = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNati = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_Reg_Pat_Cancel = new System.Windows.Forms.Button();
            this.btn_Reg_Pat_Save = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.cboMd = new System.Windows.Forms.ComboBox();
            this.fungetAllMedicalHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMd = new System.Windows.Forms.DataGridView();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getAllMedicalHistoryTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getAllMedicalHistoryTableAdapter();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedicalHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 88);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(2, 4);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 81);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // dtpAppoint
            // 
            this.dtpAppoint.CustomFormat = "dd/MM/yyyy";
            this.dtpAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppoint.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppoint.Location = new System.Drawing.Point(142, 296);
            this.dtpAppoint.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAppoint.Name = "dtpAppoint";
            this.dtpAppoint.Size = new System.Drawing.Size(121, 26);
            this.dtpAppoint.TabIndex = 10;
            this.dtpAppoint.Tag = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(34, 296);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 29);
            this.label20.TabIndex = 52;
            this.label20.Text = "ការណាត់ជួប";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "លេខទូរស័ព្ទ";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(557, 291);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(418, 29);
            this.txtTel.TabIndex = 11;
            this.txtTel.Tag = "សូមបញ្ចូលលេខទូរស័ព្ទ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "អាស័យដ្ឋាន/កន្លែងធ្វើការ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(420, 203);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(555, 33);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Tag = "";
            this.txtAddress.Text = "មិនមានពត៌មាន";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "សញ្ជាតិ";
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(142, 248);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(435, 33);
            this.txtJob.TabIndex = 7;
            this.txtJob.Tag = "";
            this.txtJob.Text = "មិនមានពត៌មាន";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "មុខរបរ";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboGender.Location = new System.Drawing.Point(894, 105);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(85, 33);
            this.cboGender.TabIndex = 2;
            this.cboGender.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "ភេទ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "ឈ្មោះ(ខ្មែរ)";
            // 
            // txtKhLname
            // 
            this.txtKhLname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhLname.Location = new System.Drawing.Point(557, 105);
            this.txtKhLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhLname.Name = "txtKhLname";
            this.txtKhLname.Size = new System.Drawing.Size(289, 33);
            this.txtKhLname.TabIndex = 1;
            this.txtKhLname.Tag = "សូមបញ្ចូលឈ្មោះ(ខ្មែរ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "ត្រកូល(ខ្មែរ)";
            // 
            // txtKhFname
            // 
            this.txtKhFname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhFname.Location = new System.Drawing.Point(142, 103);
            this.txtKhFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhFname.Name = "txtKhFname";
            this.txtKhFname.Size = new System.Drawing.Size(243, 33);
            this.txtKhFname.TabIndex = 0;
            this.txtKhFname.Tag = "សូមបញ្ចូលត្រកូល(ខ្មែរ)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(994, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "លេខសម្គាល់";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(1095, 103);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(71, 26);
            this.txtId.TabIndex = 33;
            // 
            // txtNati
            // 
            this.txtNati.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNati.Location = new System.Drawing.Point(658, 247);
            this.txtNati.Margin = new System.Windows.Forms.Padding(2);
            this.txtNati.Name = "txtNati";
            this.txtNati.Size = new System.Drawing.Size(317, 36);
            this.txtNati.TabIndex = 8;
            this.txtNati.Tag = "សូមបញ្ចូលសញ្ជាតិ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(34, 463);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 58);
            this.label30.TabIndex = 57;
            this.label30.Text = "តារាងប្រវត្តិ\r\nវេជ្ជសាស្រ្ត";
            // 
            // btn_Reg_Pat_Cancel
            // 
            this.btn_Reg_Pat_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Reg_Pat_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Cancel.Location = new System.Drawing.Point(937, 641);
            this.btn_Reg_Pat_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reg_Pat_Cancel.Name = "btn_Reg_Pat_Cancel";
            this.btn_Reg_Pat_Cancel.Size = new System.Drawing.Size(187, 41);
            this.btn_Reg_Pat_Cancel.TabIndex = 59;
            this.btn_Reg_Pat_Cancel.Text = "បោះបង់";
            this.btn_Reg_Pat_Cancel.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Cancel.Click += new System.EventHandler(this.btn_Reg_Pat_Cancel_Click);
            // 
            // btn_Reg_Pat_Save
            // 
            this.btn_Reg_Pat_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Reg_Pat_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Save.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Save.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Save.Location = new System.Drawing.Point(735, 641);
            this.btn_Reg_Pat_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reg_Pat_Save.Name = "btn_Reg_Pat_Save";
            this.btn_Reg_Pat_Save.Size = new System.Drawing.Size(187, 41);
            this.btn_Reg_Pat_Save.TabIndex = 14;
            this.btn_Reg_Pat_Save.Text = "រក្សាទុក";
            this.btn_Reg_Pat_Save.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Save.Click += new System.EventHandler(this.btn_Reg_Pat_Save_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(989, 363);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "បន្ថែម";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(989, 285);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(76, 28);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(1013, 135);
            this.pb.Margin = new System.Windows.Forms.Padding(2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(111, 146);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 62;
            this.pb.TabStop = false;
            // 
            // cboMd
            // 
            this.cboMd.DataSource = this.fungetAllMedicalHistoryBindingSource;
            this.cboMd.DisplayMember = "md_name";
            this.cboMd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMd.FormattingEnabled = true;
            this.cboMd.Location = new System.Drawing.Point(142, 345);
            this.cboMd.Margin = new System.Windows.Forms.Padding(2);
            this.cboMd.Name = "cboMd";
            this.cboMd.Size = new System.Drawing.Size(833, 33);
            this.cboMd.TabIndex = 12;
            this.cboMd.Tag = "";
            this.cboMd.ValueMember = "md_id";
            // 
            // fungetAllMedicalHistoryBindingSource
            // 
            this.fungetAllMedicalHistoryBindingSource.DataMember = "fun_getAllMedicalHistory";
            this.fungetAllMedicalHistoryBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(142, 386);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(833, 33);
            this.txtDes.TabIndex = 13;
            this.txtDes.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 65;
            this.label10.Text = "បរិយាយ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 345);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 66;
            this.label11.Text = "ប្រវត្តិវេជ្ជសាស្ត្រ";
            // 
            // dgvMd
            // 
            this.dgvMd.AllowUserToAddRows = false;
            this.dgvMd.AllowUserToDeleteRows = false;
            this.dgvMd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.md_id,
            this.md_name,
            this.md_description,
            this.md_status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMd.Location = new System.Drawing.Point(142, 426);
            this.dgvMd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMd.Name = "dgvMd";
            this.dgvMd.ReadOnly = true;
            this.dgvMd.RowTemplate.Height = 30;
            this.dgvMd.Size = new System.Drawing.Size(982, 211);
            this.dgvMd.TabIndex = 67;
            // 
            // pat_id
            // 
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Visible = false;
            // 
            // md_id
            // 
            this.md_id.HeaderText = "md_id";
            this.md_id.Name = "md_id";
            this.md_id.ReadOnly = true;
            this.md_id.Visible = false;
            // 
            // md_name
            // 
            this.md_name.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្ត";
            this.md_name.Name = "md_name";
            this.md_name.ReadOnly = true;
            // 
            // md_description
            // 
            this.md_description.HeaderText = "ប្រវត្តិវេជ្ជសាស្ត្រលំអិត";
            this.md_description.Name = "md_description";
            this.md_description.ReadOnly = true;
            // 
            // md_status
            // 
            this.md_status.HeaderText = "md_status";
            this.md_status.Name = "md_status";
            this.md_status.ReadOnly = true;
            this.md_status.Visible = false;
            // 
            // fun_getAllMedicalHistoryTableAdapter
            // 
            this.fun_getAllMedicalHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // nudDob
            // 
            this.nudDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDob.Location = new System.Drawing.Point(142, 203);
            this.nudDob.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudDob.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(86, 29);
            this.nudDob.TabIndex = 5;
            this.nudDob.Tag = "";
            this.nudDob.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(415, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 72;
            this.label12.Text = "ឈ្មោះ(ឡាតាំង)";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(557, 152);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(418, 26);
            this.txtLname.TabIndex = 4;
            this.txtLname.Tag = "សូមបញ្ចូលឈ្មោះ(ឡាតាំង)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 29);
            this.label13.TabIndex = 70;
            this.label13.Text = "ត្រកូល(ឡាតាំង)";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(142, 150);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(243, 26);
            this.txtFname.TabIndex = 3;
            this.txtFname.Tag = "សូមបញ្ចូលត្រកូល(ឡាតាំង)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(271, 294);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 29);
            this.label14.TabIndex = 74;
            this.label14.Text = "ម៉ោង";
            // 
            // nudHour
            // 
            this.nudHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHour.Location = new System.Drawing.Point(317, 293);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(44, 29);
            this.nudHour.TabIndex = 75;
            this.nudHour.Tag = "";
            // 
            // nudMinute
            // 
            this.nudMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinute.Location = new System.Drawing.Point(412, 292);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(44, 29);
            this.nudMinute.TabIndex = 77;
            this.nudMinute.Tag = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(366, 293);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 29);
            this.label15.TabIndex = 76;
            this.label15.Text = "នាទី";
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.Location = new System.Drawing.Point(1069, 285);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(76, 28);
            this.btnRotate.TabIndex = 78;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // frm_Patient_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.dgvMd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cboMd);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Reg_Pat_Cancel);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtNati);
            this.Controls.Add(this.dtpAppoint);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhLname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKhFname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Reg_Pat_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_Patient_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Load += new System.EventHandler(this.frm_Patient_Register_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedicalHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DateTimePicker dtpAppoint;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNati;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_Reg_Pat_Cancel;
        private System.Windows.Forms.Button btn_Reg_Pat_Save;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ComboBox cboMd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMd;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fungetAllMedicalHistoryBindingSource;
        private Dentist_DSTableAdapters.fun_getAllMedicalHistoryTableAdapter fun_getAllMedicalHistoryTableAdapter;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_status;
        private System.Windows.Forms.Button btnRotate;
    }
}