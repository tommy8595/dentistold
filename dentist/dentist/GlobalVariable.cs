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
            get { return int.Parse(_user_data.Rows[0]["emp_id"].ToString()); }
        }
        public static string _user_name
        {
            get { return _user_data.Rows[0]["emp_name"].ToString(); }
        }
        public static string _user_user_name
        {
            get { return _user_data.Rows[0]["emp_username"].ToString(); }
        }
        public static string _user_role
        {
            get { return _user_data.Rows[0]["emp_role"].ToString(); }
        }

        public static  bool _isMSB;

        public bool isMSB
        {
            get { return _isMSB; }
            set { _isMSB = value; }
        }

    }
}
