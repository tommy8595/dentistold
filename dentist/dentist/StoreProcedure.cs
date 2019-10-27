using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public static class StoreProcedure
    {
       public static string connectionString = ConfigurationManager.ConnectionStrings["dentist.Properties.Settings.DentistConnectionString"].ConnectionString;
        private static SqlCommand cmd;
        private static SqlConnection con;
        

        public static void spd_insert_patient(string pat_kh_fname,string pat_kh_lname,string pat_fname,string pat_lname,string pat_gender,string pat_birthyear,string pat_job,string pat_address, byte[] pat_image )
        {
            try
            {
                MyMSB.Show("កំពុងដំណើរការ", "1", false);
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("dbo.spd_insert_patient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pat_kh_fname", pat_kh_fname);
                cmd.Parameters.AddWithValue("@pat_kh_lname", pat_kh_lname);
                cmd.Parameters.AddWithValue("@pat_fname", pat_fname);
                cmd.Parameters.AddWithValue("@pat_lname", pat_lname);
                cmd.Parameters.AddWithValue("@pat_gender", pat_gender);
                cmd.Parameters.AddWithValue("@pat_birthyear", pat_birthyear);
                cmd.Parameters.AddWithValue("@pat_job", pat_job);
                cmd.Parameters.AddWithValue("@pat_address", pat_address);
                cmd.Parameters.AddWithValue("@pat_image", pat_image);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t )
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_patient : " + t.Message); 
            }
        }
        public static void spd_insert_patient_diagnose(DataGridView dgv)
        {
            DataTable dt;
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("[dbo].[spd_insert_patientDiagnose]", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@tempDiag";
            dt = GlobalMethod.convertDGVtoDT(dgv);
            param.Value = dt;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
