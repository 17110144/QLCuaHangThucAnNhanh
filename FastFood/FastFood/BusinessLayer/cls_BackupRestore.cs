using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLayer
{
    class cls_BackupRestore
    {
        public static bool _backupDatabase(string path)
        {
            try
            {
                string query = string.Format("backup database KFC_FASTFOOD to disk = '{0}'", path);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _restoreDatabase(string path)
        {
            try
            {
                string query = string.Format(@"
                                            ALTER DATABASE KFC_FASTFOOD SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                                            USE master restore database KFC_FASTFOOD from disk = '{0}' WITH  REPLACE
                                            ALTER DATABASE KFC_FASTFOOD SET MULTI_USER
                                            ", path);

                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string[] _getInfoStore()
        {
            string[] info = new string[3];
            string query = "SELECT StoreID, CuaHang, DiaChiCH FROM tbl_ThongTinCH";
            DataTable dt = cls_Database.TableRead(query);
            info[0] = dt.Rows[0]["StoreID"].ToString();
            info[1] = dt.Rows[0]["CuaHang"].ToString();
            info[2] = dt.Rows[0]["DiaChiCH"].ToString();
            return info;
        }
        public static bool _delInforStore(int storeID)
        {
            try
            {
                string query = string.Format("DELETE tbl_ThongTinCH WHERE StoreID = {0}", storeID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _insertInfoStore(string cuaHang, string diaChi, int storeID, int storeID_old)
        {
            try
            {
                if (!_delInforStore(storeID_old))
                {
                    return false;
                }
                string query = string.Format("INSERT INTO tbl_ThongTinCH(StoreID, CuaHang, DiaChiCH) VALUES ({0}, N'{1}', N'{2}')", storeID, cuaHang, diaChi);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _updateInfoStore(string cuaHang, string diaChi, int storeID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ThongTinCH SET CuaHang = N'{0}', DiaChiCH = N'{1}' WHERE StoreID = {2}", cuaHang, diaChi, storeID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
