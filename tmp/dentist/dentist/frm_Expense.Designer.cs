namespace dentist
{
    partial class frm_Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Expense));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_Expense_Back = new System.Windows.Forms.Button();
            this.dgv_Expense = new System.Windows.Forms.DataGridView();
            this.btn_Expense_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Expense_Total = new System.Windows.Forms.TextBox();
            this.btn_Expense_Week = new System.Windows.Forms.Button();
            this.btn_Expense_Year = new System.Windows.Forms.Button();
            this.btn_Expense_Today = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Expense_All = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel4.TabIndex = 4;
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
            // btn_Expense_Back
            // 
            this.btn_Expense_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Expense_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Back.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Back.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Expense_Back.Image")));
            this.btn_Expense_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Expense_Back.Location = new System.Drawing.Point(38, 778);
            this.btn_Expense_Back.Name = "btn_Expense_Back";
            this.btn_Expense_Back.Size = new System.Drawing.Size(184, 50);
            this.btn_Expense_Back.TabIndex = 96;
            this.btn_Expense_Back.Text = "ត្រឡប់ក្រោយ";
            this.btn_Expense_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Expense_Back.UseVisualStyleBackColor = false;
            this.btn_Expense_Back.Click += new System.EventHandler(this.btn_Expense_Back_Click);
            // 
            // dgv_Expense
            // 
            this.dgv_Expense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Expense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense.Location = new System.Drawing.Point(38, 354);
            this.dgv_Expense.Name = "dgv_Expense";
            this.dgv_Expense.RowHeadersWidth = 51;
            this.dgv_Expense.RowTemplate.Height = 24;
            this.dgv_Expense.Size = new System.Drawing.Size(1462, 408);
            this.dgv_Expense.TabIndex = 95;
            // 
            // btn_Expense_Add
            // 
            this.btn_Expense_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Expense_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Add.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Add.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Add.Location = new System.Drawing.Point(38, 127);
            this.btn_Expense_Add.Name = "btn_Expense_Add";
            this.btn_Expense_Add.Size = new System.Drawing.Size(1462, 40);
            this.btn_Expense_Add.TabIndex = 94;
            this.btn_Expense_Add.Text = "បង្កើតថ្មី";
            this.btn_Expense_Add.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 190;
            this.label1.Text = "ប្រាក់ចំណូលសរុប";
            // 
            // txt_Expense_Total
            // 
            this.txt_Expense_Total.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Expense_Total.Location = new System.Drawing.Point(224, 292);
            this.txt_Expense_Total.Name = "txt_Expense_Total";
            this.txt_Expense_Total.Size = new System.Drawing.Size(1276, 34);
            this.txt_Expense_Total.TabIndex = 189;
            // 
            // btn_Expense_Week
            // 
            this.btn_Expense_Week.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Expense_Week.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Week.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Week.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Week.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Week.Location = new System.Drawing.Point(773, 217);
            this.btn_Expense_Week.Name = "btn_Expense_Week";
            this.btn_Expense_Week.Size = new System.Drawing.Size(360, 50);
            this.btn_Expense_Week.TabIndex = 188;
            this.btn_Expense_Week.Text = "ខែនេះ";
            this.btn_Expense_Week.UseVisualStyleBackColor = false;
            // 
            // btn_Expense_Year
            // 
            this.btn_Expense_Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Expense_Year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Year.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Year.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Year.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Year.Location = new System.Drawing.Point(1140, 217);
            this.btn_Expense_Year.Name = "btn_Expense_Year";
            this.btn_Expense_Year.Size = new System.Drawing.Size(360, 50);
            this.btn_Expense_Year.TabIndex = 187;
            this.btn_Expense_Year.Text = "ឆ្នាំនេះ";
            this.btn_Expense_Year.UseVisualStyleBackColor = false;
            // 
            // btn_Expense_Today
            // 
            this.btn_Expense_Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Expense_Today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_Today.FlatAppearance.BorderSize = 0;
            this.btn_Expense_Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_Today.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_Today.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_Today.Location = new System.Drawing.Point(406, 217);
            this.btn_Expense_Today.Name = "btn_Expense_Today";
            this.btn_Expense_Today.Size = new System.Drawing.Size(360, 50);
            this.btn_Expense_Today.TabIndex = 186;
            this.btn_Expense_Today.Text = "ថ្ងៃនេះ";
            this.btn_Expense_Today.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(38, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1462, 1);
            this.pictureBox2.TabIndex = 191;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Expense_All
            // 
            this.btn_Expense_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btn_Expense_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expense_All.FlatAppearance.BorderSize = 0;
            this.btn_Expense_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Expense_All.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expense_All.ForeColor = System.Drawing.Color.White;
            this.btn_Expense_All.Location = new System.Drawing.Point(39, 217);
            this.btn_Expense_All.Name = "btn_Expense_All";
            this.btn_Expense_All.Size = new System.Drawing.Size(360, 50);
            this.btn_Expense_All.TabIndex = 192;
            this.btn_Expense_All.Text = "គ្រប់ពេល";
            this.btn_Expense_All.UseVisualStyleBackColor = false;
            // 
            // frm_Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.btn_Expense_All);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Expense_Total);
            this.Controls.Add(this.btn_Expense_Week);
            this.Controls.Add(this.btn_Expense_Year);
            this.Controls.Add(this.btn_Expense_Today);
            this.Controls.Add(this.btn_Expense_Back);
            this.Controls.Add(this.dgv_Expense);
            this.Controls.Add(this.btn_Expense_Add);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់គ្លីនិកធ្នេញ";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Expense_Back;
        private System.Windows.Forms.DataGridView dgv_Expense;
        private System.Windows.Forms.Button btn_Expense_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Expense_Total;
        private System.Windows.Forms.Button btn_Expense_Week;
        private System.Windows.Forms.Button btn_Expense_Year;
        private System.Windows.Forms.Button btn_Expense_Today;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Expense_All;
    }
}