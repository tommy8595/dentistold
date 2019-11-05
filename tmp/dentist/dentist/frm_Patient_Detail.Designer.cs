namespace dentist
{
    partial class frm_Patient_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Patient_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_Pat_Det_Cancel = new System.Windows.Forms.Button();
            this.btn_Reg_Pat_Save = new System.Windows.Forms.Button();
            this.btn_Pat_Det_Edit = new System.Windows.Forms.Button();
            this.txtRandomNumber = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Reg_Job = new System.Windows.Forms.TextBox();
            this.fun_getPatientByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Reg_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Reg_Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKhLname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKhFname = new System.Windows.Forms.TextBox();
            this.txtAppoint = new System.Windows.Forms.TextBox();
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView = new System.Windows.Forms.DataGridView();
            this.mdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mddescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fun_getPatientImageByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowPic = new System.Windows.Forms.Button();
            this.fun_getPatientByIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPatientByIDTableAdapter();
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter();
            this.fun_getPatientImageByIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPatientImageByIDTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientImageByIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1593, 108);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(3, 5);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // btn_Pat_Det_Cancel
            // 
            this.btn_Pat_Det_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Pat_Det_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pat_Det_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Pat_Det_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pat_Det_Cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pat_Det_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Pat_Det_Cancel.Location = new System.Drawing.Point(1251, 778);
            this.btn_Pat_Det_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pat_Det_Cancel.Name = "btn_Pat_Det_Cancel";
            this.btn_Pat_Det_Cancel.Size = new System.Drawing.Size(316, 50);
            this.btn_Pat_Det_Cancel.TabIndex = 86;
            this.btn_Pat_Det_Cancel.Text = "រួចរាល់";
            this.btn_Pat_Det_Cancel.UseVisualStyleBackColor = false;
            this.btn_Pat_Det_Cancel.Click += new System.EventHandler(this.btn_Pat_Det_Cancel_Click);
            // 
            // btn_Reg_Pat_Save
            // 
            this.btn_Reg_Pat_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Reg_Pat_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Save.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Save.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Save.Location = new System.Drawing.Point(37, 778);
            this.btn_Reg_Pat_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reg_Pat_Save.Name = "btn_Reg_Pat_Save";
            this.btn_Reg_Pat_Save.Size = new System.Drawing.Size(467, 50);
            this.btn_Reg_Pat_Save.TabIndex = 85;
            this.btn_Reg_Pat_Save.Text = "បង្កើតលេខកូដសម្រាប់ព្យាបាល";
            this.btn_Reg_Pat_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reg_Pat_Save.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Save.Click += new System.EventHandler(this.btn_Reg_Pat_Save_Click);
            // 
            // btn_Pat_Det_Edit
            // 
            this.btn_Pat_Det_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Pat_Det_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pat_Det_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Pat_Det_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pat_Det_Edit.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pat_Det_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Pat_Det_Edit.Location = new System.Drawing.Point(37, 713);
            this.btn_Pat_Det_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pat_Det_Edit.Name = "btn_Pat_Det_Edit";
            this.btn_Pat_Det_Edit.Size = new System.Drawing.Size(1529, 50);
            this.btn_Pat_Det_Edit.TabIndex = 90;
            this.btn_Pat_Det_Edit.Text = "កែប្រែព័ត៌មានរបស់អ្នកជម្ងឺ";
            this.btn_Pat_Det_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pat_Det_Edit.UseVisualStyleBackColor = false;
            this.btn_Pat_Det_Edit.Click += new System.EventHandler(this.btn_Pat_Det_Edit_Click);
            // 
            // txtRandomNumber
            // 
            this.txtRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandomNumber.Location = new System.Drawing.Point(520, 781);
            this.txtRandomNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRandomNumber.Name = "txtRandomNumber";
            this.txtRandomNumber.Size = new System.Drawing.Size(212, 44);
            this.txtRandomNumber.TabIndex = 91;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1435, 113);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(131, 30);
            this.txtId.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1295, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 62;
            this.label1.Text = "លេខសម្គាល់";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 67;
            this.label4.Text = "ឆ្នាំកំណើត";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 36);
            this.label5.TabIndex = 69;
            this.label5.Text = "ភេទ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 36);
            this.label6.TabIndex = 71;
            this.label6.Text = "មុខរបរ";
            // 
            // txt_Reg_Job
            // 
            this.txt_Reg_Job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_job", true));
            this.txt_Reg_Job.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Job.Location = new System.Drawing.Point(732, 288);
            this.txt_Reg_Job.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Reg_Job.Name = "txt_Reg_Job";
            this.txt_Reg_Job.ReadOnly = true;
            this.txt_Reg_Job.Size = new System.Drawing.Size(556, 43);
            this.txt_Reg_Job.TabIndex = 72;
            // 
            // fun_getPatientByIDBindingSource
            // 
            this.fun_getPatientByIDBindingSource.DataMember = "fun_getPatientByID";
            this.fun_getPatientByIDBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 36);
            this.label7.TabIndex = 73;
            this.label7.Text = "សញ្ជាតិ";
            // 
            // txt_Reg_Address
            // 
            this.txt_Reg_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_address", true));
            this.txt_Reg_Address.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Address.Location = new System.Drawing.Point(732, 346);
            this.txt_Reg_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Reg_Address.Name = "txt_Reg_Address";
            this.txt_Reg_Address.ReadOnly = true;
            this.txt_Reg_Address.Size = new System.Drawing.Size(556, 43);
            this.txt_Reg_Address.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 36);
            this.label8.TabIndex = 75;
            this.label8.Text = "អាស័យដ្ឋាន/កន្លែងធ្វើការ";
            // 
            // txt_Reg_Phone
            // 
            this.txt_Reg_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_tel", true));
            this.txt_Reg_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Phone.Location = new System.Drawing.Point(179, 292);
            this.txt_Reg_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Reg_Phone.Name = "txt_Reg_Phone";
            this.txt_Reg_Phone.ReadOnly = true;
            this.txt_Reg_Phone.Size = new System.Drawing.Size(463, 30);
            this.txt_Reg_Phone.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 36);
            this.label9.TabIndex = 77;
            this.label9.Text = "លេខទូរស័ព្ទ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(951, 235);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 36);
            this.label20.TabIndex = 79;
            this.label20.Text = "ការណាត់ជួប";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_nation", true));
            this.textBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(179, 345);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(256, 43);
            this.textBox2.TabIndex = 81;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(19, 548);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(139, 36);
            this.label30.TabIndex = 84;
            this.label30.Text = "ប្រវត្តិវេជ្ជសាស្រ្ត";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_birthyear", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(732, 238);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(212, 30);
            this.textBox3.TabIndex = 88;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_gender", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(179, 236);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(323, 30);
            this.textBox4.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(543, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 36);
            this.label12.TabIndex = 99;
            this.label12.Text = "ឈ្មោះ(ឡាតាំង)";
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_lname", true));
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(732, 191);
            this.txtLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(556, 30);
            this.txtLname.TabIndex = 95;
            this.txtLname.Tag = "សូមបញ្ចូលឈ្មោះ(ឡាតាំង)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 36);
            this.label13.TabIndex = 98;
            this.label13.Text = "ត្រកូល(ឡាតាំង)";
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_fname", true));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(179, 188);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(323, 30);
            this.txtFname.TabIndex = 94;
            this.txtFname.Tag = "សូមបញ្ចូលត្រកូល(ឡាតាំង)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(543, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 36);
            this.label10.TabIndex = 97;
            this.label10.Text = "ឈ្មោះ(ខ្មែរ)";
            // 
            // txtKhLname
            // 
            this.txtKhLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_kh_lname", true));
            this.txtKhLname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhLname.Location = new System.Drawing.Point(732, 133);
            this.txtKhLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhLname.Name = "txtKhLname";
            this.txtKhLname.ReadOnly = true;
            this.txtKhLname.Size = new System.Drawing.Size(556, 39);
            this.txtKhLname.TabIndex = 93;
            this.txtKhLname.Tag = "សូមបញ្ចូលឈ្មោះ(ខ្មែរ)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 36);
            this.label11.TabIndex = 96;
            this.label11.Text = "ត្រកូល(ខ្មែរ)";
            // 
            // txtKhFname
            // 
            this.txtKhFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_kh_fname", true));
            this.txtKhFname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhFname.Location = new System.Drawing.Point(179, 130);
            this.txtKhFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhFname.Name = "txtKhFname";
            this.txtKhFname.ReadOnly = true;
            this.txtKhFname.Size = new System.Drawing.Size(323, 39);
            this.txtKhFname.TabIndex = 92;
            this.txtKhFname.Tag = "សូមបញ្ចូលត្រកូល(ខ្មែរ)";
            // 
            // txtAppoint
            // 
            this.txtAppoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_app_date", true));
            this.txtAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppoint.Location = new System.Drawing.Point(1076, 236);
            this.txtAppoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAppoint.Name = "txtAppoint";
            this.txtAppoint.ReadOnly = true;
            this.txtAppoint.Size = new System.Drawing.Size(212, 30);
            this.txtAppoint.TabIndex = 100;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientDataGridView
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AllowUserToAddRows = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AllowUserToDeleteRows = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AutoGenerateColumns = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdnameDataGridViewTextBoxColumn,
            this.mddescriptionDataGridViewTextBoxColumn,
            this.md_status});
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.DataSource = this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Location = new System.Drawing.Point(179, 414);
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.MultiSelect = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Name = "fun_getActiveMedicalHistoryForSpecificPaientDataGridView";
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.ReadOnly = true;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.RowTemplate.Height = 30;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Size = new System.Drawing.Size(1388, 271);
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.TabIndex = 101;
            // 
            // mdnameDataGridViewTextBoxColumn
            // 
            this.mdnameDataGridViewTextBoxColumn.DataPropertyName = "md_name";
            this.mdnameDataGridViewTextBoxColumn.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្ត";
            this.mdnameDataGridViewTextBoxColumn.Name = "mdnameDataGridViewTextBoxColumn";
            this.mdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mddescriptionDataGridViewTextBoxColumn
            // 
            this.mddescriptionDataGridViewTextBoxColumn.DataPropertyName = "md_description";
            this.mddescriptionDataGridViewTextBoxColumn.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្តលម្អិត";
            this.mddescriptionDataGridViewTextBoxColumn.Name = "mddescriptionDataGridViewTextBoxColumn";
            this.mddescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // md_status
            // 
            this.md_status.DataPropertyName = "md_status";
            this.md_status.FillWeight = 40F;
            this.md_status.HeaderText = "ស្ថានភាព";
            this.md_status.Name = "md_status";
            this.md_status.ReadOnly = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientBindingSource
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataMember = "fun_getActiveMedicalHistoryForSpecificPaient";
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataSource = this.dentist_DS;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fun_getPatientImageByIDBindingSource, "pat_image", true));
            this.pictureBox1.Location = new System.Drawing.Point(1357, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // fun_getPatientImageByIDBindingSource
            // 
            this.fun_getPatientImageByIDBindingSource.DataMember = "fun_getPatientImageByID";
            this.fun_getPatientImageByIDBindingSource.DataSource = this.dentist_DS;
            // 
            // btnShowPic
            // 
            this.btnShowPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnShowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPic.FlatAppearance.BorderSize = 0;
            this.btnShowPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPic.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPic.ForeColor = System.Drawing.Color.White;
            this.btnShowPic.Location = new System.Drawing.Point(1383, 351);
            this.btnShowPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(116, 50);
            this.btnShowPic.TabIndex = 103;
            this.btnShowPic.Text = "បង្ហាញរូប";
            this.btnShowPic.UseVisualStyleBackColor = false;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // fun_getPatientByIDTableAdapter
            // 
            this.fun_getPatientByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientTableAdapter
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getPatientImageByIDTableAdapter
            // 
            this.fun_getPatientImageByIDTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Patient_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 853);
            this.Controls.Add(this.btnShowPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView);
            this.Controls.Add(this.txtAppoint);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKhLname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKhFname);
            this.Controls.Add(this.txtRandomNumber);
            this.Controls.Add(this.btn_Pat_Det_Edit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_Pat_Det_Cancel);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Reg_Phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Reg_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Reg_Job);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btn_Reg_Pat_Save);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Patient_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Load += new System.EventHandler(this.frm_Patient_Detail_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientImageByIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Pat_Det_Cancel;
        private System.Windows.Forms.Button btn_Reg_Pat_Save;
        private System.Windows.Forms.Button btn_Pat_Det_Edit;
        private System.Windows.Forms.TextBox txtRandomNumber;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fun_getPatientByIDBindingSource;
        private Dentist_DSTableAdapters.fun_getPatientByIDTableAdapter fun_getPatientByIDTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Reg_Job;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Reg_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Reg_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKhLname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKhFname;
        private System.Windows.Forms.TextBox txtAppoint;
        private System.Windows.Forms.BindingSource fun_getActiveMedicalHistoryForSpecificPaientBindingSource;
        private Dentist_DSTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter fun_getActiveMedicalHistoryForSpecificPaientTableAdapter;
        private System.Windows.Forms.DataGridView fun_getActiveMedicalHistoryForSpecificPaientDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.BindingSource fun_getPatientImageByIDBindingSource;
        private Dentist_DSTableAdapters.fun_getPatientImageByIDTableAdapter fun_getPatientImageByIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mddescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_status;
    }
}