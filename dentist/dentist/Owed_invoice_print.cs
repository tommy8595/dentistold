using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public partial class Owed_invoice_print : Form
    {
        int inv_id;
        decimal amount_left;
        string pat_id,pat_name,Er,main_inv;
        public Owed_invoice_print(int inv_id, decimal amount_left, string pat_id, string pat_name, string Er, string main_inv)
        {
            InitializeComponent();
            this.inv_id = inv_id;
            this.pat_id = pat_id;
            this.pat_name = pat_name;
            this.Er = Er;
            this.amount_left = amount_left;
            this.main_inv = main_inv;
        }
        private void Owed_invoice_print_Load(object sender, EventArgs e)
        {
            processReport(inv_id, amount_left: this.amount_left, main_inv_id: main_inv);
            txtTotal.Text = "$" + amount_left.ToString();
            nudUsd.Maximum = Convert.ToDecimal(amount_left);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnPay.Enabled = false;
            StoreProcedure.spd_clear_owed(nudUsd.Value,nudRiel.Value, amount_left, inv_id,Convert.ToDecimal(Er),int.Parse(main_inv));
            processReport(inv_id, amount_left: this.amount_left, main_inv_id: main_inv, pUsd:nudUsd.Value, pRiel:nudRiel.Value,pOwed: nudOwed.Value);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (nudUsd.Value + nudOwed.Value > Convert.ToDecimal(amount_left)) { nudOwed.Value = 0; }
            nudRiel.Value = (Convert.ToDecimal(amount_left) - (nudUsd.Value + nudOwed.Value)) * Convert.ToDecimal(Er);
        }
      
        

        
        void processReport(int inv_id, decimal amount_left = 0, string main_inv_id = "", decimal pUsd=0,decimal pRiel = 0, decimal pOwed = 0)
        {
            // TODO: This line of code loads data into the 'Dentist_DS.fun_getPrescriptionPaymentByInvoiceID' table. You can move, or remove it, as needed.
            this.fun_getPrescriptionPaymentByInvoiceIDTableAdapter.Fill(this.Dentist_DS.fun_getPrescriptionPaymentByInvoiceID, int.Parse(main_inv));
            // TODO: This line of code loads data into the 'Dentist_DS.fun_getServicePaymentByInvoiceID' table. You can move, or remove it, as needed.
            this.fun_getServicePaymentByInvoiceIDTableAdapter.Fill(this.Dentist_DS.fun_getServicePaymentByInvoiceID, int.Parse(main_inv));
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("pPat_id", pat_id));
            reportParameters.Add(new ReportParameter("pPat_name", pat_name));
            reportParameters.Add(new ReportParameter("pInvoice_id", inv_id.ToString()));
            reportParameters.Add(new ReportParameter("pDate", DateTime.Now.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("pExchange", Er));
            reportParameters.Add(new ReportParameter("pUsd", pUsd.ToString()));
            reportParameters.Add(new ReportParameter("pRiel", pRiel.ToString("#,##0")));
            reportParameters.Add(new ReportParameter("pOwed", pOwed.ToString()));
            reportParameters.Add(new ReportParameter("pExchange", Er));
            reportParameters.Add(new ReportParameter("pReceiver", GlobalVariable._user_name));
            reportParameters.Add(new ReportParameter("pAmountLeft", amount_left.ToString("#,##0")));
            reportParameters.Add(new ReportParameter("pMainInv", main_inv_id));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
