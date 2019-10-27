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
    public partial class frm_Patient : Form
    {
        public frm_Patient()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Patient_Register_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openRegPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openRegPatient()
        {
            Application.Run(new frm_Patient_Register());
        }

        private void btn_Patient_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_Home());
        }
    }
}
