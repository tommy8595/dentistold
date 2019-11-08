namespace dentist
{
    partial class frm_Patient_Detail_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Patient_Detail_Edit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.fun_getPatientByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.dgvMd = new System.Windows.Forms.DataGridView();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.cboMd = new System.Windows.Forms.ComboBox();
            this.fun_getMedicalHistoryForSpecificPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pb = new System.Windows.Forms.PictureBox();
            this.fun_getPatientImageByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_Reg_Pat_Cancel = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.txtNati = new System.Windows.Forms.TextBox();
            this.dtpAppoint = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhFname = new System.Windows.Forms.TextBox();
            this.btn_Reg_Pat_Save = new System.Windows.Forms.Button();
            this.fun_getPatientByIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPatientByIDTableAdapter();
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter();
            this.fun_getMedicalHistoryForSpecificPatientTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getMedicalHistoryForSpecificPatientTableAdapter();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnInactive = new System.Windows.Forms.Button();
            this.fun_getPatientImageByIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPatientImageByIDTableAdapter();
            this.tableAdapterManager = new dentist.Dentist_DSTableAdapters.TableAdapterManager();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getMedicalHistoryForSpecificPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientImageByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(1564, 108);
            this.panel4.TabIndex = 4;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(556, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 36);
            this.label12.TabIndex = 107;
            this.label12.Text = "ឈ្មោះ(ឡាតាំង)";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(1463, 127);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(93, 30);
            this.txtId.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1328, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 89;
            this.label1.Text = "លេខសម្គាល់";
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_lname", true));
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(745, 187);
            this.txtLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(556, 30);
            this.txtLname.TabIndex = 77;
            this.txtLname.Tag = "សូមបញ្ចូលឈ្មោះ(ឡាតាំង)";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 36);
            this.label13.TabIndex = 106;
            this.label13.Text = "ត្រកូល(ឡាតាំង)";
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_fname", true));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(192, 185);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(323, 30);
            this.txtFname.TabIndex = 76;
            this.txtFname.Tag = "សូមបញ្ចូលត្រកូល(ឡាតាំង)";
            // 
            // nudDob
            // 
            this.nudDob.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fun_getPatientByIDBindingSource, "pat_birthyear", true));
            this.nudDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDob.Location = new System.Drawing.Point(192, 250);
            this.nudDob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nudDob.Size = new System.Drawing.Size(115, 34);
            this.nudDob.TabIndex = 78;
            this.nudDob.Tag = "";
            this.nudDob.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
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
            this.dgvMd.Location = new System.Drawing.Point(192, 524);
            this.dgvMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMd.MultiSelect = false;
            this.dgvMd.Name = "dgvMd";
            this.dgvMd.ReadOnly = true;
            this.dgvMd.RowTemplate.Height = 30;
            this.dgvMd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMd.Size = new System.Drawing.Size(1309, 260);
            this.dgvMd.TabIndex = 105;
            this.dgvMd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMd_CellDoubleClick);
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
            this.md_description.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្តលំអិត";
            this.md_description.Name = "md_description";
            this.md_description.ReadOnly = true;
            // 
            // md_status
            // 
            this.md_status.FillWeight = 30F;
            this.md_status.HeaderText = "ស្ថានភាព";
            this.md_status.Name = "md_status";
            this.md_status.ReadOnly = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientBindingSource
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataMember = "fun_getActiveMedicalHistoryForSpecificPaient";
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataSource = this.dentist_DS;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 36);
            this.label11.TabIndex = 104;
            this.label11.Text = "ប្រវត្តិវេជ្ជសាស្ត្រ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 36);
            this.label10.TabIndex = 103;
            this.label10.Text = "បរិយាយ";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(192, 475);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(1109, 39);
            this.txtDes.TabIndex = 86;
            this.txtDes.Tag = "";
            // 
            // cboMd
            // 
            this.cboMd.DataSource = this.fun_getMedicalHistoryForSpecificPatientBindingSource;
            this.cboMd.DisplayMember = "md_name";
            this.cboMd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMd.FormattingEnabled = true;
            this.cboMd.Location = new System.Drawing.Point(192, 425);
            this.cboMd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMd.Name = "cboMd";
            this.cboMd.Size = new System.Drawing.Size(1109, 39);
            this.cboMd.TabIndex = 85;
            this.cboMd.Tag = "";
            this.cboMd.ValueMember = "md_id";
            // 
            // fun_getMedicalHistoryForSpecificPatientBindingSource
            // 
            this.fun_getMedicalHistoryForSpecificPatientBindingSource.DataMember = "fun_getMedicalHistoryForSpecificPatient";
            this.fun_getMedicalHistoryForSpecificPatientBindingSource.DataSource = this.dentist_DS;
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fun_getPatientImageByIDBindingSource, "pat_image", true));
            this.pb.Location = new System.Drawing.Point(1353, 166);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(147, 179);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 102;
            this.pb.TabStop = false;
            // 
            // fun_getPatientImageByIDBindingSource
            // 
            this.fun_getPatientImageByIDBindingSource.DataMember = "fun_getPatientImageByID";
            this.fun_getPatientImageByIDBindingSource.DataSource = this.dentist_DS;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(1379, 401);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 34);
            this.btnBrowse.TabIndex = 82;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1308, 448);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 42);
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "បន្ថែម";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_Reg_Pat_Cancel
            // 
            this.btn_Reg_Pat_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Reg_Pat_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Cancel.Location = new System.Drawing.Point(1252, 789);
            this.btn_Reg_Pat_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reg_Pat_Cancel.Name = "btn_Reg_Pat_Cancel";
            this.btn_Reg_Pat_Cancel.Size = new System.Drawing.Size(249, 50);
            this.btn_Reg_Pat_Cancel.TabIndex = 100;
            this.btn_Reg_Pat_Cancel.Text = "បោះបង់";
            this.btn_Reg_Pat_Cancel.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Cancel.Click += new System.EventHandler(this.btn_Reg_Pat_Cancel_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(67, 537);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(105, 72);
            this.label30.TabIndex = 99;
            this.label30.Text = "តារាងប្រវត្តិ\r\nវេជ្ជសាស្រ្ត";
            // 
            // txtNati
            // 
            this.txtNati.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_nation", true));
            this.txtNati.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNati.Location = new System.Drawing.Point(880, 304);
            this.txtNati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNati.Name = "txtNati";
            this.txtNati.Size = new System.Drawing.Size(421, 43);
            this.txtNati.TabIndex = 81;
            this.txtNati.Tag = "សូមបញ្ចូលសញ្ជាតិ";
            // 
            // dtpAppoint
            // 
            this.dtpAppoint.CustomFormat = "dd/MM/yyyy";
            this.dtpAppoint.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fun_getPatientByIDBindingSource, "pat_app_date", true));
            this.dtpAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppoint.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppoint.Location = new System.Drawing.Point(192, 364);
            this.dtpAppoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAppoint.Name = "dtpAppoint";
            this.dtpAppoint.Size = new System.Drawing.Size(160, 30);
            this.dtpAppoint.TabIndex = 83;
            this.dtpAppoint.Tag = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 364);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 36);
            this.label20.TabIndex = 98;
            this.label20.Text = "ការណាត់ជួប";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 36);
            this.label9.TabIndex = 97;
            this.label9.Text = "លេខទូរស័ព្ទ";
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_tel", true));
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(745, 366);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(556, 34);
            this.txtTel.TabIndex = 84;
            this.txtTel.Tag = "សូមបញ្ចូលលេខទូរស័ព្ទ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 36);
            this.label8.TabIndex = 96;
            this.label8.Text = "អាស័យដ្ឋាន/កន្លែងធ្វើការ";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_address", true));
            this.txtAddress.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(563, 250);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(739, 39);
            this.txtAddress.TabIndex = 79;
            this.txtAddress.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 36);
            this.label7.TabIndex = 95;
            this.label7.Text = "សញ្ជាតិ";
            // 
            // txtJob
            // 
            this.txtJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_job", true));
            this.txtJob.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(192, 305);
            this.txtJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(579, 39);
            this.txtJob.TabIndex = 80;
            this.txtJob.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 36);
            this.label6.TabIndex = 94;
            this.label6.Text = "មុខរបរ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1136, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 36);
            this.label5.TabIndex = 93;
            this.label5.Text = "ភេទ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 36);
            this.label4.TabIndex = 92;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 91;
            this.label3.Text = "ឈ្មោះ(ខ្មែរ)";
            // 
            // txtKhLname
            // 
            this.txtKhLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_kh_lname", true));
            this.txtKhLname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhLname.Location = new System.Drawing.Point(745, 129);
            this.txtKhLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhLname.Name = "txtKhLname";
            this.txtKhLname.Size = new System.Drawing.Size(384, 39);
            this.txtKhLname.TabIndex = 74;
            this.txtKhLname.Tag = "សូមបញ្ចូលឈ្មោះ(ខ្មែរ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 36);
            this.label2.TabIndex = 90;
            this.label2.Text = "ត្រកូល(ខ្មែរ)";
            // 
            // txtKhFname
            // 
            this.txtKhFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_kh_fname", true));
            this.txtKhFname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhFname.Location = new System.Drawing.Point(192, 127);
            this.txtKhFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhFname.Name = "txtKhFname";
            this.txtKhFname.Size = new System.Drawing.Size(323, 39);
            this.txtKhFname.TabIndex = 73;
            this.txtKhFname.Tag = "សូមបញ្ចូលត្រកូល(ខ្មែរ)";
            // 
            // btn_Reg_Pat_Save
            // 
            this.btn_Reg_Pat_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Reg_Pat_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Save.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Save.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Save.Location = new System.Drawing.Point(983, 789);
            this.btn_Reg_Pat_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reg_Pat_Save.Name = "btn_Reg_Pat_Save";
            this.btn_Reg_Pat_Save.Size = new System.Drawing.Size(249, 50);
            this.btn_Reg_Pat_Save.TabIndex = 87;
            this.btn_Reg_Pat_Save.Text = "រក្សាទុក";
            this.btn_Reg_Pat_Save.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Save.Click += new System.EventHandler(this.btn_Reg_Pat_Save_Click);
            // 
            // fun_getPatientByIDTableAdapter
            // 
            this.fun_getPatientByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientTableAdapter
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getMedicalHistoryForSpecificPatientTableAdapter
            // 
            this.fun_getMedicalHistoryForSpecificPatientTableAdapter.ClearBeforeFill = true;
            // 
            // txtGender
            // 
            this.txtGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fun_getPatientByIDBindingSource, "pat_gender", true));
            this.txtGender.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(1184, 128);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(117, 39);
            this.txtGender.TabIndex = 108;
            this.txtGender.Tag = "សូមបញ្ចូលភេទ(Male,Female)";
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(39, 633);
            this.btnInactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(143, 84);
            this.btnInactive.TabIndex = 109;
            this.btnInactive.Text = "ផ្លាស់ប្តូរ\r\nស្ថានភាពជម្ងឺ";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // fun_getPatientImageByIDTableAdapter
            // 
            this.fun_getPatientImageByIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = dentist.Dentist_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnShowPic
            // 
            this.btnShowPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnShowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPic.FlatAppearance.BorderSize = 0;
            this.btnShowPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPic.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPic.ForeColor = System.Drawing.Color.White;
            this.btnShowPic.Location = new System.Drawing.Point(1356, 352);
            this.btnShowPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(145, 42);
            this.btnShowPic.TabIndex = 110;
            this.btnShowPic.Text = "បង្ហាញរូបភាព";
            this.btnShowPic.UseVisualStyleBackColor = false;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // nudMinute
            // 
            this.nudMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinute.Location = new System.Drawing.Point(549, 361);
            this.nudMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(59, 34);
            this.nudMinute.TabIndex = 114;
            this.nudMinute.Tag = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(488, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 36);
            this.label15.TabIndex = 113;
            this.label15.Text = "នាទី";
            // 
            // nudHour
            // 
            this.nudHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHour.Location = new System.Drawing.Point(423, 361);
            this.nudHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(59, 34);
            this.nudHour.TabIndex = 112;
            this.nudHour.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(361, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 36);
            this.label14.TabIndex = 111;
            this.label14.Text = "ម៉ោង";
            // 
            // frm_Patient_Detail_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 864);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnShowPic);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btn_Reg_Pat_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reg_Pat_Save);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtKhFname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtKhLname);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMd);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNati);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dtpAppoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Patient_Detail_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Activated += new System.EventHandler(this.frm_Patient_Detail_Edit_Activated);
            this.Load += new System.EventHandler(this.frm_Patient_Detail_Edit_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getMedicalHistoryForSpecificPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientImageByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.DataGridView dgvMd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.ComboBox cboMd;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Reg_Pat_Cancel;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtNati;
        private System.Windows.Forms.DateTimePicker dtpAppoint;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKhFname;
        private System.Windows.Forms.Button btn_Reg_Pat_Save;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fun_getPatientByIDBindingSource;
        private Dentist_DSTableAdapters.fun_getPatientByIDTableAdapter fun_getPatientByIDTableAdapter;
        private System.Windows.Forms.BindingSource fun_getActiveMedicalHistoryForSpecificPaientBindingSource;
        private Dentist_DSTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter fun_getActiveMedicalHistoryForSpecificPaientTableAdapter;
        private System.Windows.Forms.BindingSource fun_getMedicalHistoryForSpecificPatientBindingSource;
        private Dentist_DSTableAdapters.fun_getMedicalHistoryForSpecificPatientTableAdapter fun_getMedicalHistoryForSpecificPatientTableAdapter;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.BindingSource fun_getPatientImageByIDBindingSource;
        private Dentist_DSTableAdapters.fun_getPatientImageByIDTableAdapter fun_getPatientImageByIDTableAdapter;
        private Dentist_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_status;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label14;
    }
}