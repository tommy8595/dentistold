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
    public partial class frm_Doctor_Detail : Form
    {
        public frm_Doctor_Detail()
        {
            InitializeComponent();
        }

        private void btn_Doc_Det_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openDoctor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openDoctor()
        {
            Application.Run(new frm_Doctor());
        }
    }
}
