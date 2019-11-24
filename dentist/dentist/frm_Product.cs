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
    public partial class frm_Product : Form
    {
        public frm_Product()
        {
            InitializeComponent();
        }



        private void btn_Product_Register_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(openProReg);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openProReg()
        {
            Application.Run(new frm_Register_Product());
        }

        private void btn_Product_Back_Click(object sender, EventArgs e)
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

        private void btn_Product_Import_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openImport);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openImport()
        {
            Application.Run(new frm_Product_Import());
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentistDataSet1.fun_getAllProduct' table. You can move, or remove it, as needed.
            this.fun_getAllProductTableAdapter.Fill(this.dentistDataSet1.fun_getAllProduct);

        }
    }
}
