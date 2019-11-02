using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
