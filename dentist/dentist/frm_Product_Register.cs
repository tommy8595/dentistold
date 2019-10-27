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

        Thread th;

        private void btn_Reg_Pro_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reg_Pro_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
