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

        private void frm_Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentist_DS.fun_getRecentPayment' table. You can move, or remove it, as needed.
            this.fun_getRecentPaymentTableAdapter.Fill(this.dentist_DS.fun_getRecentPayment);
            if (GlobalVariable._user_role=="admin")
            {

            }
            else if(GlobalVariable._user_role=="doctor")
            {

            }
            else if(GlobalVariable._user_role== "receptionist")
            {
                btn_Expense.Enabled = false;
                btn_Staff.Enabled= false;
                btn_Money.Enabled = false;

            }
            else
            {
                

            }
            // TODO: This line of code loads data into the 'dentist_DS.fun_getPatientCurrentAppDate' table. You can move, or remove it, as needed.
            this.fun_getPatientCurrentAppDateTableAdapter.Fill(this.dentist_DS.fun_getPatientCurrentAppDate);
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dgv_Home_Appointment.Rows.Count <= 0) { return; }
            GlobalVariable._Patient_id = dgv_Home_Appointment.CurrentRow.Cells["patidDataGridViewTextBoxColumn"].Value.ToString();
            frm_Patient_Detail form = new frm_Patient_Detail();
            form.ShowDialog();
        }

        private void frm_Home_Activated(object sender, EventArgs e)
        {
            this.fun_getPatientCurrentAppDateTableAdapter.Fill(this.dentist_DS.fun_getPatientCurrentAppDate);
            this.fun_getRecentPaymentTableAdapter.Fill(this.dentist_DS.fun_getRecentPayment);
        }

        private void pn_Home_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = GlobalVariable._user_data.Rows[0]["emp_id"].ToString();
        }

        private void btnOwed_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openOwedList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openOwedList()
        {
            Application.Run(new frm_owed_lists());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable._Patient_id = dataGridView1.CurrentRow.Cells["patidDataGridViewTextBoxColumn1"].Value.ToString();
                frm_Payment form = new frm_Payment(dataGridView1.CurrentRow.Cells["fullKhNameDataGridViewTextBoxColumn"].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Home / btnPayment_Click " + t.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.fun_getRecentPaymentTableAdapter.Fill(this.dentist_DS.fun_getRecentPayment);
        }
    }
}
