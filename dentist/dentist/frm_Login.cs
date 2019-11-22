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
<<<<<<< HEAD
            GlobalVariable._LowImagePath = StoreProcedure.GetConfig(1);
            GlobalVariable._DefaultImgPath = StoreProcedure.GetConfig(2);
            this.Close();
            th = new Thread(openHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
=======
            if (GlobalVariable._user_role == "")
            {
                this.Refresh();
                lbl_denied_info.Text = "Please Enter the correct info.";
            }
            else
            {
                this.Close();
                th = new Thread(openHome);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void openLogin()
        {
            Application.Run(new frm_Login());
>>>>>>> 776e7df6be30489ae317b4a368bd69e91acfe9d5
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
