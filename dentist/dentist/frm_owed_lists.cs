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
    public partial class frm_owed_lists : Form
    {
        public frm_owed_lists()
        {
            InitializeComponent();
        }

        private void frm_owed_lists_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentist_DS.fun_AllOwedDistinctByPatID' table. You can move, or remove it, as needed.
            this.fun_AllOwedDistinctByPatIDTableAdapter.Fill(this.dentist_DS.fun_AllOwedDistinctByPatID);
            if (fun_AllOwedDistinctByPatIDTableAdapter.GetData().Rows.Count <= 0) { return; }
            this.fun_OwedByPatIDTableAdapter.Fill(dentist_DS.fun_OwedByPatID, int.Parse(dgvAllOwed.CurrentRow.Cells["pat_id"].Value.ToString()));

        }
        private void dgvAllOwed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            this.fun_OwedByPatIDTableAdapter.Fill(dentist_DS.fun_OwedByPatID, int.Parse(dgvAllOwed.CurrentRow.Cells["pat_id"].Value.ToString()));
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvOwed.Rows.Count <= 0) { MyMSB.Show("សូមជ្រើសរើសលេខវិក័យបត្រមុនធ្វើការទូទាត់", "0", false); return; }
            decimal amount_left = Convert.ToDecimal(dgvOwed.CurrentRow.Cells["owedamountleftDataGridViewTextBoxColumn"].Value);
            string pat_id = dgvAllOwed.CurrentRow.Cells["pat_id"].Value.ToString();
            string pat_name = dgvAllOwed.CurrentRow.Cells["FullKhName"].Value.ToString();
            string main_inv = dgvOwed.CurrentRow.Cells["invoice_id"].Value.ToString();
            int inv_id = StoreProcedure.spd_insert_invoice(0, 0, GlobalVariable._user_name, int.Parse(dgvAllOwed.CurrentRow.Cells["pat_id"].Value.ToString()));
            Owed_invoice_print form = new Owed_invoice_print(inv_id,amount_left,pat_id,pat_name,txtExchange.Text,main_inv);
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void frm_owed_lists_Activated(object sender, EventArgs e)
        {
            this.fun_AllOwedDistinctByPatIDTableAdapter.Fill(this.dentist_DS.fun_AllOwedDistinctByPatID);
            if (!(fun_AllOwedDistinctByPatIDTableAdapter.GetData().Rows.Count <= 0))
            {
                this.fun_OwedByPatIDTableAdapter.Fill(dentist_DS.fun_OwedByPatID, int.Parse(dgvAllOwed.CurrentRow.Cells["pat_id"].Value.ToString()));
            }
            
        }
    }
}
