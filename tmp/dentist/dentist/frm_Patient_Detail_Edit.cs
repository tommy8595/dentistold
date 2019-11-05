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
    public partial class frm_Patient_Detail_Edit : Form
    {
        public frm_Patient_Detail_Edit()
        {
            InitializeComponent();
        }
        string imgLoc = null;
        private void frm_Patient_Detail_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVariable._Patient_id != "")
                {
                    txtId.Text = GlobalVariable._Patient_id;
                    RetrieveData(int.Parse(GlobalVariable._Patient_id));
                    GlobalVariable._Patient_id = "";
                    GlobalMethod.getGreenRed("md_status", dgvMd, "Inactive");
                }
                txtTel.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxNumberOnly);
                txtKhFname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
                txtKhLname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
                txtFname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
                txtLname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
                txtNati.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
                txtJob.KeyDown += new KeyEventHandler(EventHandler.TextBoxClearBackPress);
                txtJob.Leave += new System.EventHandler(EventHandler.TextBoxLeaveReturnDefalut);
                txtAddress.KeyDown += new KeyEventHandler(EventHandler.TextBoxClearBackPress);
                txtAddress.Leave += new System.EventHandler(EventHandler.TextBoxLeaveReturnDefalut);
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient_Detail_Load :" + t.Message);
            }
        }

        private void RetrieveData(int v)
        {
            DataTable dt;
            this.fun_getPatientByIDTableAdapter.Fill(dentist_DS.fun_getPatientByID, v);
            dt = this.fun_getPatientByIDTableAdapter.GetData(v);
            string[] spl = dt.Rows[0]["pat_app_time"].ToString().Split(':');
            nudHour.Value = Convert.ToDecimal(spl[0]);
            nudMinute.Value = Convert.ToDecimal(spl[1]);
            //this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.Fill(dentist_DS.fun_getActiveMedicalHistoryForSpecificPaient, v);
            this.fun_getMedicalHistoryForSpecificPatientTableAdapter.Fill(dentist_DS.fun_getMedicalHistoryForSpecificPatient, v);
            dt = this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.GetData(v);
            foreach (DataRow row in dt.Rows)
            {
                dgvMd.Rows.Add(
                    row["pat_id"].ToString(),
                    row["md_id"].ToString(),
                    row["md_name"].ToString(),
                    row["md_description"].ToString(),
                    row["md_status"].ToString()
                    );

            }


            
        }

        private void btn_Pat_Det_Edit_Save_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatientDetail);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatientDetail()
        {
            Application.Run(new frm_Patient_Detail());
        }

        private void btn_Pat_Det_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatientDetail);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMd.Rows)
            {
                if (row.Cells["md_id"].Value​​.ToString() == cboMd.SelectedValue.ToString())
                {
                    MyMSB.Show("ប្រវតិ្តវេជ្ជសាស្រ្តបានបញ្ចូលរួចហើយ", "0", false);
                    return;
                }
            }
            dgvMd.Rows.Add(txtId.Text, cboMd.SelectedValue, GlobalMethod.getCboData(cboMd, "md_name"), txtDes.Text, "active");

        }

        private void btn_Reg_Pat_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_Reg_Pat_Save_Click(object sender, EventArgs e)
        {   
            try
            {
                byte[] imgByte = null;
                if (!GlobalMethod.FormValidate(this) ) { return; }
                if (!MyMSB.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនទេ?", "1", true)) { return; }
                if (imgLoc != null)
                {
                     imgByte = GlobalMethod.GetImageByte(imgLoc);
                }
                StoreProcedure.spd_update_patientByID(
                    int.Parse(txtId.Text),
                    txtKhFname.Text,
                    txtKhLname.Text,
                    txtFname.Text,
                    txtLname.Text,
                    txtGender.Text,
                    nudDob.Value.ToString(),
                    txtJob.Text,
                    txtAddress.Text,
                    imgByte,
                    dtpAppoint.Value.ToString("yyyy-MM-dd"),
                    txtNati.Text,
                    txtTel.Text,
                    string.Format("{0}:{1}",nudHour.Value.ToString(),nudMinute.Value.ToString())                   
                    );
                if (dgvMd.Rows.Count > 0) { StoreProcedure.spd_insert_patient_md(dgvMd); }
                GlobalVariable._Patient_id = txtId.Text;
                if (MyMSB.Show("ការកែរប្រែបានជោគជ័យ", "1", false)) { btn_Reg_Pat_Cancel.PerformClick(); };
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Patient_Detail_Edit / btn_Reg_Pat_Save_Click : " + t.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg";
                dlg.Title = "Select Patient Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pb.ImageLocation = imgLoc;
                }

            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("TestForm / btnBrowse_Click : " + t.Message);
            }
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            string md_status, pat_id, md_id;
            pat_id = txtId.Text;
            md_id = dgvMd.CurrentRow.Cells["md_id"].Value.ToString();
            if (dgvMd.CurrentRow.Cells["md_status"].Value.ToString() == "Inactive")
            {
                dgvMd.CurrentRow.Cells["md_status"].Value = "Active";
                md_status = "Active";
            }
            else
            {
                dgvMd.CurrentRow.Cells["md_status"].Value = "Inactive";
                md_status = "Inactive";
            }
            GlobalMethod.getGreenRed("md_status", dgvMd, "Inactive");
            StoreProcedure.spd_update_mdHistoryByPatID(int.Parse(pat_id), int.Parse(md_id), md_status);
        }
        private void btnShowPic_Click(object sender, EventArgs e)
        {
            this.fun_getPatientImageByIDTableAdapter.Fill(dentist_DS.fun_getPatientImageByID, int.Parse(txtId.Text));
        }
    }
}
