using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public partial class MyMSB : Form
    {
        string msg;
        string sign;
        bool IsDisplay;
        static MyMSB newMSB;
        static bool result;
        public MyMSB(string msg, string sign, bool IsDisplay)
        {
            InitializeComponent();
            this.sign = sign;
            this.msg = msg;
            this.IsDisplay = IsDisplay;
        }

        private void MyMSB_Load(object sender, EventArgs e)
        {
            if (sign == "1")
            {
                panel1.BackColor = Color.Chartreuse;
            }
            else if (sign == "0") { panel1.BackColor = Color.Red; lblInfo.ForeColor = Color.Red; }
            if (IsDisplay == false) { button2.Visible = false; }
            else if (IsDisplay == true) { button2.Visible = true; }
            lblInfo.Text = msg;
        }
        public static bool Show(string msg, string sign, bool IsDisplay)
        {
            newMSB = new MyMSB(msg, sign, IsDisplay);
            newMSB.ShowDialog();
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            result = true;
            newMSB.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = false;
            newMSB.Dispose();
        }
    }
}
