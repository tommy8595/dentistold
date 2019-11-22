using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dentist
{
    class GlobalVariable
    {
        private static string LowImagePath = "";

        public static string _LowImagePath
        {
            get { return LowImagePath; }
            set { LowImagePath = value; }
        }
        private static string DefaultImgPath = "";

        public static string _DefaultImgPath
        {
            get { return DefaultImgPath; }
            set { DefaultImgPath = value; }
        }
        private static string Patient_id = "";

        public static string _Patient_id
        {
            get { return Patient_id; }
            set { Patient_id = value; }
        }
        private static int role = 0;
        public static int _role
        {
            get { return role; }
            set { role = value; }
        }
        private static DataTable user_data;
        public static DataTable _user_data
        {
            get { return user_data; }
            set {   user_data = value; }
        }
        public static int _user_id
        {
            get
            {
                if(_user_data.Rows.Count>0)
                    return int.Parse(_user_data.Rows[0]["emp_id"].ToString());
                return 0 ;
            }
        }
        public static string _user_name
        {
            get
            {
                if (_user_data.Rows.Count > 0)
                    return _user_data.Rows[0]["emp_name"].ToString();
                return "";
            }


        }
        public static string _user_user_name
        {
            get
            {
                if (_user_data.Rows.Count > 0)
                    return _user_data.Rows[0]["emp_username"].ToString();
                return "";
            }
        }
        public static string _user_role
        {
            
            get
            {
                if (_user_data.Rows.Count > 0)
                    return _user_data.Rows[0]["emp_role"].ToString();
                return "";
            }
        }

        public static  bool _isMSB;

        public bool isMSB
        {
            get { return _isMSB; }
            set { _isMSB = value; }
        }

    }
}
