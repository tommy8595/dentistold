using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dentist
{
    public partial class frm_Expense_Add : Form
    {
        public frm_Expense_Add()
        {
            InitializeComponent();
        }



        private void btn_Expense_Save_Click(object sender, EventArgs e)
        {
            string exp_name = txt_Expense_Name.Text;
            float exp_price = float.Parse(txt_Expense_Price.Text);
            string exp_detail = txt_Expense_Detail.Text;
            StoreProcedure.sp_insert_expense(exp_detail, exp_name, exp_price);
            this.Close();
            Thread th = new Thread(openExpense);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openExpense()
        {
            Application.Run(new frm_Expense());
        }

        private void btn_Expense_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openExpense);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
