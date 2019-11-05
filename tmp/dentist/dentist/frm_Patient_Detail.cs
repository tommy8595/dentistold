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
    public partial class frm_Patient_Detail : Form
    {
        public frm_Patient_Detail()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void frm_Patient_Detail_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariable._Patient_id != "")
                {
                    txtId.Text = GlobalVariable._Patient_id;
                    RetrieveData(int.Parse(GlobalVariable._Patient_id));
                    txtAppoint.Text = Convert.ToDateTime(txtAppoint.Text).ToString("dd-MM-yyyy");
                    GlobalVariable._Patient_id = "";
                    GlobalMethod.getGreenRed("md_status", fun_getActiveMedicalHistoryForSpecificPaientDataGridView, "Inactive");
                }
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient_Detail_Load :" + t.Message);
            }
        }
        private void RetrieveData(int pat_id)
        {
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.Fill(dentist_DS.fun_getActiveMedicalHistoryForSpecificPaient, pat_id);
            this.fun_getPatientByIDTableAdapter.Fill(dentist_DS.fun_getPatientByID, pat_id);
        }
        private void btn_Pat_Det_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void openPatient()
        {
            Application.Run(new frm_Patient());
        }

        private void btn_Pat_Det_Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVariable._Patient_id = txtId.Text;
            frm_Patient_Detail_Edit form = new frm_Patient_Detail_Edit();
            form.ShowDialog();
        }

        private void openPatDetEdit()
        {
            Application.Run(new frm_Patient_Detail_Edit());
        }
        private void btnShowPic_Click(object sender, EventArgs e)
        {
            this.fun_getPatientImageByIDTableAdapter.Fill(dentist_DS.fun_getPatientImageByID, int.Parse(txtId.Text));
        }

        private void btn_Reg_Pat_Save_Click(object sender, EventArgs e)
        {          
            txtRandomNumber.Text = string.Format("{0}{1}", txtId.Text, rnd.Next(1000, 9999).ToString());
            StoreProcedure.spd_insert_patDoc(int.Parse(txtId.Text), txtRandomNumber.Text, txtId.Text.Length);
            //MessageBox.Show(string.Format("{0}  {1}",txtRandomNumber.Text.Substring(0,txtId.Text.Length), txtRandomNumber.Text.Substring(txtId.Text.Length)));     
        }
    }
}
