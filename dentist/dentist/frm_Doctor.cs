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
    public partial class frm_Doctor : Form
    {
        public frm_Doctor()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Patient_Back_Click(object sender, EventArgs e)
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

        private void btn_Doc_Register_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openDocReg);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openDocReg()
        {
            Application.Run(new frm_Doctor_Register());
        }
    }
}
