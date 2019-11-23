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
    public partial class frm_Product_Import : Form
    {
        public frm_Product_Import()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable();

        private void btn_Pro_Imp_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openProduct()
        {
            Application.Run(new frm_Product());
        }

        private void btn_Pro_Imp_Save_Click(object sender, EventArgs e)
        {
            int i;
            int d = dt.Rows.Count;
            dt.Columns.RemoveAt(dt.Columns.Count - 1);
            dt.Columns.RemoveAt(dt.Columns.Count - 1);
            dt.Columns.Add("stock_id", typeof(int));
            int max = StoreProcedure.fn_get_stock_max();
            for(i=0;i<d;i++)
            {
                dt.Rows[i]["stock_id"] = max;
                max++;
            }
            DateTime imp_date = DateTime.Parse(dtp_Pro_Imp_Day.Text);
            StoreProcedure.sp_insert_product(dt, imp_date.ToString("yyyy-MM-dd"));
            this.Close();
            Thread th = new Thread(openProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_Pro_Imp_Add_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd";
            DateTime exp_date = DateTime.Parse(dtp_Pro_Imp_Expire.Text);
            if (cbo_Pro_Imp_Name.Text != "" && txt_Pro_Imp_Qty.Text != "")
                dt.Rows.Add(cbo_Pro_Imp_Name.SelectedValue.ToString(), txt_Pro_Imp_Qty.Text, cbo_location.Text, exp_date.ToString(format), cbo_Pro_Imp_Name.Text, txt_Pro_Imp_Unit.Text);
            else
                if ((System.Windows.Forms.MessageBox.Show("Do you wish to continue?", "title", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No))
               
                    if ((System.Windows.Forms.MessageBox.Show("Are you sure?", "title", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes))
                    {
                        this.Close();
                        Thread th = new Thread(openProduct);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
              



        }

      

        private void frm_Product_Import_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentistDataSet.tbl_catagory' table. You can move, or remove it, as needed.
 
            this.dt.Columns.Add("pro_id", typeof(string));
            this.dt.Columns.Add("stock_qty", typeof(string));
            this.dt.Columns.Add("location", typeof(string));
            this.dt.Columns.Add("stock_expiredate", typeof(string));
            this.dt.Columns.Add("Product Name",typeof(string));
            this.dt.Columns.Add("Product Unit", typeof(string));
            this.dgv_Pro_Imp.DataSource = dt;
            dgv_Pro_Imp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.cbo_Pro_Imp_Cat.SelectedIndex = -1;
            this.cbo_location.SelectedIndex = 0;
            dtp_Pro_Imp_Expire.MinDate = DateTime.Now;
            

        }

        

        private void cbo_Pro_Imp_Name_TextChanged(object sender, EventArgs e)
        {
            //this.cbo_Pro_Imp_Name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //this.cbo_Pro_Imp_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //DataTable dt = StoreProcedure.get_pro_detail(cbo_Pro_Imp_Name.Text);
            //TextBox t = sender as TextBox;
            //if (dt.Rows.Count>0)
            //{
   
            //    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            //    collection.Add(dt.Rows[0][1].ToString());
            //    this.cbo_Pro_Imp_Name.AutoCompleteCustomSource = collection;
            //    txt_Pro_Imp_Unit.Text = dt.Rows[0][3].ToString();
            //}
            //else
            //{
            //    txt_Pro_Imp_Unit.Text = "";
            //}
        }

    

        private void cbo_Pro_Imp_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                if (cbo_Pro_Imp_Cat.SelectedValue!=null)
                {
                    int id = 0;
                    int.TryParse(cbo_Pro_Imp_Cat.SelectedValue.ToString(), out id);
                    DataTable dt = StoreProcedure.get_pro_detail_by_cat(id);
                    cbo_Pro_Imp_Name.DataSource = dt;
                    cbo_Pro_Imp_Name.DisplayMember = "pro_name";
                    cbo_Pro_Imp_Name.ValueMember = "pro_id";
                    txt_Pro_Imp_Unit.Text = dt.Rows[0][3].ToString();
                }
            }
            catch(Exception ex)
            {
                GlobalMethod.HandleException(ex.Message);
            }
        }

        private void txt_Pro_Imp_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

        }
    }
}
