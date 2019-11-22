namespace dentist
{
    partial class frm_owed_lists
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
            this.funAllOwedDistinctByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentist_DS = new dentist.Dentist_DS();
            this.funOwedByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPayment = new System.Windows.Forms.Button();
            this.fun_AllOwedDistinctByPatIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_AllOwedDistinctByPatIDTableAdapter();
            this.fun_OwedByPatIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_OwedByPatIDTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOwed = new dentist.Grid();
            this.invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owedamountleftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllOwed = new dentist.Grid();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullKhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patkhfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pataddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.funAllOwedDistinctByPatIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funOwedByPatIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOwed)).BeginInit();
            this.SuspendLayout();
            // 
            // funAllOwedDistinctByPatIDBindingSource
            // 
            this.funAllOwedDistinctByPatIDBindingSource.DataMember = "fun_AllOwedDistinctByPatID";
            this.funAllOwedDistinctByPatIDBindingSource.DataSource = this.dentist_DS;
            // 
            // dentist_DS
            // 
            this.dentist_DS.DataSetName = "Dentist_DS";
            this.dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funOwedByPatIDBindingSource
            // 
            this.funOwedByPatIDBindingSource.DataMember = "fun_OwedByPatID";
            this.funOwedByPatIDBindingSource.DataSource = this.dentist_DS;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(955, 40);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(142, 32);
            this.btnPayment.TabIndex = 90;
            this.btnPayment.Text = "ទូទាត់ប្រាក់";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // fun_AllOwedDistinctByPatIDTableAdapter
            // 
            this.fun_AllOwedDistinctByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_OwedByPatIDTableAdapter
            // 
            this.fun_OwedByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 102;
            this.label5.Text = "Exchange Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 27);
            this.label4.TabIndex = 101;
            this.label4.Text = "1$=";
            // 
            // txtExchange
            // 
            this.txtExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExchange.Location = new System.Drawing.Point(854, 48);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(81, 24);
            this.txtExchange.TabIndex = 100;
            this.txtExchange.Text = "4000";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 32);
            this.btnBack.TabIndex = 103;
            this.btnBack.Text = "ថយក្រោយ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOwed
            // 
            this.dgvOwed.AllowUserToAddRows = false;
            this.dgvOwed.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgvOwed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOwed.AutoGenerateColumns = false;
            this.dgvOwed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgvOwed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOwed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_id,
            this.invoicedateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.owedamountleftDataGridViewTextBoxColumn});
            this.dgvOwed.DataSource = this.funOwedByPatIDBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOwed.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOwed.Location = new System.Drawing.Point(12, 389);
            this.dgvOwed.MultiSelect = false;
            this.dgvOwed.Name = "dgvOwed";
            this.dgvOwed.ReadOnly = true;
            this.dgvOwed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwed.Size = new System.Drawing.Size(1085, 262);
            this.dgvOwed.TabIndex = 1;
            // 
            // invoice_id
            // 
            this.invoice_id.DataPropertyName = "invoice_id";
            this.invoice_id.HeaderText = "invoice_id";
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.ReadOnly = true;
            // 
            // invoicedateDataGridViewTextBoxColumn
            // 
            this.invoicedateDataGridViewTextBoxColumn.DataPropertyName = "invoice_date";
            this.invoicedateDataGridViewTextBoxColumn.HeaderText = "invoice_date";
            this.invoicedateDataGridViewTextBoxColumn.Name = "invoicedateDataGridViewTextBoxColumn";
            this.invoicedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // owedamountleftDataGridViewTextBoxColumn
            // 
            this.owedamountleftDataGridViewTextBoxColumn.DataPropertyName = "owed_amount_left";
            this.owedamountleftDataGridViewTextBoxColumn.HeaderText = "owed_amount_left";
            this.owedamountleftDataGridViewTextBoxColumn.Name = "owedamountleftDataGridViewTextBoxColumn";
            this.owedamountleftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvAllOwed
            // 
            this.dgvAllOwed.AllowUserToAddRows = false;
            this.dgvAllOwed.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgvAllOwed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllOwed.AutoGenerateColumns = false;
            this.dgvAllOwed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgvAllOwed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllOwed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOwed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.FullKhName,
            this.fullNameDataGridViewTextBoxColumn,
            this.patkhfnameDataGridViewTextBoxColumn,
            this.patgenderDataGridViewTextBoxColumn,
            this.pataddressDataGridViewTextBoxColumn});
            this.dgvAllOwed.DataSource = this.funAllOwedDistinctByPatIDBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllOwed.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllOwed.Location = new System.Drawing.Point(12, 87);
            this.dgvAllOwed.MultiSelect = false;
            this.dgvAllOwed.Name = "dgvAllOwed";
            this.dgvAllOwed.ReadOnly = true;
            this.dgvAllOwed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllOwed.Size = new System.Drawing.Size(1085, 262);
            this.dgvAllOwed.TabIndex = 0;
            this.dgvAllOwed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllOwed_CellClick);
            // 
            // pat_id
            // 
            this.pat_id.DataPropertyName = "pat_id";
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            // 
            // FullKhName
            // 
            this.FullKhName.DataPropertyName = "FullKhName";
            this.FullKhName.HeaderText = "FullKhName";
            this.FullKhName.Name = "FullKhName";
            this.FullKhName.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patkhfnameDataGridViewTextBoxColumn
            // 
            this.patkhfnameDataGridViewTextBoxColumn.DataPropertyName = "pat_kh_fname";
            this.patkhfnameDataGridViewTextBoxColumn.HeaderText = "pat_kh_fname";
            this.patkhfnameDataGridViewTextBoxColumn.Name = "patkhfnameDataGridViewTextBoxColumn";
            this.patkhfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patgenderDataGridViewTextBoxColumn
            // 
            this.patgenderDataGridViewTextBoxColumn.DataPropertyName = "pat_gender";
            this.patgenderDataGridViewTextBoxColumn.HeaderText = "pat_gender";
            this.patgenderDataGridViewTextBoxColumn.Name = "patgenderDataGridViewTextBoxColumn";
            this.patgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pataddressDataGridViewTextBoxColumn
            // 
            this.pataddressDataGridViewTextBoxColumn.DataPropertyName = "pat_address";
            this.pataddressDataGridViewTextBoxColumn.HeaderText = "pat_address";
            this.pataddressDataGridViewTextBoxColumn.Name = "pataddressDataGridViewTextBoxColumn";
            this.pataddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_owed_lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 663);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dgvOwed);
            this.Controls.Add(this.dgvAllOwed);
            this.Name = "frm_owed_lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_owed_lists";
            this.Activated += new System.EventHandler(this.frm_owed_lists_Activated);
            this.Load += new System.EventHandler(this.frm_owed_lists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funAllOwedDistinctByPatIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funOwedByPatIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOwed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPayment;
        private Dentist_DS dentist_DS;
        private System.Windows.Forms.BindingSource funAllOwedDistinctByPatIDBindingSource;
        private Dentist_DSTableAdapters.fun_AllOwedDistinctByPatIDTableAdapter fun_AllOwedDistinctByPatIDTableAdapter;
        private System.Windows.Forms.BindingSource funOwedByPatIDBindingSource;
        private Dentist_DSTableAdapters.fun_OwedByPatIDTableAdapter fun_OwedByPatIDTableAdapter;
        private Grid dgvAllOwed;
        private Grid dgvOwed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owedamountleftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullKhName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patkhfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pataddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}