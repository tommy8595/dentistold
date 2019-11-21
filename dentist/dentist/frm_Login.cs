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
            this.Close();
            th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openHome()
        {
            Application.Run(new frm_Home());
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
        
        }
    }
}
