using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFood.BusinessLayer
{
    class cls_Employess
    {
        public string CheckLogin(string username, string password)
        {
            string NguoiDungID = null;
            string query = string.Format("SELECT NguoiDungID FROM tbl_NguoiDung WHERE TenDangNhap = '{0}' and MatKhau = '{1}'", username, password);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                NguoiDungID = dt.Rows[0]["NguoiDungID"].ToString();
                return NguoiDungID;
            }

            return "ERROR";
        }

        public bool CheckPermission(string id)
        {
            string query = string.Format("SELECT QuanTri FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows[0]["QuanTri"].ToString() == "0" || dt.Rows[0]["QuanTri"].ToString().ToLower() == "false")
            {
                return false;
            }
            return true;
        }

        public DataTable ListPermission(string id)
        {
            string query = string.Format("SELECT a.NguoiDungID, a.NghiepVuID, b.URL FROM tbl_QuyenNguoiDung a JOIN tbl_NghiepVu b ON b.NghiepVuID = a.NghiepVuID WHERE NguoiDungID = '{0}'", id);
            return cls_Database.TableRead(query);
        }

        public string[] GetInfoEmployess(string id)
        {
            string[] info = new string[2];
            string query = string.Format("SELECT a.NhanVienID, a.TenNV FROM tbl_NhanVien a JOIN tbl_NguoiDung b ON b.NhanVienID = a.NhanVienID WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            info[0] = dt.Rows[0]["NhanVienID"].ToString();
            info[1] = dt.Rows[0]["TenNV"].ToString();
            return info;
        }

        public DataTable GetGender()
        {
            string query = "SELECT * FROM tblGioiTinh";
            return cls_Database.TableRead(query);
        }

        public DataTable ShowEmployess()
        {
            string query = "SELECT * from tbl_NhanVien";
            return cls_Database.TableRead(query);
        }
        public DataTable SearchEmployess(string name, string tbl)
        {
            string query = string.Format("SELECT  a.NhanVienID, a.MaNV, a.TenNV, a.NgaySinh , a.CMND, a.DiaChi , a.Email , a.SDT, b.GioiTinh, a.TrangThaiID FROM tbl_NhanVien a inner join tblGioiTinh b on a.GioiTinhID = b.GioiTinhID  WHERE a.{0} LIKE N'{1}%' OR a.{0} LIKE N'%{1}%' OR  a.{0} LIKE N'%{1}'", tbl, name);
            return cls_Database.TableRead(query);
        }
        public bool AddEmployess(string maNV, string tenNV, string ngaySinh, int gioiTinhID, string diaChi, string sdt, string email, string cmnd, int trangthaiID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, SDT, Email, CMND, TrangThaiID) VALUES ('{0}', N'{1}', '{2}', {3}, N'{4}', '{5}', '{6}', '{7}', {8})", maNV, tenNV, ngaySinh, gioiTinhID, diaChi, sdt, email, cmnd, trangthaiID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable GetAllUserName()
        {
            string query = string.Format(@"SELECT a.NguoiDungID, a.TenDangNhap 
                                        FROM tbl_NguoiDung a 
                                        INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID");
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable GetAllEmpName()
        {
            string query = string.Format(@"SELECT a.NguoiDungID, b.TenNV 
                                        FROM tbl_NguoiDung a 
                                        INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID");
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public DataTable GetUserPermission()
        {
            string query = @"SELECT a.NguoiDungID, b.NhanVienID,  b.MaNV, b.TenNV, a.TenDangNhap, a.MatKhau, a.QuanTri 
                            FROM tbl_NguoiDung a
                            INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID";
            return cls_Database.TableRead(query);
        }

        public DataTable GetUserByID(int NhanVienID)
        {
            string query = string.Format(@"SELECT a.NguoiDungID, a.TenDangNhap 
                                        FROM tbl_NguoiDung a 
                                        INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID and b.NhanVienID = {0}", NhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public bool DelEmployess(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVien WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckInHoSoNhanVien(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_HoSoNhanVien WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckInNhanVienBoPhan(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NhanVienBoPhan WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool CheckInNhanVienChucDanh(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool CheckInNguoiDung(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NguoiDung WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool CheckInHoaDon(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_HoaDon WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public DataTable GetIDEmployess()
        {
            string query = "SELECT MaNV FROM tbl_NhanVien";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public bool UpdateEmployess(int nhavienID, string maNV, string tenNV, string ngaySinh, int gioiTinhID, string diaChi, string sdt, string email, string cmnd, int trangthaiID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVien SET MaNV = '{0}', TenNV = N'{1}', NgaySinh = '{2}', GioiTinh = {3}, DiaChi = N'{4}', SDT = '{5}', Email = '{6}', CMND = '{7}', TrangThaiID = {8} WHERE NhanVienID = {9}", maNV, tenNV, ngaySinh, gioiTinhID, diaChi, sdt, email, cmnd, trangthaiID, nhavienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable GetProfileName()
        {
            string query = "SELECT NhanVienID, TenNV FROM tbl_NhanVien";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable GetProfileNation()
        {
            string query = "SELECT * FROM tbl_DanToc";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable GetProfileCity()
        {
            string query = "SELECT * FROM tbl_TinhThanh";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable GetProfileReligion()
        {
            string query = "SELECT * FROM tbl_TonGiao";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable GetProfileDiploma()
        {
            string query = "SELECT * FROM tbl_BangCap";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public DataTable ShowProfileInfo()
        {
            string query = @"SELECT b.NhanVienID, b.TenNV, a.NgayVaoLam,  c.TenDanToc, c.DanTocID, d.TenTonGiao, d.TonGiaoID, f.TenTinhThanh, f.TinhThanhID, e.TenBangCap, e.BangCapID, a.GhiChu, a.ImagePath
                                FROM tbl_HoSoNhanVien a 
                                INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID
                                INNER JOIN tbl_DanToc c ON a.DanTocID = c.DanTocID
                                INNER JOIN tbl_TonGiao d ON a.TonGiaoID = d.TonGiaoID
                                INNER JOIN tbl_BangCap e ON a.BangCapID = e.BangCapID
                                INNER JOIN tbl_TinhThanh f ON a.TinhThanhID = f.TinhThanhID";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public bool AddProfile(int nhanvienID, string ngayVaoLam, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID, string ghiChu, string path)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_HoSoNhanVien(NhanVienID, NgayVaoLam, DanTocID, TonGiaoID, TinhThanhID, BangCapID, GhiChu, ImagePath) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, N'{6}', '{7}')", nhanvienID, ngayVaoLam, danTocID, tonGiaoID, tinhThanhID, bangCapID, ghiChu, path);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckProfile(int nhanVienID)
        {
            string query = string.Format("SELECT * FROM tbl_HoSoNhanVien WHERE NhanVienID = {0}", nhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool UpdateProfile(int nhanvienID, string ngayVaoLam, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID, string ghiChu, string path)
        {
            try
            {
                string query = string.Format("UPDATE tbl_HoSoNhanVien SET NgayVaoLam = '{0}', DanTocID = {1}, TonGiaoID = {2}, TinhThanhID = {3}, BangCapID = {4}, GhiChu = N'{5}', ImagePath = '{6}' WHERE NhanVienID = '{7}'", ngayVaoLam, danTocID, tonGiaoID, tinhThanhID, bangCapID, ghiChu, path, nhanvienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelProfile(int nhanvienID, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID)
        {
            try
            {
                string query = string.Format("DELETE tbl_HoSoNhanVien WHERE NhanVienID = {0} AND DanTocID = {1} AND TonGiaoID = {2} AND TinhThanhID = {3} AND BangCapID = {4}", nhanvienID, danTocID, tonGiaoID, tinhThanhID, bangCapID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public datatable Getdeparment()
        //{
        //    string query = "select * from tbl_bophan";
        //    datatable dt = cls_database.tableread(query);
        //    return dt;
        //}
        public DataTable GetOffice()
        {
            string query = "SELECT * FROM tbl_ChucDanh";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public DataTable GetInfoNhanVienBoPhan()
        {
            string query = @"SELECT  a.NhanVienID, a.BoPhanID , b.TenNV, c.TenBoPhan
                            FROM((tbl_NhanVienBoPhan a inner join tbl_NhanVien b ON a.NhanVienID = b.NhanVienID) 
                            inner join tbl_BoPhan c ON a.BoPhanID = c.BoPhanID)";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public int InsertNhanVienBoPhan(int nhanVienID, int boPhanID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVienBoPhan(NhanVienID, BoPhanID) VALUES ({0},{1})", nhanVienID, boPhanID);
                cls_Database.AED(query);
                return 1;
            }
            catch (SqlException ex)
            {
                return ex.Number;
            }
        }

        public bool UpdateNhanVienBoPhan(int nhanVienID, int boPhanID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVienBoPhan SET BoPhanID = {0} WHERE NhanVienID = {1}", boPhanID, nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable GetNhanVienChucDanh()
        {
            string query = @"SELECT tbl_NhanVien.NhanVienID, TenNV, tbl_ChucDanh.ChucDanhID, TenChucDanh from tbl_NhanVien, tbl_ChucDanh, tbl_NhanVienChucDanh where tbl_NhanVien.NhanVienID = tbl_NhanVienChucDanh.NhanVienID
																and tbl_NhanVienChucDanh.ChucDanhID = tbl_ChucDanh.ChucDanhID";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public DataTable GetNhanVienBoPhanID(int boPhanID)
        {
            string query = string.Format("SELECT a.NhanVienID, a.TenNV FROM tbl_NhanVien a INNER JOIN tbl_NhanVienBoPhan b ON a.NhanVienID = b.NhanVienID and b.BoPhanID = {0}", boPhanID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public bool InsertNhanVienChucDanh(int nhanVienID, int chucDanhID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVienChucDanh (NhanVienID, ChucDanhID) VALUES ({0}, {1})", nhanVienID, chucDanhID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateNhanVienChucDanh(int nhanVienID, int chucDanhID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVienChucDanh SET ChucDanhID = {0} WHERE NhanVienID = {1}", chucDanhID, nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteNhanVienChucDanh(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckNhanVienChucDanh(int nhanVienID)
        {
            string query = string.Format("SELECT * FROM tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool DelNhanVienBoPhan(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVienBoPhan WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable GetProfileEmployess(int nhanVienID)
        {
            string query = string.Format(@"SELECT a.TenNV, a.DiaChi, a.Email, a.MaNV, a.NgaySinh, a.SDT, b.ImagePath, a.CMND, b.NgayVaoLam, c.TenDanToc, d.TenBangCap,  e.TenTinhThanh, f.TenTonGiao, g.GioiTinh 
                                            FROM tbl_NhanVien a 
                                            INNER JOIN tbl_HoSoNhanVien b on a.NhanVienID = b.NhanVienID
                                            INNER JOIN tbl_DanToc c on b.DanTocID = c.DanTocID
                                            INNER JOIN tbl_BangCap d on b.BangCapID = d.BangCapID
                                            INNER JOIN tbl_TinhThanh e on b.TinhThanhID = e.TinhThanhID
                                            INNER JOIN tbl_TonGiao f on b.TonGiaoID = f.TonGiaoID
                                            INNER JOIN tblGioiTinh g on g.GioiTinhID = a.GioiTinhID
                                            WHERE a.NhanVienID = '{0}'", nhanVienID);
            return cls_Database.TableRead(query);
        }

        public bool CheckPassword(string password, string id)
        {
            string query = string.Format("SELECT MatKhau FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            string pass = dt.Rows[0]["MatKhau"].ToString();
            if (pass != password)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePassword(string password, string id)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NguoiDung SET MatKhau = '{0}' WHERE NguoiDungID = '{1}'", password, id);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DelUserPermission(int NguoiDungID)
        {
            try
            {
                if (DelPermission(NguoiDungID))
                {
                    string query = string.Format("DELETE FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", NguoiDungID);
                    cls_Database.AED(query);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelPermission(int NguoiDungID)
        {
            try
            {
                string query = string.Format("DELETE FROM tbl_QuyenNguoiDung WHERE NguoiDungID = '{0}'", NguoiDungID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertUserPermission(string TenDangNhap, string MatKhau, int QuanTri, int NhanVienID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NguoiDung(TenDangNhap, MatKhau, QuanTri, NhanVienID) VAlUES (N'{0}', '{1}', {2}, '{3}')", TenDangNhap, MatKhau, QuanTri, NhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckNameUser(string name)
        {
            string query = string.Format("SELECT TenDangNhap FROM tbl_NguoiDung WHERE TenDangNhap = N'{0}'", name);
            DataTable dt = BusinessLayer.cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool CheckUserPermission(int NhanVienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NguoiDung WHERE NhanVienID = '{0}'", NhanVienID);
            DataTable dt = BusinessLayer.cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool UpdateUserPermission(string TenDangNhap, string MatKhau, int QuanTri, int NhanVienID, int NguoiDungID)
        {
            try
            {
                string query = "";
                if (MatKhau == "")
                {
                    query = string.Format("UPDATE tbl_NguoiDung SET TenDangNhap = N'{0}', QuanTri = {1}, NhanVienID = {2} WHERE NguoiDungID = {3}", TenDangNhap, QuanTri, NhanVienID, NguoiDungID);

                }
                else
                {
                    query = string.Format("UPDATE tbl_NguoiDung SET TenDangNhap = N'{0}', MatKhau = '{1}', QuanTri = {2}, NhanVienID = {3} WHERE NguoiDungID = {4}", TenDangNhap, MatKhau, QuanTri, NhanVienID, NguoiDungID);
                }
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetUserPermission(int NhanVienID)
        {
            string query = string.Format(@"SELECT a.NguoiDungID, a.TenDangNhap 
                                        FROM tbl_NguoiDung a 
                                        INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID and b.NhanVienID = {0}", NhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public DataTable GetNghiepVu(int NguoiDungID)
        {
            string query = string.Format("SELECT NghiepVuID FROM tbl_QuyenNguoiDung WHERE NguoiDungID = {0}", NguoiDungID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public bool InsertPermission(int NguoiDungID, int Permission)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_QuyenNguoiDung(NguoiDungID, NghiepVuID) VALUES ({0}, {1})", NguoiDungID, Permission);
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
