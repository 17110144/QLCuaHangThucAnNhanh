using FastFood.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.Forms
{
    public partial class frm_UserPermission : Form
    {
        cls_Employess employess = new cls_Employess();
        public frm_UserPermission()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_UserPermission_Load(object sender, EventArgs e)
        {
            DataTable dt = employess.GetAllUserName();
            cmbNguoiDung.ValueMember = "NguoiDungID";
            cmbNguoiDung.DisplayMember = "TenDangNhap";
            cmbNguoiDung.DataSource = dt;

            DataTable dt2 = employess.GetAllEmpName();
            cmbNhanVien.ValueMember = "NguoiDungID";
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.DataSource = dt2;
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = employess.GetUserByID(Convert.ToInt32(cmbNhanVien.SelectedValue));
            cmbNguoiDung.ValueMember = "NguoiDungID";
            cmbNguoiDung.DisplayMember = "TenDangNhap";
            cmbNguoiDung.DataSource = dt;
        }

        private void cmbNguoiDung_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbHeThong.Checked = false;
            cbNhanSu.Checked = false;
            cbTienLuong.Checked = false;
            cbSanPham.Checked = false;
            cbGoiMon.Checked = false;
            cbDanhMuc.Checked = false;
            DataTable nghiepVu = employess.GetNghiepVu(Convert.ToInt32(cmbNguoiDung.SelectedValue));
            for (int i = 0; i < nghiepVu.Rows.Count; i++)
            {
                switch (nghiepVu.Rows[i].ItemArray[0].ToString())
                {
                    case "1":
                        cbHeThong.Checked = true;
                        break;
                    case "2":
                        cbNhanSu.Checked = true;
                        break;
                    case "3":
                        cbTienLuong.Checked = true;
                        break;
                    case "4":
                        break;
                    case "5":
                        cbSanPham.Checked = true;
                        break;
                    case "6":
                        cbGoiMon.Checked = true;
                        break;
                    case "7":
                        cbDanhMuc.Checked = true;
                        break;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (cmbNguoiDung.SelectedValue == null)
            {
                MessageBox.Show("Nhân viên này chưa có tài khoản. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool delPermission = employess.DelPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue));
            if (!delPermission)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbHeThong.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbHeThong.AccessibleDescription));
            }
            if (cbDanhMuc.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbDanhMuc.AccessibleDescription));
            }
            if (cbNhanSu.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbNhanSu.AccessibleDescription));
            }
            if (cbTienLuong.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbTienLuong.AccessibleDescription));
            }
            if (cbSanPham.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbSanPham.AccessibleDescription));
            }
            if (cbGoiMon.Checked == true)
            {
                employess.InsertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbGoiMon.AccessibleDescription));
            }
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
