using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public static class GlobalMethod
    {
        public static byte[] GetImageByte(string ImageFileLocation)
        {
            byte[] img = null;
            FileStream filestream = new FileStream(ImageFileLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryreader = new BinaryReader(filestream);
            img = binaryreader.ReadBytes((int)filestream.Length);
            return img;
        }
        public static bool FormValidate(Form f)
        {
            foreach (Control item in f.Controls)
            {
                if (item is TextBox && ((item as TextBox).Text == "" && item.Enabled == true && !string.IsNullOrEmpty(item.Tag.ToString())))
                {
                    MyMSB.Show(item.Tag.ToString(), "0", false);
                    return false;
                }
                if (item is DateTimePicker && ((DateTime.Now.Date.ToString() == ((item as DateTimePicker).Value.Date.ToString())) && item.Enabled == true && !string.IsNullOrEmpty(item.Tag.ToString())))
                {
                    MyMSB.Show(item.Tag.ToString(), "0", false);
                    return false;
                }
                if (item is ComboBox && ((item as ComboBox).Text == "" && item.Enabled == true && !string.IsNullOrEmpty(item.Tag.ToString())))
                {
                    MyMSB.Show(item.Tag.ToString(), "0", false);
                    return false;
                }
                if (item is NumericUpDown && ((item as NumericUpDown).Value == 0 && (item as NumericUpDown).Enabled == true && !string.IsNullOrEmpty(item.Tag.ToString())))
                {
                    MyMSB.Show(item.Tag.ToString(), "0", false);
                    return false;
                }
            }
            return true;
        }
        public static void rotateimage(PictureBox pb)
        {
            Image flipImage = pb.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pb.Image = flipImage;
        }
        public static void getGreenRed(string columnName, DataGridView dgv,string meaning)
        {
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[columnName].Value.ToString() == meaning)
                    {
                        row.Cells[columnName].Style.BackColor = Color.Tomato;
                    }
                    else { row.Cells[columnName].Style.BackColor = Color.Lime; }
                }
            }
        }
        public static Image GetImageFromBinary(byte[] BinaryStringFromSQL)
        {   //byte[] bytes = Encoding.ASCII.GetBytes(someString);
            Image image;
            byte[] img = BinaryStringFromSQL;
            MemoryStream ms = new MemoryStream(img);
            image = Image.FromStream(ms);
            return image;
        }
        public static string getCboData(ComboBox cbo, string TableRowName)
        {
            DataRow selectedDataRow = ((DataRowView)cbo.SelectedItem).Row;
            return selectedDataRow[TableRowName].ToString();
        }
        public static DataTable convertDGVtoDT(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }
        public static string VaryQualityLevel(string imgLoc)
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            using (Bitmap bmp1 = new Bitmap(imgLoc))
            {
                string GeneratedPath = "";
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
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 25L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                GeneratedPath = @"C:\Users\MSI\Documents\dentistold\dentist\dentist\LowQualityImage\Image1.jpg";/*GlobalVariable._LowImagePath + @"\LowImage.jpg";*/
                bmp1.Save(GeneratedPath, jpgEncoder, myEncoderParameters);
                return GeneratedPath;
            }
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public static void HandleException(string msg)
        {
            MessageBox.Show(string.Format("Error On : {0}", msg), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        public static void TestConnection()
        {
            TestConnectionToDB();
            TestConnectionToInternet();
        }

        public static void TestConnectionToDB()
        {
            try
            {
                SqlConnection con = new SqlConnection(StoreProcedure.connectionString);
                if (con.State == ConnectionState.Open) { con.Close(); }
                con.Open();
            }
            catch (Exception t)
            {
                HandleException("GlobleMethod / TestConnectionToDB : " + t.Message);
            }
        }
        public static void TestConnectionToInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                }
            }
            catch (Exception t)
            {
                HandleException("GlobalMethod / TestConnectionToInternet : " + t.Message);
            }
        }
    }
}
