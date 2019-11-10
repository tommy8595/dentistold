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
using System.Drawing.Imaging;
using System.IO;

namespace dentist
{
    public partial class frm_Patient_Register : Form
    {
        public frm_Patient_Register()
        {
            InitializeComponent();
        }
        string imgLoc = "";

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

        private bool IsPassValidated()
        {
            if (string.IsNullOrEmpty(imgLoc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Reg_Pat_Save_Click(object sender, EventArgs e)
        {
            if (!GlobalMethod.FormValidate(this) || IsPassValidated()) { return; }
            if (!MyMSB.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនទេ?", "1", true)){ return; }
            

            byte[] imgBinary = GlobalMethod.GetImageByte(imgLoc);
            StoreProcedure.spd_insert_patient(
                txtKhFname.Text,
                txtKhLname.Text,
                txtFname.Text,
                txtLname.Text,
                cboGender.Text,
                nudDob.Value.ToString(),
                txtJob.Text,
                txtAddress.Text,
                imgBinary,
                dtpAppoint.Value.ToString("yyyy-MM-dd"),
                txtNati.Text,
                txtTel.Text,
                string.Format("{0}:{1}",nudHour.Value.ToString(),nudMinute.Value.ToString())
                );
            if (dgvMd.Rows.Count > 0) { StoreProcedure.spd_insert_patient_md(dgvMd); }
            GlobalVariable._Patient_id = txtId.Text;
            

            MyMSB.Show("ការរក្សាទុកបានជោគជ័យ", "1", true);
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatientDetail()
        {
            Application.Run(new frm_Patient_Detail());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg";
                dlg.Title = "Select Patient Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = VaryQualityLevel(dlg.FileName.ToString());
                    pb.ImageLocation = imgLoc;
                }

            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("TestForm / btnBrowse_Click : " + t.Message);
            }
        }
        private string VaryQualityLevel(string imgLoc)
        {
            string GeneratedFilePath = "";
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            using (Bitmap bmp1 = new Bitmap(imgLoc))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.  
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                GeneratedFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\LowQualityImage\LowImage.jpg";
                bmp1.Save(GeneratedFilePath, jpgEncoder, myEncoderParameters);
                return GeneratedFilePath;
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat jpeg)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == jpeg.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void frm_Patient_Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentist_DS.fun_getAllMedicalHistory' table. You can move, or remove it, as needed.
            this.fun_getAllMedicalHistoryTableAdapter.Fill(this.dentist_DS.fun_getAllMedicalHistory);
            txtId.Text = (StoreProcedure.GetlastID() + 1).ToString();
            cboGender.SelectedIndex = 1;
            txtTel.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxNumberOnly);
            txtKhFname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
            txtKhLname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
            txtFname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
            txtLname.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
            txtNati.KeyPress += new KeyPressEventHandler(EventHandler.TextBoxTextOnly);
            txtJob.KeyDown += new KeyEventHandler(EventHandler.TextBoxClearBackPress);
            txtJob.Leave += new System.EventHandler(EventHandler.TextBoxLeaveReturnDefalut);
            txtAddress.KeyDown += new KeyEventHandler(EventHandler.TextBoxClearBackPress);
            txtAddress.Leave += new System.EventHandler(EventHandler.TextBoxLeaveReturnDefalut);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMd.Rows)
            {
                if (row.Cells["md_id"].Value​​.ToString() == cboMd.SelectedValue.ToString())
                {
                    MyMSB.Show("ប្រវតិ្តវេជ្ជសាស្រ្តបានបញ្ចូលរួចហើយ", "0", false);
                    return;
                }
            }
            dgvMd.Rows.Add(txtId.Text, cboMd.SelectedValue, GlobalMethod.getCboData(cboMd, "md_name"), txtDes.Text, "Active");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image flipImage = pb.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pb.Image = flipImage;
        }
    }
}
