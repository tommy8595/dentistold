using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    class EventHandler
    {
        public static void TextBoxNumberOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8 || e.KeyChar == '/')
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
        public static void TextBoxTextOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '0' && e.KeyChar < '9')
            {
                e.Handled = true;
            }
        }
        public static void TextBoxClearBackPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if ((sender as TextBox).Text == "មិនមានពត៌មាន")
                    (sender as TextBox).Clear();
            }
        }
        public static void TextBoxLeaveReturnDefalut(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "មិនមានពត៌មាន";
            }
        }
    }
}
