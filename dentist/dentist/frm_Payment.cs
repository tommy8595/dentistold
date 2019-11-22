using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public partial class frm_Payment : Form
    {
        string pat_name;
        public frm_Payment(string pat_name)
        {
            InitializeComponent();
            this.pat_name = pat_name;         
        }

        private void frm_Payment_Load(object sender, EventArgs e)
        {
            lblPatName.Text = pat_name;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.fun_getServicePaymentByDateTableAdapter.Fill(
                this.dentist_DS.fun_getServicePaymentByDate,
                dtpStart.Value.ToString("yyyy-MM-dd"), 
                dtpEnd.Value.ToString("yyyy-MM-dd"), 
                int.Parse(GlobalVariable._Patient_id));
            this.fun_getPrescriptionByDateTableAdapter.Fill(
                this.dentist_DS.fun_getPrescriptionByDate,
                dtpStart.Value.ToString("yyyy-MM-dd"),
                dtpEnd.Value.ToString("yyyy-MM-dd"),
                int.Parse(GlobalVariable._Patient_id)
                );
        }

        private void btnGenerateInv_Click(object sender, EventArgs e)
        {
            try
            {
                if (fun_getServicePaymentByDateDataGridView.Rows.Count <= 0 && dgv2.Rows.Count <= 0) { MyMSB.Show("មិនមានអ្វីត្រូវចេញវិក័យបត្រនោះទេ។", "0", false); return; }
                int inv_id = StoreProcedure.spd_insert_service_payment(fun_getServicePaymentByDateDataGridView, dgv2, GlobalVariable._user_user_name, int.Parse(GlobalVariable._Patient_id));
                btnPayment.PerformClick();
                frm_InvoicePrint form = new frm_InvoicePrint(inv_id, pat_name, GlobalVariable._Patient_id.PadLeft(5, '0'), DateTime.Today.ToString("dd MMMM yyyy"), txtExchange.Text);
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_payment /btnGenerateInv_Click " + t.Message + t.StackTrace);
            }
        }

        private void btnAlltime_Click(object sender, EventArgs e)
        {
            
            this.fun_getServicePaymentByDateTableAdapter.Fill(
               this.dentist_DS.fun_getServicePaymentByDate,
               "2000-01-01",
               "2500-01-01",
               int.Parse(GlobalVariable._Patient_id));
            this.fun_getPrescriptionByDateTableAdapter.Fill(
                this.dentist_DS.fun_getPrescriptionByDate,
                "2000-01-01",
                "2500-01-01",
                int.Parse(GlobalVariable._Patient_id)
                );
        }
    }
}
