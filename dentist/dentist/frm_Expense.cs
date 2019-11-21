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
    public partial class frm_Expense : Form
    {
        public frm_Expense()
        {
            InitializeComponent();
        }



        private void btn_Expense_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openHome()
        {
            Application.Run(new frm_Home());
        }
        private void openAdd()
        {
            Application.Run(new frm_Expense_Add());
        }
        private void btn_Expense_Add_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openAdd);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_Expense_All_Click(object sender, EventArgs e)
        {
            dgv_Expense.DataSource = StoreProcedure.sp_get_expense("sd");
        }

        private void btn_Expense_Today_Click(object sender, EventArgs e)
        {
            dgv_Expense.DataSource = StoreProcedure.sp_get_expense("daily");
        }

        private void btn_Expense_Week_Click(object sender, EventArgs e)
        {
            dgv_Expense.DataSource = StoreProcedure.sp_get_expense("monthly");
        }

        private void btn_Expense_Year_Click(object sender, EventArgs e)
        {
            dgv_Expense.DataSource = StoreProcedure.sp_get_expense("yearly");
        }
    }
}
