using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace FastFood.BusinessLayer
{
    class cls_TestConnectDB
    {
        public static bool _testConnect()
        {
            SqlConnection conn = new SqlConnection(File.ReadAllText("config.env"));
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
