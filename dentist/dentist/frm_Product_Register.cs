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
using System.Data.SqlClient;

namespace dentist
{
    public partial class frm_Register_Product : Form
    {
        public frm_Register_Product()
        {
            InitializeComponent();
        }
        //for category
        Dictionary<object, int> dic_category = new Dictionary<object, int>();
        private void btn_Reg_Pro_Save_Click(object sender, EventArgs e)
        {
            //int pro_id = int.Parse(txt_Pro_Reg_ID.Text);
            string pro_name = txt_Pro_Reg_Name.Text;
            decimal pro_price = decimal.Parse(txt_Pro_Reg_Price.Text);
            string pro_unit = txt_Pro_Reg_Unit.Text;            
            int catid = dic_category[cbocat.SelectedItem];
            StoreProcedure.spd_insert_product(pro_name,pro_price,pro_unit,catid);
            this.Close();
            MessageBox.Show("Your data have been saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void btn_Reg_Pro_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbocat_DropDown(object sender, EventArgs e)
        {
            cbocat.Items.Clear();
            dic_category.Clear();
            //StoreProcedure.openconnection();
            SqlConnection con = new SqlConnection(StoreProcedure.connectionString);
            con.Open();
            string q = "select * from tbl_catagory";
            SqlDataReader dr = new SqlCommand(q, con).ExecuteReader();
            while (dr.Read())
            {
                cbocat.Items.Add(dr.GetValue(1).ToString());
                if (dic_category.Count >= 0)
                {
                    dic_category.Add(dr.GetValue(1), dr.GetInt32(0));
                }
            }
            cbocat.Items.Add("Add New...");
            dr.Close();
            con.Close();
        }
    }
}
