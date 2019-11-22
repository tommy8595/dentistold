namespace dentist
{
    partial class Owed_invoice_print
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fun_getPrescriptionPaymentByInvoiceIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dentist_DS = new dentist.Dentist_DS();
            this.fun_getServicePaymentByInvoiceIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fun_getPrescriptionPaymentByInvoiceIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getPrescriptionPaymentByInvoiceIDTableAdapter();
            this.fun_getServicePaymentByInvoiceIDTableAdapter = new dentist.Dentist_DSTableAdapters.fun_getServicePaymentByInvoiceIDTableAdapter();
            this.lblEx = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudOwed = new System.Windows.Forms.NumericUpDown();
            this.nudRiel = new System.Windows.Forms.NumericUpDown();
            this.nudUsd = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPrescriptionPaymentByInvoiceIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dentist_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByInvoiceIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOwed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsd)).BeginInit();
            this.SuspendLayout();
            // 
            // fun_getPrescriptionPaymentByInvoiceIDBindingSource
            // 
            this.fun_getPrescriptionPaymentByInvoiceIDBindingSource.DataMember = "fun_getPrescriptionPaymentByInvoiceID";
            this.fun_getPrescriptionPaymentByInvoiceIDBindingSource.DataSource = this.Dentist_DS;
            // 
            // Dentist_DS
            // 
            this.Dentist_DS.DataSetName = "Dentist_DS";
            this.Dentist_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fun_getServicePaymentByInvoiceIDBindingSource
            // 
            this.fun_getServicePaymentByInvoiceIDBindingSource.DataMember = "fun_getServicePaymentByInvoiceID";
            this.fun_getServicePaymentByInvoiceIDBindingSource.DataSource = this.Dentist_DS;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Prescription";
            reportDataSource1.Value = this.fun_getPrescriptionPaymentByInvoiceIDBindingSource;
            reportDataSource2.Name = "Service";
            reportDataSource2.Value = this.fun_getServicePaymentByInvoiceIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dentist.Report.Owed_Invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(690, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // fun_getPrescriptionPaymentByInvoiceIDTableAdapter
            // 
            this.fun_getPrescriptionPaymentByInvoiceIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getServicePaymentByInvoiceIDTableAdapter
            // 
            this.fun_getServicePaymentByInvoiceIDTableAdapter.ClearBeforeFill = true;
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(780, 179);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(135, 29);
            this.lblEx.TabIndex = 119;
            this.lblEx.Text = "អត្រាប្តូរប្រាក់​ 1$ = ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(754, 115);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 41);
            this.button2.TabIndex = 118;
            this.button2.Text = "ថយក្រោយ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(754, 457);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(318, 41);
            this.btnPay.TabIndex = 117;
            this.btnPay.Text = "ទទួលប្រាក់ និង Print";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(754, 412);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(318, 41);
            this.btnCalculate.TabIndex = 116;
            this.btnCalculate.Text = "ផ្ទៀងផ្ទាត់ ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudOwed
            // 
            this.nudOwed.DecimalPlaces = 2;
            this.nudOwed.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudOwed.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOwed.Location = new System.Drawing.Point(941, 367);
            this.nudOwed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOwed.Name = "nudOwed";
            this.nudOwed.Size = new System.Drawing.Size(108, 30);
            this.nudOwed.TabIndex = 115;
            // 
            // nudRiel
            // 
            this.nudRiel.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudRiel.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRiel.Location = new System.Drawing.Point(941, 317);
            this.nudRiel.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRiel.Name = "nudRiel";
            this.nudRiel.ReadOnly = true;
            this.nudRiel.Size = new System.Drawing.Size(108, 30);
            this.nudRiel.TabIndex = 113;
            this.nudRiel.ThousandsSeparator = true;
            // 
            // nudUsd
            // 
            this.nudUsd.DecimalPlaces = 2;
            this.nudUsd.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudUsd.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudUsd.Location = new System.Drawing.Point(941, 272);
            this.nudUsd.Name = "nudUsd";
            this.nudUsd.Size = new System.Drawing.Size(108, 30);
            this.nudUsd.TabIndex = 114;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(778, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 34);
            this.label17.TabIndex = 110;
            this.label17.Text = "បង់ជា($)៖";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(779, 370);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(141, 34);
            this.label37.TabIndex = 111;
            this.label37.Text = "ប្រាក់ជំពាក់ជា($)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(778, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 34);
            this.label18.TabIndex = 112;
            this.label18.Text = "បង់ជា(៛)៖";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(941, 224);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(108, 29);
            this.txtTotal.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 108;
            this.label1.Text = "ទឹកប្រាក់សរុបត្រូវបង់";
            // 
            // Owed_invoice_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 668);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudOwed);
            this.Controls.Add(this.nudRiel);
            this.Controls.Add(this.nudUsd);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Owed_invoice_print";
            this.Text = "Owed_invoice_print";
            this.Load += new System.EventHandler(this.Owed_invoice_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPrescriptionPaymentByInvoiceIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dentist_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getServicePaymentByInvoiceIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOwed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fun_getPrescriptionPaymentByInvoiceIDBindingSource;
        private Dentist_DS Dentist_DS;
        private System.Windows.Forms.BindingSource fun_getServicePaymentByInvoiceIDBindingSource;
        private Dentist_DSTableAdapters.fun_getPrescriptionPaymentByInvoiceIDTableAdapter fun_getPrescriptionPaymentByInvoiceIDTableAdapter;
        private Dentist_DSTableAdapters.fun_getServicePaymentByInvoiceIDTableAdapter fun_getServicePaymentByInvoiceIDTableAdapter;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudOwed;
        private System.Windows.Forms.NumericUpDown nudRiel;
        private System.Windows.Forms.NumericUpDown nudUsd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
    }
}