using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
