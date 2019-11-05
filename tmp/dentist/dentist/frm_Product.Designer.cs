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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product));
            this.btn_Product_Back = new System.Windows.Forms.Button();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.btn_Product_Import = new System.Windows.Forms.Button();
            this.btn_Product_Register = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Patient_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            // dgv_Product_List
            // 
            this.dgv_Product_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(38, 181);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(1462, 579);
            this.dgv_Product_List.TabIndex = 95;
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
            this.btn_Product_Register.Size = new System.Drawing.Size(246, 40);
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
            this.panel4.Size = new System.Drawing.Size(1582, 108);
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
            this.textBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(960, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 34);
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
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Product_Register);
            this.Controls.Add(this.btn_Product_Back);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.btn_Product_Import);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Product_Back;
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Button btn_Product_Import;
        private System.Windows.Forms.Button btn_Product_Register;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Patient_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}