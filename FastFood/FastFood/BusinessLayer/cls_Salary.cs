﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FastFood.BusinessLayer
{
    class cls_Salary
    {
        public static DataTable _getChucDanh()
        {
            string query = "SELECT * FROM tbl_ChucDanh";
            return cls_Database.TableRead(query);
        }

        public static bool _insertChucDanh(string tenChucDanh, string tienLuong, string phuCap)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_ChucDanh(TenChucDanh, TienLuong, PhuCap) VALUES (N'{0}', {1}, {2})", tenChucDanh, tienLuong, phuCap);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _updateChucDanh(string tenChucDanh, string tienLuong, string phuCap, int chucDanhID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ChucDanh SET TenChucDanh = N'{0}', TienLuong = {1}, PhuCap = {2} WHERE ChucDanhID = {3}", tenChucDanh, tienLuong, phuCap, chucDanhID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _checkChucDanh(int chucDanhID)
        {
            string query = string.Format("SELECT ChucDanhID FROM tbl_NhanVienChucDanh WHERE ChucDanhID = {0}", chucDanhID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static bool _delChucDanh(int chucDanhID)
        {
            try
            {
                string query = string.Format("DELETE tbl_ChucDanh WHERE ChucDanhID = {0}", chucDanhID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _getChamCong(string thang)
        {
            try
            {
                string firstQuery = string.Format(@"select * from tbl_ChamCong where Thang ='{0}'", thang);
                var data = cls_Database.TableRead(firstQuery);
                if (data.Rows.Count == 0)
                {
                    string query = string.Format(@"select b.NhanVienID,b.MaNV,b.TenNV,a.ChamCongID,a.NgayCongChuan,a.NgayDiLam,a.NgayNghi,a.NgayTinhLuong,a.GhiChu,a.TrangThai,a.Thang
from (select * from tbl_ChamCong where Thang = '{0}') a right outer join tbl_NhanVien b on a.NhanVienID = b.NhanVienID", thang);
                    return cls_Database.TableRead(query);

                }
                else
                {
                    string query = string.Format(@"select b.NhanVienID,b.MaNV,b.TenNV,a.ChamCongID,a.NgayCongChuan,a.NgayDiLam,a.NgayNghi,a.NgayTinhLuong,a.GhiChu,a.TrangThai,a.Thang
    from tbl_ChamCong a right join tbl_NhanVien b on a.NhanVienID = b.NhanVienID where a.Thang ='{0}'",thang);
                    return cls_Database.TableRead(query);

                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static bool _insertChamCong(string Thang, int NgayCongChuan, int NhanVienID, int NgayDiLam, int NgayNghi, int NgayTinhLuong, string GhiChu)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_ChamCong(Thang, NgayCongChuan, NhanVienID, NgayDiLam, NgayNghi, NgayTinhLuong, GhiChu, TrangThai) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', N'{6}', 1)", Thang, NgayCongChuan, NhanVienID, NgayDiLam, NgayNghi, NgayTinhLuong, GhiChu);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _updateChamCong(string Thang, int NgayCongChuan, int NhanVienID, int NgayDiLam, int NgayNghi, int NgayTinhLuong, string GhiChu, string ChamCongID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ChamCong SET Thang = '{0}', NgayCongChuan = '{1}', NhanVienID = '{2}', NgayDiLam = '{3}', NgayNghi = '{4}', NgayTinhLuong = '{5}', GhiChu = N'{6}' WHERE ChamCongID = '{7}'", Thang, NgayCongChuan, NhanVienID, NgayDiLam, NgayNghi, NgayTinhLuong, GhiChu, ChamCongID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _updateTrangThai(string ChamCongID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ChamCong SET TrangThai = 2 WHERE ChamCongID = '{0}'", ChamCongID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _insertChiTietLuong(string ThangKeLuong, int NhanVienID, int NgayCongChuan, int NgayTinhLuong)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_ChiTietBanKeLuong(ThangKeLuong, NhanVienID, TienLuongCung, NgayCongChuan, NgayTinhLuong, PhuCap, TongLuong, ThucLinh, TrangThai) VALUES ('{0}', '{1}', NULL, '{2}', '{3}', NULL, NULL, NULL, 1)", ThangKeLuong, NhanVienID, NgayCongChuan, NgayTinhLuong);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable _getChiTietBanKeLuong(string thang)
        {
            try
            {
                string query = string.Format(@"SELECT d.ChiTietBanKeLuongID,a.NhanVienID, a.MaNV, a.TenNV, d.NgayCongChuan,  d.NgayTinhLuong, c.TienLuong, c.PhuCap*c.TienLuong/100 as[PhuCap],
                                                c.TienLuong * (ROUND((CONVERT(float, d.NgayTinhLuong)/CONVERT(float, d.NgayCongChuan)),2)) as [TongLuong],
                                                c.TienLuong * (ROUND((CONVERT(float, d.NgayTinhLuong)/CONVERT(float, d.NgayCongChuan)),2)) + c.PhuCap*c.TienLuong/100 as [ThucLinh], d.TrangThai
                                                FROM tbl_NhanVien a
                                                INNER JOIN tbl_NhanVienChucDanh b ON a.NhanVienID = b.NhanVienID
                                                INNER JOIN tbl_ChucDanh c ON c.ChucDanhID = b.ChucDanhID
                                                LEFT JOIN tbl_ChiTietBanKeLuong d ON d.NhanVienID = a.NhanVienID AND d.ThangKeLuong = '{0}'", thang);
                return cls_Database.TableRead(query);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static bool _updateChiTietBanKeLuong(decimal TienLuongCung, decimal PhuCap, decimal TongLuong, decimal ThucLinh, string ID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ChiTietBanKeLuong SET TienLuongCung = '{0}', PhuCap = '{1}', TongLuong = '{2}', ThucLinh = '{3}' WHERE ChiTietBanKeLuongID = '{4}'", TienLuongCung, PhuCap, TongLuong, ThucLinh, ID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _updateTrangThaiBanKeLuong(string chiTietBanKeLuongID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_ChiTietBanKeLuong SET TrangThai = 2 WHERE ChiTietBanKeLuongID = '{0}'", chiTietBanKeLuongID);
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
