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
    public partial class frm_Patient_Detail : Form
    {
        public frm_Patient_Detail()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_Pat_Det_Cancel_Click(object sender, EventArgs e)
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

        private void btn_Pat_Det_Edit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openPatDetEdit);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatDetEdit()
        {
            Application.Run(new frm_Patient_Detail_Edit());
        }
    }
}
