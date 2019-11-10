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
    public partial class frm_Register_Product : Form
    {
        public frm_Register_Product()
        {
            InitializeComponent();
        }
        private void btn_Reg_Pro_Save_Click(object sender, EventArgs e)
        {
            int pro_id = int.Parse(txt_Pro_Reg_ID.Text);
            string cate = txt_Pro_Reg_Cat.Text;
            string pro_name = txt_Pro_Reg_Name.Text;
            string pro_unit = txt_Pro_Reg_Unit.Text;
            decimal pro_price = decimal.Parse(txt_Pro_Reg_Price.Text);
            //StoreProcedure.spd_insert_product(pro_name,pro_price,pro_unit,cate);
            this.Close();
        }

        private void btn_Reg_Pro_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
