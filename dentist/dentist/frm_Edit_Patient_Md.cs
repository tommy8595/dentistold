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
    public partial class frm_Edit_Patient_Md : Form
    {
        string md_name, md_des, md_status;
        int pat_id, md_id;
        public frm_Edit_Patient_Md(string md_name, string md_des, string md_status,int pat_id, int md_id)
        {
            InitializeComponent();
            this.md_name = md_name;
            this.md_des = md_des;
            this.md_status = md_status;
            this.pat_id = pat_id;
            this.md_id = md_id;
        }

        private void frm_Edit_Patient_Md_Load(object sender, EventArgs e)
        {
            txtMdDes.Text = md_des;
            txtMdName.Text = md_name;
            cboMdStatus.Text = md_status;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StoreProcedure.spd_update_mdHistoryByPatID(pat_id, md_id, cboMdStatus.SelectedItem.ToString(), txtMdDes.Text);
                this.Hide();
                GlobalVariable._isMSB = true;
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Edit_Patient_Md / btnAdd_Click " + t.Message);
            }
        }
    }
}
