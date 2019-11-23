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


        public static void spd_insert_patient(string pat_kh_fname, string pat_kh_lname, string pat_fname, string pat_lname, string pat_gender, string pat_birthyear, string pat_job, string pat_address, byte[] pat_image, string pat_app_date, string pat_nation, string pat_tel, string pat_app_time)
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
        public static void sp_insert_expense(string detail,string name,float price)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("dbo.sp_insert_expense", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@detail", detail);
                cmd.Parameters.AddWithValue("@amount",price);
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@user",GlobalVariable._user_name);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch(Exception t)
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
        //public static IDataReader get_expense(string period)
        //{

        //}'
        public static int fn_get_stock_max()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select 1+max(stock_id) from tbl_stock",con);
            int max = (int)cmd.ExecuteScalar();
            con.Close();
            return max;
        }
        public static void sp_insert_product(DataTable dt,string time)
        {
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert_stock", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@imp_date", time);
                    SqlParameter param = new SqlParameter();
                    //SqlParameter param = new SqlParameter("@sto", SqlDbType.Structured)
                    //{
                    //    TypeName = "dbo.stock",
                    //    Value = dt
                    //};
                    param.ParameterName = "@sto";
                    param.SqlDbType = SqlDbType.Structured;
                    param.Value = dt;
                    cmd.Parameters.Add(param);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }catch(Exception e)
            {
                GlobalMethod.HandleException("StoreProcedure / insert_stock : " + e.Message);
            }
        }
        public static void fun_get_pro_cat(string cat)
        {
            try
            {
                
            }catch(SqlException e)
            {
                GlobalMethod.HandleException("StoreProcedure / insert_stock : " + e.Message);
            }
        }
        public static DataTable get_pro_detail(string name)
        {
            try
            {
                DataTable dt = new DataTable();
                using (con = new SqlConnection(connectionString))
                {
                    SqlCommand cdm = new SqlCommand("select top 1* from tbl_product where pro_name like'"+name+"' +'%'", con);
                    SqlDataAdapter adp = new SqlDataAdapter(cdm);
                    adp.Fill(dt);
                }
                return dt;
            }
            catch (SqlException e)
            {
                
                GlobalMethod.HandleException("StoreProcedure / insert_stock : " + e.Message);
                return null;
            }
        }
        public static void update_notification(int stock_id)
        {
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    SqlCommand cdm = new SqlCommand("update tbl_stock set alerted=1 where stock_id=" + stock_id, con);
                    con.Open();
                    cdm.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                GlobalMethod.HandleException("update_notification: " + e.Message);

            }
        }
        
        public static DataTable get_pro_expire()
        {
            DataTable dt = new DataTable();
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    SqlCommand cdm = new SqlCommand("select stock_id,(select pro_name from tbl_product where st.pro_id=pro_id) as Name,location,stock_qty,expiredate from tbl_stock st "
                    + "where DATEDIFF(day, getdate(), expiredate) < 30 and expiredate > GETDATE()  and alerted is null", con);
                    SqlDataAdapter adp = new SqlDataAdapter(cdm);
                    adp.Fill(dt);
                }
                return dt;
            }
            catch (SqlException e)
            {
                GlobalMethod.HandleException("StoreProcedure / insert_stock : " + e.Message);
                return null;
            }
        }
        public static DataTable get_pro_detail_by_cat(int cat_id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (con = new SqlConnection(connectionString))
                {
                    SqlCommand cdm = new SqlCommand("select * from tbl_product where cat_id= "+cat_id+ " order by pro_name asc", con);
                    SqlDataAdapter adp = new SqlDataAdapter(cdm);
                    adp.Fill(dt);
                }
                return dt;
            }
            catch (SqlException e)
            {

                GlobalMethod.HandleException("StoreProcedure / insert_stock : " + e.Message);
                return null;
            }
        }
        public static void sp_login(string username, string password)
        {
            try
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
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / sp_login : " + t.Message);
            }
        }
        public static DataTable sp_get_expense(string peroid)
        {
            try
            {
                using (con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_expense", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peroid", peroid);
                    SqlDataAdapter rdr = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    rdr.Fill(dt);
                    return dt;

                }

            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("sp_get_expense : " + t.Message);
                return null;
            }
        }
        public static void fn_login_admin(string username, string password)
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
            catch (Exception t)
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
        public static void spd_update_patientByID(int pat_id, string pat_kh_fname, string pat_kh_lname, string pat_fname, string pat_lname, string pat_gender, string pat_birthyear, string pat_job, string pat_address, byte[] pat_image, string pat_app_date, string pat_nation, string pat_tel, string pat_app_time)
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
        public static void spd_update_mdHistoryByPatID(int pat_id, int md_id, string md_status, string md_description)
        {
            //@pat_id int,
            //@md_id int,
            //@md_status nvarchar(10)
            //@md_description nvarchar(max)

            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_update_mdHistoryByPatID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@md_id", md_id);
            cmd.Parameters.AddWithValue("@md_status", md_status);
            cmd.Parameters.AddWithValue("@md_description", md_description);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void spd_insert_patDoc(int pat_id, string patDoc_code, int pat_id_length)
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
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_tp : " + t.Message);
                throw;
            }

        }
        //product
        public static void spd_insert_product(string productname, decimal productprice, string productunit, int cat_id)
        {
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_insert_product", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@productprice", productprice);
            cmd.Parameters.AddWithValue("@prounit", productunit);
            cmd.Parameters.AddWithValue("@catid", cat_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
    
}
