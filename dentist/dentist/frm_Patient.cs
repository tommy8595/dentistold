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
    public partial class frm_Patient : Form
    {
        public frm_Patient()
        {
            InitializeComponent();
        }



        private void btn_Patient_Register_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openRegPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openRegPatient()
        {
            Application.Run(new frm_Patient_Register());
        }

        private void btn_Patient_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_Home());
        }

        private void frm_Patient_Load(object sender, EventArgs e)
        {
            try
            {
                this.fun_getAllPatientTableAdapter.Fill(this.dentist_DS.fun_getAllPatient);
                cboSearchChoice.SelectedIndex = 1;
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient_Load " + t.Message);
            }

        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {

            try
            {
                GlobalVariable._Patient_id = dataGridView1.CurrentRow.Cells["patidDataGridViewTextBoxColumn"].Value.ToString();
                frm_Patient_Detail_Edit form = new frm_Patient_Detail_Edit();
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient / btnEditPatient_Click " + t.Message);
            }
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable._Patient_id = dataGridView1.CurrentRow.Cells["patidDataGridViewTextBoxColumn"].Value.ToString();
                frm_Patient_Detail form = new frm_Patient_Detail();
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient / btnEditPatient_Click " + t.Message);
            }
        }

        private void frm_Patient_Activated(object sender, EventArgs e)
        {
            try
            {
                this.fun_getAllPatientTableAdapter.Fill(this.dentist_DS.fun_getAllPatient);
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient / frm_Patient_Activated " + t.Message);
            }
        }

        private void btn_Patient_Search_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboSearchChoice.SelectedIndex == 0)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatTel(dentist_DS.fun_getAllPatient, txtSearch.Text);
                }
                else if (cboSearchChoice.SelectedIndex == 1)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatName(dentist_DS.fun_getAllPatient, txtSearch.Text);
                }
                else if (cboSearchChoice.SelectedIndex == 2)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatId(dentist_DS.fun_getAllPatient, int.Parse(txtSearch.Text));
                }
                else if (cboSearchChoice.SelectedIndex == 3)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatLatinName(dentist_DS.fun_getAllPatient, txtSearch.Text);    
                }
                if (dataGridView1.Rows.Count == 0) { MyMSB.Show("មិនមានពត៌មានទេ សូមពិនិត្យមើលទិន្នន័យដែលបានបញ្ចូលម្តងទៀត", "0", false); return; }
            }
            catch (Exception)
            {
                MyMSB.Show("សូមពិនិត្យមើលពត៌មានដែលបានបញ្ចូលឡើងវិញ", "0", false);
                return;
            }
        }

        private void cboSearchChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchChoice.SelectedIndex == -1) { return; }
            txtSearch.Clear();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable._Patient_id = dataGridView1.CurrentRow.Cells["patidDataGridViewTextBoxColumn"].Value.ToString();
                frm_Payment form = new frm_Payment(dataGridView1.CurrentRow.Cells["fullKhName"].Value.ToString());
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient / btnPayment_Click " + t.Message);
            }
        }
    }
}

