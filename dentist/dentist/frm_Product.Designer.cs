namespace dentist
{
    partial class frm_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Product_Back = new System.Windows.Forms.Button();
            this.fungetAllProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet2 = new dentist.DentistDataSet2();
            this.fungetProductListExpireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet1 = new dentist.DentistDataSet1();
            this.btn_Product_Import = new System.Windows.Forms.Button();
            this.btn_Product_Register = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Patient_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.fun_getProductListExpireTableAdapter = new dentist.DentistDataSet1TableAdapters.fun_getProductListExpireTableAdapter();
            this.dentistDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getAllProductTableAdapter = new dentist.DentistDataSet2TableAdapters.fun_getAllProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prounitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetProductListExpireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Product_Back
            // 
            this.btn_Product_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Product_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Back.FlatAppearance.BorderSize = 0;
            this.btn_Product_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_Back.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Product_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Product_Back.Image")));
            this.btn_Product_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product_Back.Location = new System.Drawing.Point(38, 776);
            this.btn_Product_Back.Name = "btn_Product_Back";
            this.btn_Product_Back.Size = new System.Drawing.Size(184, 50);
            this.btn_Product_Back.TabIndex = 96;
            this.btn_Product_Back.Text = "ត្រឡប់ក្រោយ";
            this.btn_Product_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Product_Back.UseVisualStyleBackColor = false;
            this.btn_Product_Back.Click += new System.EventHandler(this.btn_Product_Back_Click);
            // 
            // fungetAllProductBindingSource
            // 
            this.fungetAllProductBindingSource.DataMember = "fun_getAllProduct";
            this.fungetAllProductBindingSource.DataSource = this.dentistDataSet2;
            // 
            // dentistDataSet2
            // 
            this.dentistDataSet2.DataSetName = "DentistDataSet2";
            this.dentistDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fungetProductListExpireBindingSource
            // 
            this.fungetProductListExpireBindingSource.DataMember = "fun_getProductListExpire";
            this.fungetProductListExpireBindingSource.DataSource = this.dentistDataSet1;
            // 
            // dentistDataSet1
            // 
            this.dentistDataSet1.DataSetName = "DentistDataSet1";
            this.dentistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Product_Import
            // 
            this.btn_Product_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Product_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Import.FlatAppearance.BorderSize = 0;
            this.btn_Product_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_Import.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Import.ForeColor = System.Drawing.Color.White;
            this.btn_Product_Import.Location = new System.Drawing.Point(38, 125);
            this.btn_Product_Import.Name = "btn_Product_Import";
            this.btn_Product_Import.Size = new System.Drawing.Size(1200, 40);
            this.btn_Product_Import.TabIndex = 94;
            this.btn_Product_Import.Text = "នាំចូល";
            this.btn_Product_Import.UseVisualStyleBackColor = false;
            this.btn_Product_Import.Click += new System.EventHandler(this.btn_Product_Import_Click);
            // 
            // btn_Product_Register
            // 
            this.btn_Product_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Product_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Register.FlatAppearance.BorderSize = 0;
            this.btn_Product_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product_Register.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Product_Register.Location = new System.Drawing.Point(1254, 125);
            this.btn_Product_Register.Name = "btn_Product_Register";
            this.btn_Product_Register.Size = new System.Drawing.Size(232, 40);
            this.btn_Product_Register.TabIndex = 97;
            this.btn_Product_Register.Text = "ចុះឈ្មោះផលិតផលថ្មី";
            this.btn_Product_Register.UseVisualStyleBackColor = false;
            this.btn_Product_Register.Click += new System.EventHandler(this.btn_Product_Register_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.btn_Patient_Search);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1521, 108);
            this.panel4.TabIndex = 98;
            // 
            // btn_Patient_Search
            // 
            this.btn_Patient_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Patient_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient_Search.FlatAppearance.BorderSize = 0;
            this.btn_Patient_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient_Search.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Patient_Search.Location = new System.Drawing.Point(1364, 36);
            this.btn_Patient_Search.Name = "btn_Patient_Search";
            this.btn_Patient_Search.Size = new System.Drawing.Size(135, 34);
            this.btn_Patient_Search.TabIndex = 4;
            this.btn_Patient_Search.Text = "ស្វែងរក";
            this.btn_Patient_Search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(960, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 30);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(3, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // fun_getProductListExpireTableAdapter
            // 
            this.fun_getProductListExpireTableAdapter.ClearBeforeFill = true;
            // 
            // dentistDataSet1BindingSource
            // 
            this.dentistDataSet1BindingSource.DataSource = this.dentistDataSet1;
            this.dentistDataSet1BindingSource.Position = 0;
            // 
            // fun_getAllProductTableAdapter
            // 
            this.fun_getAllProductTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.catnameDataGridViewTextBoxColumn,
            this.stockqtyDataGridViewTextBoxColumn,
            this.prounitDataGridViewTextBoxColumn,
            this.expiredateDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.fungetAllProductBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(38, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1448, 566);
            this.dataGridView1.TabIndex = 99;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catnameDataGridViewTextBoxColumn
            // 
            this.catnameDataGridViewTextBoxColumn.DataPropertyName = "cat_name";
            this.catnameDataGridViewTextBoxColumn.HeaderText = "cat_name";
            this.catnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catnameDataGridViewTextBoxColumn.Name = "catnameDataGridViewTextBoxColumn";
            this.catnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockqtyDataGridViewTextBoxColumn
            // 
            this.stockqtyDataGridViewTextBoxColumn.DataPropertyName = "stock_qty";
            this.stockqtyDataGridViewTextBoxColumn.HeaderText = "stock_qty";
            this.stockqtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockqtyDataGridViewTextBoxColumn.Name = "stockqtyDataGridViewTextBoxColumn";
            this.stockqtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prounitDataGridViewTextBoxColumn
            // 
            this.prounitDataGridViewTextBoxColumn.DataPropertyName = "pro_unit";
            this.prounitDataGridViewTextBoxColumn.HeaderText = "pro_unit";
            this.prounitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prounitDataGridViewTextBoxColumn.Name = "prounitDataGridViewTextBoxColumn";
            this.prounitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiredateDataGridViewTextBoxColumn
            // 
            this.expiredateDataGridViewTextBoxColumn.DataPropertyName = "expiredate";
            this.expiredateDataGridViewTextBoxColumn.HeaderText = "expiredate";
            this.expiredateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiredateDataGridViewTextBoxColumn.Name = "expiredateDataGridViewTextBoxColumn";
            this.expiredateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 841);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Product_Register);
            this.Controls.Add(this.btn_Product_Back);
            this.Controls.Add(this.btn_Product_Import);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetProductListExpireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Product_Back;
        private System.Windows.Forms.Button btn_Product_Import;
        private System.Windows.Forms.Button btn_Product_Register;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Patient_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private DentistDataSet1 dentistDataSet1;
        private System.Windows.Forms.BindingSource fungetProductListExpireBindingSource;
        private DentistDataSet1TableAdapters.fun_getProductListExpireTableAdapter fun_getProductListExpireTableAdapter;
        private System.Windows.Forms.BindingSource dentistDataSet1BindingSource;
        private DentistDataSet2 dentistDataSet2;
        private System.Windows.Forms.BindingSource fungetAllProductBindingSource;
        private DentistDataSet2TableAdapters.fun_getAllProductTableAdapter fun_getAllProductTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prounitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}