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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_Patient());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.pn_Home.BringToFront();
        }

        private void btn_Reg_Cancel_Click(object sender, EventArgs e)
        {
            this.pn_Money.BringToFront();
        }

        private void btn_Home_Setting_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openLogin()
        {
            Application.Run(new frm_Login());
        }

        private void pn_Import_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openProduct()
        {
            Application.Run(new frm_Product());
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {
            pn_Money.BringToFront();
        }

        private void btn_Income_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openIncome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openIncome()
        {
            Application.Run(new frm_Income());
        }

        private void btn_Expense_Click(object sender, EventArgs e)
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

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openDoctor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openDoctor()
        {
            Application.Run(new frm_Doctor());
        }
    }
}
