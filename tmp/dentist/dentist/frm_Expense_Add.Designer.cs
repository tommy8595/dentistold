namespace dentist
{
    partial class frm_Expense_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Expense_Add));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_Expense_Save = new System.Windows.Forms.Button();
            this.btn_Expense_Cancel = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Expense_Detail = new System.Windows.Forms.TextBox();
            this.txt_Expense_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Expense_ID = new System.Windows.Forms.TextBox();
            this.txt_Expense_Name = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            this.panel4.TabIndex = 5;
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
            // btn_Expense_Save
            // 
            this.btn_Expense_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Expense_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Save.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Save.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Save.Location = new System.Drawing.Point(980, 778);
            this.btn_Expense_Save.Name = "btn_Expense_Save";
            this.btn_Expense_Save.Size = new System.Drawing.Size(249, 50);
            this.btn_Expense_Save.TabIndex = 203;
            this.btn_Expense_Save.Text = "រក្សាទុក";
            this.btn_Expense_Save.UseVisualStyleBackColor = false;
            this.btn_Expense_Save.Click += new System.EventHandler(this.btn_Expense_Save_Click);
            // 
            // btn_Expense_Cancel
            // 
            this.btn_Expense_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Expense_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Cancel.Location = new System.Drawing.Point(1250, 778);
            this.btn_Expense_Cancel.Name = "btn_Expense_Cancel";
            this.btn_Expense_Cancel.Size = new System.Drawing.Size(249, 50);
            this.btn_Expense_Cancel.TabIndex = 196;
            this.btn_Expense_Cancel.Text = "បោះបង់";
            this.btn_Expense_Cancel.UseVisualStyleBackColor = false;
            this.btn_Expense_Cancel.Click += new System.EventHandler(this.btn_Expense_Cancel_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1193, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 36);
            this.label20.TabIndex = 191;
            this.label20.Text = "តម្លៃថ្លៃ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 36);
            this.label9.TabIndex = 190;
            this.label9.Text = "ពត៌មានចំណាយ";
            // 
            // txt_Expense_Detail
            // 
            this.txt_Expense_Detail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expense_Detail.Location = new System.Drawing.Point(276, 252);
            this.txt_Expense_Detail.Name = "txt_Expense_Detail";
            this.txt_Expense_Detail.Size = new System.Drawing.Size(1223, 34);
            this.txt_Expense_Detail.TabIndex = 188;
            // 
            // txt_Expense_Price
            // 
            this.txt_Expense_Price.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expense_Price.Location = new System.Drawing.Point(1280, 186);
            this.txt_Expense_Price.Name = "txt_Expense_Price";
            this.txt_Expense_Price.Size = new System.Drawing.Size(219, 34);
            this.txt_Expense_Price.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 183;
            this.label2.Text = "ចំណាយលើ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 182;
            this.label1.Text = "លេខសម្គាល់ការចំណាយ";
            // 
            // txt_Expense_ID
            // 
            this.txt_Expense_ID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expense_ID.Location = new System.Drawing.Point(276, 127);
            this.txt_Expense_ID.Name = "txt_Expense_ID";
            this.txt_Expense_ID.Size = new System.Drawing.Size(1223, 34);
            this.txt_Expense_ID.TabIndex = 181;
            // 
            // txt_Expense_Name
            // 
            this.txt_Expense_Name.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expense_Name.Location = new System.Drawing.Point(276, 189);
            this.txt_Expense_Name.Name = "txt_Expense_Name";
            this.txt_Expense_Name.Size = new System.Drawing.Size(871, 34);
            this.txt_Expense_Name.TabIndex = 204;
            // 
            // frm_Expense_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.txt_Expense_Name);
            this.Controls.Add(this.btn_Expense_Save);
            this.Controls.Add(this.btn_Expense_Cancel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Expense_Detail);
            this.Controls.Add(this.txt_Expense_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Expense_ID);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Expense_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Expense_Save;
        private System.Windows.Forms.Button btn_Expense_Cancel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Expense_Detail;
        private System.Windows.Forms.TextBox txt_Expense_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Expense_ID;
        private System.Windows.Forms.TextBox txt_Expense_Name;
    }
}