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
using System.IO;

namespace dentist
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        Thread th;

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            StoreProcedure.sp_login(username, password);
            StoreProcedure.fn_login_admin(username, password);
            GlobalVariable._LowImageFilePath=GlobalMethod.GetLowImageFilePath("1");
            this.Close();
            th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openHome()
        {
            Application.Run(new frm_Home());
        }
    }
}
