namespace dentist
{
    partial class frm_Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnPayment = new System.Windows.Forms.Button();
            this.fun_getServicePaymentByDateDataGridView = new System.Windows.Forms.DataGridView();
            this.tp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getServicePaymentByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatName = new System.Windows.Forms.Label();
            this.fun_getServicePaymentByDateTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getServicePaymentByDateTableAdapter();
            this.btnGenerateInv = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.ps_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetPrescriptionByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getPrescriptionByDateTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPrescriptionByDateTableAdapter();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlltime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByDateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(149, 59);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(278, 26);
            this.dtpStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "កាលបរិច្ឆេទចាប់ផ្តើម";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "កាលបរិច្ឆេទបញ្ចប់";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(548, 60);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(278, 26);
            this.dtpEnd.TabIndex = 2;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(831, 58);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(118, 32);
            this.btnPayment.TabIndex = 90;
            this.btnPayment.Text = "ស្វែងរក";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // fun_getServicePaymentByDateDataGridView
            // 
            this.fun_getServicePaymentByDateDataGridView.AllowUserToAddRows = false;
            this.fun_getServicePaymentByDateDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.fun_getServicePaymentByDateDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fun_getServicePaymentByDateDataGridView.AutoGenerateColumns = false;
            this.fun_getServicePaymentByDateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fun_getServicePaymentByDateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fun_getServicePaymentByDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fun_getServicePaymentByDateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tp_date,
            this.sd_name,
            this.charge_amount,
            this.tp_amount,
            this.discount_amount,
            this.total_amount,
            this.doc_name,
            this.tp_id,
            this.pat_id,
            this.sd_id,
            this.doc_id,
            this.paid_status});
            this.fun_getServicePaymentByDateDataGridView.DataSource = this.fun_getServicePaymentByDateBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fun_getServicePaymentByDateDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.fun_getServicePaymentByDateDataGridView.Location = new System.Drawing.Point(17, 115);
            this.fun_getServicePaymentByDateDataGridView.MultiSelect = false;
            this.fun_getServicePaymentByDateDataGridView.Name = "fun_getServicePaymentByDateDataGridView";
            this.fun_getServicePaymentByDateDataGridView.ReadOnly = true;
            this.fun_getServicePaymentByDateDataGridView.RowTemplate.Height = 30;
            this.fun_getServicePaymentByDateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fun_getServicePaymentByDateDataGridView.Size = new System.Drawing.Size(1103, 220);
            this.fun_getServicePaymentByDateDataGridView.TabIndex = 92;
            // 
            // tp_date
            // 
            this.tp_date.DataPropertyName = "tp_date";
            this.tp_date.HeaderText = "tp_date";
            this.tp_date.Name = "tp_date";
            this.tp_date.ReadOnly = true;
            // 
            // sd_name
            // 
            this.sd_name.DataPropertyName = "sd_name";
            this.sd_name.HeaderText = "sd_name";
            this.sd_name.Name = "sd_name";
            this.sd_name.ReadOnly = true;
            // 
            // charge_amount
            // 
            this.charge_amount.DataPropertyName = "charge_amount";
            this.charge_amount.HeaderText = "charge_amount";
            this.charge_amount.Name = "charge_amount";
            this.charge_amount.ReadOnly = true;
            // 
            // tp_amount
            // 
            this.tp_amount.DataPropertyName = "tp_amount";
            this.tp_amount.FillWeight = 30F;
            this.tp_amount.HeaderText = "tp_amount";
            this.tp_amount.Name = "tp_amount";
            this.tp_amount.ReadOnly = true;
            // 
            // discount_amount
            // 
            this.discount_amount.DataPropertyName = "discount_amount";
            this.discount_amount.HeaderText = "discount_amount";
            this.discount_amount.Name = "discount_amount";
            this.discount_amount.ReadOnly = true;
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "total_amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            // 
            // doc_name
            // 
            this.doc_name.DataPropertyName = "doc_name";
            this.doc_name.HeaderText = "doc_name";
            this.doc_name.Name = "doc_name";
            this.doc_name.ReadOnly = true;
            // 
            // tp_id
            // 
            this.tp_id.DataPropertyName = "tp_id";
            this.tp_id.HeaderText = "tp_id";
            this.tp_id.Name = "tp_id";
            this.tp_id.ReadOnly = true;
            this.tp_id.Visible = false;
            // 
            // pat_id
            // 
            this.pat_id.DataPropertyName = "pat_id";
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Visible = false;
            // 
            // sd_id
            // 
            this.sd_id.DataPropertyName = "sd_id";
            this.sd_id.HeaderText = "sd_id";
            this.sd_id.Name = "sd_id";
            this.sd_id.ReadOnly = true;
            this.sd_id.Visible = false;
            // 
            // doc_id
            // 
            this.doc_id.DataPropertyName = "doc_id";
            this.doc_id.HeaderText = "doc_id";
            this.doc_id.Name = "doc_id";
            this.doc_id.ReadOnly = true;
            this.doc_id.Visible = false;
            // 
            // paid_status
            // 
            this.paid_status.DataPropertyName = "paid_status";
            this.paid_status.HeaderText = "paid_status";
            this.paid_status.Name = "paid_status";
            this.paid_status.ReadOnly = true;
            this.paid_status.Visible = false;
            // 
            // fun_getServicePaymentByDateBindingSource
            // 
            this.fun_getServicePaymentByDateBindingSource.DataMember = "fun_getServicePaymentByDate";
            this.fun_getServicePaymentByDateBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 93;
            this.label3.Text = "ឈ្មោះអតិថិជន៖";
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatName.Location = new System.Drawing.Point(126, 9);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(108, 27);
            this.lblPatName.TabIndex = 94;
            this.lblPatName.Text = "ឈ្មោះអតិថិជន៖";
            // 
            // fun_getServicePaymentByDateTableAdapter
            // 
            this.fun_getServicePaymentByDateTableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerateInv
            // 
            this.btnGenerateInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnGenerateInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateInv.FlatAppearance.BorderSize = 0;
            this.btnGenerateInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateInv.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInv.ForeColor = System.Drawing.Color.White;
            this.btnGenerateInv.Location = new System.Drawing.Point(979, 638);
            this.btnGenerateInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateInv.Name = "btnGenerateInv";
            this.btnGenerateInv.Size = new System.Drawing.Size(141, 32);
            this.btnGenerateInv.TabIndex = 95;
            this.btnGenerateInv.Text = "បង្កើតវិក័យបត្រ";
            this.btnGenerateInv.UseVisualStyleBackColor = false;
            this.btnGenerateInv.Click += new System.EventHandler(this.btnGenerateInv_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv2.AutoGenerateColumns = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ps_date,
            this.ps_des,
            this.ps_unit,
            this.ps_amount,
            this.ps_price,
            this.ps_total,
            this.ps_id,
            this.ps_status,
            this.pro_id});
            this.dgv2.DataSource = this.fungetPrescriptionByDateBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv2.Location = new System.Drawing.Point(16, 375);
            this.dgv2.MultiSelect = false;
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowTemplate.Height = 30;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(1103, 220);
            this.dgv2.TabIndex = 96;
            // 
            // ps_date
            // 
            this.ps_date.DataPropertyName = "ps_date";
            this.ps_date.HeaderText = "ps_date";
            this.ps_date.Name = "ps_date";
            this.ps_date.ReadOnly = true;
            // 
            // ps_des
            // 
            this.ps_des.DataPropertyName = "ps_des";
            this.ps_des.HeaderText = "ps_des";
            this.ps_des.Name = "ps_des";
            this.ps_des.ReadOnly = true;
            // 
            // ps_unit
            // 
            this.ps_unit.DataPropertyName = "ps_unit";
            this.ps_unit.HeaderText = "ps_unit";
            this.ps_unit.Name = "ps_unit";
            this.ps_unit.ReadOnly = true;
            // 
            // ps_amount
            // 
            this.ps_amount.DataPropertyName = "ps_amount";
            this.ps_amount.HeaderText = "ps_amount";
            this.ps_amount.Name = "ps_amount";
            this.ps_amount.ReadOnly = true;
            // 
            // ps_price
            // 
            this.ps_price.DataPropertyName = "ps_price";
            this.ps_price.HeaderText = "ps_price";
            this.ps_price.Name = "ps_price";
            this.ps_price.ReadOnly = true;
            // 
            // ps_total
            // 
            this.ps_total.DataPropertyName = "ps_total";
            this.ps_total.HeaderText = "ps_total";
            this.ps_total.Name = "ps_total";
            this.ps_total.ReadOnly = true;
            // 
            // ps_id
            // 
            this.ps_id.DataPropertyName = "ps_id";
            this.ps_id.HeaderText = "ps_id";
            this.ps_id.Name = "ps_id";
            this.ps_id.ReadOnly = true;
            this.ps_id.Visible = false;
            // 
            // ps_status
            // 
            this.ps_status.DataPropertyName = "ps_status";
            this.ps_status.HeaderText = "ps_status";
            this.ps_status.Name = "ps_status";
            this.ps_status.ReadOnly = true;
            this.ps_status.Visible = false;
            // 
            // pro_id
            // 
            this.pro_id.DataPropertyName = "pro_id";
            this.pro_id.HeaderText = "pro_id";
            this.pro_id.Name = "pro_id";
            this.pro_id.ReadOnly = true;
            this.pro_id.Visible = false;
            // 
            // fungetPrescriptionByDateBindingSource
            // 
            this.fungetPrescriptionByDateBindingSource.DataMember = "fun_getPrescriptionByDate";
            this.fungetPrescriptionByDateBindingSource.DataSource = this.dentist_DS;
            // 
            // fun_getPrescriptionByDateTableAdapter
            // 
            this.fun_getPrescriptionByDateTableAdapter.ClearBeforeFill = true;
            // 
            // txtExchange
            // 
            this.txtExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExchange.Location = new System.Drawing.Point(1025, 58);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(81, 24);
            this.txtExchange.TabIndex = 97;
            this.txtExchange.Text = "4000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 27);
            this.label4.TabIndex = 98;
            this.label4.Text = "1$=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(993, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 99;
            this.label5.Text = "Exchange Rate";
            // 
            // btnAlltime
            // 
            this.btnAlltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnAlltime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlltime.FlatAppearance.BorderSize = 0;
            this.btnAlltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlltime.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlltime.ForeColor = System.Drawing.Color.White;
            this.btnAlltime.Location = new System.Drawing.Point(435, 23);
            this.btnAlltime.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlltime.Name = "btnAlltime";
            this.btnAlltime.Size = new System.Drawing.Size(118, 32);
            this.btnAlltime.TabIndex = 100;
            this.btnAlltime.Text = "គ្រប់ពេល";
            this.btnAlltime.UseVisualStyleBackColor = false;
            this.btnAlltime.Click += new System.EventHandler(this.btnAlltime_Click);
            // 
            // frm_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 681);
            this.Controls.Add(this.btnAlltime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnGenerateInv);
            this.Controls.Add(this.lblPatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fun_getServicePaymentByDateDataGridView);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Name = "frm_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Payment";
            this.Load += new System.EventHandler(this.frm_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByDateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByDateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnPayment;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource fun_getServicePaymentByDateBindingSource;
        private Dentist_DSTableAdapters.fun_getServicePaymentByDateTableAdapter fun_getServicePaymentByDateTableAdapter;
        private System.Windows.Forms.DataGridView fun_getServicePaymentByDateDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.Button btnGenerateInv;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.BindingSource fungetPrescriptionByDateBindingSource;
        private Dentist_DSTableAdapters.fun_getPrescriptionByDateTableAdapter fun_getPrescriptionByDateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sd_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_status;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlltime;
    }
}