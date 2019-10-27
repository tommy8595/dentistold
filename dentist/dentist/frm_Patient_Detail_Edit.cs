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
    public partial class frm_Patient_Detail_Edit : Form
    {
        public frm_Patient_Detail_Edit()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Pat_Det_Edit_Save_Click(object sender, EventArgs e)
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

        private void btn_Pat_Det_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatientDetail);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
