namespace dentist
{
    partial class frm_Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Doctor));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_Patient_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Doc_Register = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 108);
            this.panel4.TabIndex = 122;
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
            this.btn_Patient_Back.Location = new System.Drawing.Point(37, 778);
            this.btn_Patient_Back.Name = "btn_Patient_Back";
            this.btn_Patient_Back.Size = new System.Drawing.Size(184, 50);
            this.btn_Patient_Back.TabIndex = 126;
            this.btn_Patient_Back.Text = "ត្រឡប់ក្រោយ";
            this.btn_Patient_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Patient_Back.UseVisualStyleBackColor = false;
            this.btn_Patient_Back.Click += new System.EventHandler(this.btn_Patient_Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1462, 579);
            this.dataGridView1.TabIndex = 125;
            // 
            // btn_Doc_Register
            // 
            this.btn_Doc_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Doc_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Doc_Register.FlatAppearance.BorderSize = 0;
            this.btn_Doc_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Doc_Register.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doc_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Doc_Register.Location = new System.Drawing.Point(37, 127);
            this.btn_Doc_Register.Name = "btn_Doc_Register";
            this.btn_Doc_Register.Size = new System.Drawing.Size(1462, 40);
            this.btn_Doc_Register.TabIndex = 124;
            this.btn_Doc_Register.Text = "ចុះឈ្មោះពេទ្យ";
            this.btn_Doc_Register.UseVisualStyleBackColor = false;
            this.btn_Doc_Register.Click += new System.EventHandler(this.btn_Doc_Register_Click);
            // 
            // frm_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.btn_Patient_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Doc_Register);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Patient_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Doc_Register;
    }
}