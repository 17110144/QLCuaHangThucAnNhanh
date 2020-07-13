using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.Forms;
using FastFood.BusinessLayer;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_TimeSheetManager : UserControl
    {
        cls_Salary salary = new cls_Salary();
        public UC_TimeSheetManager()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_Main.Instance.pnlContainer.Controls["UC_Salary"].BringToFront();
        }
        private void _format()
        {
            dtList.Columns[0].Width = 60;
            dtList.Columns[1].Width = 210;
        }
        private void UC_TimeSheetManager_Load(object sender, EventArgs e)
        {
            _format();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

            if (salary.GetChamCong(dtpThang.Value.ToString("yyyyMM")) != null)
            {
                dtList.DataSource = salary.GetChamCong(dtpThang.Value.ToString("yyyyMM"));
            }
            else
            {
                MessageBox.Show("Lỗi hiển thị. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int flag = 0;

            foreach (DataGridViewRow row in dtList.Rows)
            {
                if (row != null)
                {
                    string ChamCongID = row.Cells["ChamCongID"].Value.ToString();
                    int NhanVienID = Convert.ToInt32(row.Cells["NhanVienID"].Value);
                    int NgayCongChuan = row.Cells["NgayCongChuan"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayCongChuan"].Value);
                    int NgayDiLam = row.Cells["NgayDiLam"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayDiLam"].Value);
                    int NgayNghi = row.Cells["NgayNghi"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayNghi"].Value);
                    int NgayTinhLuong = row.Cells["NgayTinhLuong"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayTinhLuong"].Value);
                    string GhiChu = row.Cells["GhiChu"].Value.ToString();
                    string TrangThai = row.Cells["TrangThai"].Value.ToString();

                    if (ChamCongID == "")
                    {
                        bool InsertChamCong = salary.InsertChamCong(dtpThang.Value.ToString("yyyyMM"), NgayCongChuan, NhanVienID, NgayDiLam, NgayNghi, NgayTinhLuong, GhiChu);
                        if (InsertChamCong)
                        {
                            flag++;
                        }
                    }
                    else
                    {
                        if (TrangThai == "1")
                        {
                            bool UpdateChamCong = salary.UpdateChamCong(dtpThang.Value.ToString("yyyyMM"), NgayCongChuan, NhanVienID, NgayDiLam, NgayNghi, NgayTinhLuong, GhiChu, ChamCongID);
                            if (UpdateChamCong)
                            {
                                flag++;
                            }
                        }
                    }
                }
            }

            btnHienThi_Click(sender, e);
            if (flag == 0)
            {
                MessageBox.Show("Không có bản ghi nào thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu " + flag + " bản ghi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn nộp bản chấm công này không. Nếu nộp bạn sẽ không thể thay đổi dữ liệu chấm công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int flag = 0;
                foreach (DataGridViewRow row in dtList.Rows)
                {
                    if (row != null)
                    {
                        if (row.Cells["TrangThai"].Value.ToString() == "1")
                        {
                            string ChamCongID = row.Cells["ChamCongID"].Value.ToString();
                            if (!salary.UpdateTrangThai(ChamCongID)) return;

                            string ThangKeLuong = row.Cells["Thang"].Value.ToString();
                            int NhanVienID = Convert.ToInt32(row.Cells["NhanVienID"].Value);
                            int NgayCongChuan = Convert.ToInt32(row.Cells["NgayCongChuan"].Value);
                            int NgayTinhLuong = Convert.ToInt32(row.Cells["NgayTinhLuong"].Value);

                            bool InsertChiTietLuong = salary.InsertChiTietLuong(ThangKeLuong, NhanVienID, NgayCongChuan, NgayTinhLuong);
                            if (InsertChiTietLuong)
                            {
                                flag++;
                            }
                        }
                    }
                }
                btnHienThi_Click(sender, e);
                if (flag == 0)
                {
                    MessageBox.Show("Không có bản ghi nào được nộp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nộp " + flag + " bản ghi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtList.Columns[e.ColumnIndex].Name.Equals("TrangThai"))
            {
                int? stt = e.Value as int?;

                if (stt == 1)
                {
                    e.Value = "Chưa nộp";
                }
                else if (stt == 2)
                {
                    e.Value = "Đã nộp";
                }
                else
                {
                    e.Value = "Unknown";
                }
            }
        }
    }
}
