using Microsoft.Reporting.WinForms;
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
    public partial class frm_InvoicePrint : Form
    {
        int inv_id;
        string pat_name, pat_id, pat_date,Er,sum,owed_stat;
        public frm_InvoicePrint(int inv_id,string pat_name, string pat_id, string pat_date,string Er)
        {
            InitializeComponent();
            this.inv_id = inv_id;
            this.pat_date = pat_date;
            this.pat_id = pat_id;
            this.pat_name = pat_name;
            this.Er = Er;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessReport(true, nudUsd.Value, nudRiel.Value, nudOwed.Value);
                StoreProcedure.spd_update_recieve_invoice(inv_id, nudUsd.Value, nudRiel.Value, owed_stat);
                if (nudOwed.Value != 0)
                {
                    StoreProcedure.spd_insert_owed(inv_id, nudOwed.Value, int.Parse(GlobalVariable._Patient_id));
                }
                button1.Enabled = false;
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message + t.StackTrace);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (nudUsd.Value + nudOwed.Value > Convert.ToDecimal(sum)) { nudOwed.Value = 0; }
            nudRiel.Value = (Convert.ToDecimal(sum) - (nudUsd.Value + nudOwed.Value)) * Convert.ToDecimal(Er);
            if (nudOwed.Value == 0)
                {
                    owed_stat = "no";
                }
                else
                {
                    owed_stat = "yes";
                }
        }

        private void frm_InvoicePrint_Load(object sender, EventArgs e)
        {
            try
            {
                sum = returnTotal().ToString();
                txtTotal.Text = string.Format("$ {0}", sum);
                lblEx.Text = string.Format("{0} ៛{1}", lblEx.Text, Er);
                nudUsd.Maximum = Convert.ToDecimal(sum);
                ProcessReport(true);
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_InvoicePrint_Load : " + t.Message);
            }
        }

        void ProcessReport(bool IsPrint,decimal pUsd = 0, decimal pRiel = 0, decimal pOwed = 0)
        {
            // TODO: This line of code loads data into the 'Dentist_DS.fun_getServicePaymentByInvoiceID' table. You can move, or remove it, as needed.
            this.fun_getServicePaymentByInvoiceIDTableAdapter.Fill(this.Dentist_DS.fun_getServicePaymentByInvoiceID, inv_id);
            // TODO: This line of code loads data into the 'Dentist_DS.fun_getPrescriptionPaymentByInvoiceID' table. You can move, or remove it, as needed.
            this.fun_getPrescriptionPaymentByInvoiceIDTableAdapter.Fill(this.Dentist_DS.fun_getPrescriptionPaymentByInvoiceID, inv_id);
            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("pPat_id", pat_id));
            reportParameters.Add(new ReportParameter("pPat_name", pat_name));
            reportParameters.Add(new ReportParameter("pInvoiceNumber", inv_id.ToString()));
            reportParameters.Add(new ReportParameter("pDate", pat_date));
            reportParameters.Add(new ReportParameter("pExchange", Er));
            reportParameters.Add(new ReportParameter("pUsd", pUsd.ToString()));
            reportParameters.Add(new ReportParameter("pRiel", pRiel.ToString("#,##0")));
            reportParameters.Add(new ReportParameter("pOwed", pOwed.ToString()));
            reportParameters.Add(new ReportParameter("pReceiver", GlobalVariable._user_name));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
            if (IsPrint) { this.reportViewer1.LocalReport.Print(); }
            
        }
        decimal returnTotal()
        {
            DataTable dt;
            decimal sum=0;
            dt = fun_getServicePaymentByInvoiceIDTableAdapter.GetData(inv_id);
            foreach (DataRow row in dt.Rows)
            {
                sum = sum + Convert.ToDecimal(row["sp_amount_usd"].ToString());
            }
            dt = fun_getPrescriptionPaymentByInvoiceIDTableAdapter.GetData(inv_id);
            foreach (DataRow row in dt.Rows)
            {
                sum = sum + Convert.ToDecimal(row["ps_total"].ToString());
            }
            return sum;
        }
    }
}
