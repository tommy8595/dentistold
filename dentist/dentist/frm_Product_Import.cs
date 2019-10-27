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

        Thread th;

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
            this.Close();
            Thread th = new Thread(openProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
