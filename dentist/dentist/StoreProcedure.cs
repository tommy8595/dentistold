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


        public static void spd_insert_patient(string pat_kh_fname, string pat_kh_lname, string pat_fname, string pat_lname, string pat_gender, string pat_birthyear, string pat_job, string pat_address, byte[] pat_image,string pat_app_date,string pat_nation,string pat_tel, string pat_app_time)
        {
            //    @pat_kh_fname NVARCHAR(MAX),
            //    @pat_kh_lname NVARCHAR(MAX),
            //    @pat_fname NVARCHAR(MAX),
            //    @pat_lname NVARCHAR(MAX),
            //    @pat_gender NVARCHAR(10),
            //    @pat_birthyear NVARCHAR(MAX),
            //    @pat_job NVARCHAR(MAX),
            //    @pat_address NVARCHAR(MAX),
            //    @pat_image IMAGE
            //    @pat_app_date date
            //    @pat_nation
            //    @pat_tel
            //    @pat_app_time nvarchar(max)
            try
            {
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
                cmd.Parameters.AddWithValue("@pat_app_date", pat_app_date);
                cmd.Parameters.AddWithValue("@pat_nation", pat_nation);
                cmd.Parameters.AddWithValue("@pat_tel", pat_tel);
                cmd.Parameters.AddWithValue("@pat_app_time", pat_app_time);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_patient : " + t.Message);
            }
        }
        public static void spd_insert_doctor(string doc_name, string doc_bod, string doc_qual, string doc_tel, string doc_iden)
        {
            //@doc_name nvarchar(max),
            //@doc_bod nvarchar(max),
            //@doc_qualification nvarchar(max),
            //@doc_tel nvarchar(max),
            //@doc_identifyNumber nvarchar(max)
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("dbo.spd_insert_doctor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doc_name", doc_name);
                cmd.Parameters.AddWithValue("@doc_bod", doc_bod);
                cmd.Parameters.AddWithValue("@doc_qualification", doc_qual);
                cmd.Parameters.AddWithValue("@doc_tel", doc_tel);
                cmd.Parameters.AddWithValue("@doc_identifyNumber", doc_iden);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_doctor : " + t.Message);
            }
        }
        public static void sp_login(string username,string password)
        {
            using (con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                DataTable ds = new DataTable();
                adp.Fill(ds);
                GlobalVariable._user_data = ds;
            }
        }
        public static void fn_login_admin(string username,string password)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select [dbo].[fn_login_admin](@u,@p);", con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                
                GlobalVariable._role = int.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
            }
            catch(Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_doctor : " + t.Message);
            }

        }
        public static void spd_insert_patient_md(DataGridView dgv)
        {
            //TableStructure
            //pat_id | md_id | md_name | md_description | md_status
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[spd_insert_patientMd]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@tempMd";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_patient_diagnose : " + t.Message);
            }
        }

        public static void spd_insert_tp(DataGridView dgv)
        {
            //TableStructure
            //pat_id | [tp_date] | [sd_id] | [charge_amount] | [discount_amount] | [total_amount] | [doc_name] | [paid_status]
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[spd_insert_tp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@tempTp";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_tp : " + t.Message);
            }
        }
        public static void spd_update_patientByID(int pat_id, string pat_kh_fname, string pat_kh_lname, string pat_fname, string pat_lname, string pat_gender, string pat_birthyear, string pat_job, string pat_address, byte[] pat_image, string pat_app_date, string pat_nation, string pat_tel,string pat_app_time)
        {
            //@pat_id int,
            //@pat_kh_fname NVARCHAR(MAX),
            //@pat_kh_lname NVARCHAR(MAX),
            //@pat_fname NVARCHAR(MAX),
            //@pat_lname NVARCHAR(MAX),
            //@pat_gender NVARCHAR(10),
            //@pat_birthyear NVARCHAR(MAX),
            //@pat_job NVARCHAR(MAX),
            //@pat_address NVARCHAR(MAX),
            //@pat_image IMAGE,
            //@pat_app_date date,
            //@pat_nation nvarchar(max),
            //@pat_tel nvarchar(max)
            //@pat_app_time nvarchar(max)
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_update_patientByID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@pat_kh_fname", pat_kh_fname);
            cmd.Parameters.AddWithValue("@pat_kh_lname", pat_kh_lname);
            cmd.Parameters.AddWithValue("@pat_fname", pat_fname);
            cmd.Parameters.AddWithValue("@pat_lname", pat_lname);
            cmd.Parameters.AddWithValue("@pat_gender", pat_gender);
            cmd.Parameters.AddWithValue("@pat_birthyear", pat_birthyear);
            cmd.Parameters.AddWithValue("@pat_job", pat_job);
            cmd.Parameters.AddWithValue("@pat_address", pat_address);
            cmd.Parameters.AddWithValue("@pat_image", pat_image);
            cmd.Parameters.AddWithValue("@pat_app_date", pat_app_date);
            cmd.Parameters.AddWithValue("@pat_nation", pat_nation);
            cmd.Parameters.AddWithValue("@pat_tel", pat_tel);
            cmd.Parameters.AddWithValue("@pat_app_time", pat_app_time);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void spd_update_mdHistoryByPatID(int pat_id,int md_id,string md_status)
        {
            //@pat_id int,
            //@md_id int,
            //@md_status nvarchar(10)

            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_update_mdHistoryByPatID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@md_id", md_id);
            cmd.Parameters.AddWithValue("@md_status", md_status);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void spd_insert_patDoc (int pat_id, string patDoc_code, int pat_id_length)
        {
            //@patDoc_code nvarchar(max),
            //@pat_id int
            //@pat_id_length
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_insert_patDoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@patDoc_code", patDoc_code);
            cmd.Parameters.AddWithValue("@pat_id_length", pat_id_length);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static int GetlastID()
        {
            try
            {
                int val;
                con = new SqlConnection(connectionString);
                con.Open();
                string strCmd = "select  max(pat_id) as LastID from tblPatient";
                SqlCommand cmd = new SqlCommand(strCmd, con);
                object objValue = cmd.ExecuteScalar();
                if (objValue.Equals(DBNull.Value)) { val = 0; } else { val = (int)cmd.ExecuteScalar(); }
                con.Close();
                return val;
            }
            catch (Exception t )
            {           
                GlobalMethod.HandleException("StoreProcedure / spd_insert_tp : " + t.Message);
                throw;
            }

        }
        //product
        public  static void spd_insert_product( String productname,decimal productprice,String productunit,int cat_id)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_insert_product", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@productprice", productprice);
            cmd.Parameters.AddWithValue("@productunit", productunit);
            cmd.Parameters.AddWithValue("@catid", cat_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
