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
    public partial class frm_Patient_Register : Form
    {
        public frm_Patient_Register()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Reg_Pat_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_Patient());
        }

        private void btn_Reg_Pat_Save_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatientDetail);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatientDetail()
        {
            Application.Run(new frm_Patient_Detail());
        }
    }
}
