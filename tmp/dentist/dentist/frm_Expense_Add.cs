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
