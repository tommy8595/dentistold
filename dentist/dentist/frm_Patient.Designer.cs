namespace dentist
{
    partial class frm_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Patient_Register = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboSearchChoice = new System.Windows.Forms.ComboBox();
            this.btn_Patient_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullKhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patbirthyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pataddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getAllPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.btn_Patient_Back = new System.Windows.Forms.Button();
            this.fun_getAllPatientTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getAllPatientTableAdapter();
            this.tableAdapterManager = new dentist.Dentist_DSTableAdapters.TableAdapterManager();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getAllPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Patient_Register
            // 
            this.btn_Patient_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Patient_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient_Register.FlatAppearance.BorderSize = 0;
            this.btn_Patient_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient_Register.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Patient_Register.Location = new System.Drawing.Point(28, 103);
            this.btn_Patient_Register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Patient_Register.Name = "btn_Patient_Register";
            this.btn_Patient_Register.Size = new System.Drawing.Size(1147, 32);
            this.btn_Patient_Register.TabIndex = 2;
            this.btn_Patient_Register.Text = "ចុះឈ្មោះអ្នកជំងឺ";
            this.btn_Patient_Register.UseVisualStyleBackColor = false;
            this.btn_Patient_Register.Click += new System.EventHandler(this.btn_Patient_Register_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.cboSearchChoice);
            this.panel4.Controls.Add(this.btn_Patient_Search);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 88);
            this.panel4.TabIndex = 1;
            // 
            // cboSearchChoice
            // 
            this.cboSearchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchChoice.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchChoice.FormattingEnabled = true;
            this.cboSearchChoice.Items.AddRange(new object[] {
            "តាមរយៈលេខទូរស័ព្ទ",
            "តាមរយៈឈ្មោះ(ខ្មែរ)",
            "តាមរយៈលេខសម្គាល់",
            "តាមរយៈឈ្មោះ(អង់គ្លេស)"});
            this.cboSearchChoice.Location = new System.Drawing.Point(506, 26);
            this.cboSearchChoice.Name = "cboSearchChoice";
            this.cboSearchChoice.Size = new System.Drawing.Size(196, 35);
            this.cboSearchChoice.TabIndex = 5;
            this.cboSearchChoice.SelectedIndexChanged += new System.EventHandler(this.cboSearchChoice_SelectedIndexChanged);
            // 
            // btn_Patient_Search
            // 
            this.btn_Patient_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Patient_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient_Search.FlatAppearance.BorderSize = 0;
            this.btn_Patient_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient_Search.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Patient_Search.Location = new System.Drawing.Point(1023, 29);
            this.btn_Patient_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Patient_Search.Name = "btn_Patient_Search";
            this.btn_Patient_Search.Size = new System.Drawing.Size(101, 28);
            this.btn_Patient_Search.TabIndex = 4;
            this.btn_Patient_Search.Text = "ស្វែងរក";
            this.btn_Patient_Search.UseVisualStyleBackColor = false;
            this.btn_Patient_Search.Click += new System.EventHandler(this.btn_Patient_Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(717, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 36);
            this.txtSearch.TabIndex = 1;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patidDataGridViewTextBoxColumn,
            this.fullKhName,
            this.fullname,
            this.pat_tel,
            this.patgenderDataGridViewTextBoxColumn,
            this.patbirthyearDataGridViewTextBoxColumn,
            this.patjobDataGridViewTextBoxColumn,
            this.pataddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fun_getAllPatientBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(28, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 422);
            this.dataGridView1.TabIndex = 3;
            // 
            // patidDataGridViewTextBoxColumn
            // 
            this.patidDataGridViewTextBoxColumn.DataPropertyName = "pat_id";
            this.patidDataGridViewTextBoxColumn.FillWeight = 40F;
            this.patidDataGridViewTextBoxColumn.HeaderText = "អ.ល";
            this.patidDataGridViewTextBoxColumn.Name = "patidDataGridViewTextBoxColumn";
            this.patidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullKhName
            // 
            this.fullKhName.DataPropertyName = "fullKhName";
            this.fullKhName.HeaderText = "ឈ្មោះ";
            this.fullKhName.Name = "fullKhName";
            this.fullKhName.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // pat_tel
            // 
            this.pat_tel.DataPropertyName = "pat_tel";
            this.pat_tel.HeaderText = "ល.ទូរស័ព្ទ";
            this.pat_tel.Name = "pat_tel";
            this.pat_tel.ReadOnly = true;
            // 
            // patgenderDataGridViewTextBoxColumn
            // 
            this.patgenderDataGridViewTextBoxColumn.DataPropertyName = "pat_gender";
            this.patgenderDataGridViewTextBoxColumn.FillWeight = 50F;
            this.patgenderDataGridViewTextBoxColumn.HeaderText = "ភេទ";
            this.patgenderDataGridViewTextBoxColumn.Name = "patgenderDataGridViewTextBoxColumn";
            this.patgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patbirthyearDataGridViewTextBoxColumn
            // 
            this.patbirthyearDataGridViewTextBoxColumn.DataPropertyName = "pat_birthyear";
            this.patbirthyearDataGridViewTextBoxColumn.FillWeight = 50F;
            this.patbirthyearDataGridViewTextBoxColumn.HeaderText = "ឆ្នាំកំណើត";
            this.patbirthyearDataGridViewTextBoxColumn.Name = "patbirthyearDataGridViewTextBoxColumn";
            this.patbirthyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patjobDataGridViewTextBoxColumn
            // 
            this.patjobDataGridViewTextBoxColumn.DataPropertyName = "pat_job";
            this.patjobDataGridViewTextBoxColumn.HeaderText = "ការងារ";
            this.patjobDataGridViewTextBoxColumn.Name = "patjobDataGridViewTextBoxColumn";
            this.patjobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pataddressDataGridViewTextBoxColumn
            // 
            this.pataddressDataGridViewTextBoxColumn.DataPropertyName = "pat_address";
            this.pataddressDataGridViewTextBoxColumn.HeaderText = "អាស័យដ្ឋាន";
            this.pataddressDataGridViewTextBoxColumn.Name = "pataddressDataGridViewTextBoxColumn";
            this.pataddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fun_getAllPatientBindingSource
            // 
            this.fun_getAllPatientBindingSource.DataMember = "fun_getAllPatient";
            this.fun_getAllPatientBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Patient_Back
            // 
            this.btn_Patient_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Patient_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient_Back.FlatAppearance.BorderSize = 0;
            this.btn_Patient_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient_Back.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Patient_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Patient_Back.Image")));
            this.btn_Patient_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Patient_Back.Location = new System.Drawing.Point(28, 632);
            this.btn_Patient_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Patient_Back.Name = "btn_Patient_Back";
            this.btn_Patient_Back.Size = new System.Drawing.Size(138, 41);
            this.btn_Patient_Back.TabIndex = 12;
            this.btn_Patient_Back.Text = "ត្រឡប់ក្រោយ";
            this.btn_Patient_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Patient_Back.UseVisualStyleBackColor = false;
            this.btn_Patient_Back.Click += new System.EventHandler(this.btn_Patient_Back_Click);
            // 
            // fun_getAllPatientTableAdapter
            // 
            this.fun_getAllPatientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = dentist.Dentist_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnEditPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPatient.FlatAppearance.BorderSize = 0;
            this.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatient.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.ForeColor = System.Drawing.Color.White;
            this.btnEditPatient.Location = new System.Drawing.Point(28, 147);
            this.btnEditPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(376, 32);
            this.btnEditPatient.TabIndex = 87;
            this.btnEditPatient.Text = "កែប្រែពត៌មានអ្នកជំងឺ";
            this.btnEditPatient.UseVisualStyleBackColor = false;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnPatientDetail
            // 
            this.btnPatientDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btnPatientDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientDetail.FlatAppearance.BorderSize = 0;
            this.btnPatientDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetail.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetail.Location = new System.Drawing.Point(770, 147);
            this.btnPatientDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientDetail.Name = "btnPatientDetail";
            this.btnPatientDetail.Size = new System.Drawing.Size(405, 32);
            this.btnPatientDetail.TabIndex = 88;
            this.btnPatientDetail.Text = "ពិនិត្យពត៌មានលំអិត និងបញ្ជូនអ្នកជំងឺចូលបន្ទប់ព្យាបាល";
            this.btnPatientDetail.UseVisualStyleBackColor = false;
            this.btnPatientDetail.Click += new System.EventHandler(this.btnPatientDetail_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(408, 147);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(358, 32);
            this.btnPayment.TabIndex = 89;
            this.btnPayment.Text = "ទូទាត់ប្រាក់";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // frm_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPatientDetail);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btn_Patient_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Patient_Register);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Activated += new System.EventHandler(this.frm_Patient_Activated);
            this.Load += new System.EventHandler(this.frm_Patient_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getAllPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Patient_Register;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Patient_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Patient_Back;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fun_getAllPatientBindingSource;
        private Dentist_DSTableAdapters.fun_getAllPatientTableAdapter fun_getAllPatientTableAdapter;
        private Dentist_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnPatientDetail;
        private System.Windows.Forms.ComboBox cboSearchChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn patidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullKhName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn patgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patbirthyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pataddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPayment;
    }
}