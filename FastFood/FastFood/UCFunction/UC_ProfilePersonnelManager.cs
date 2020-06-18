using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;

namespace FastFood.UCFunction
{
    public partial class UC_ProfilePersonnelManager : UserControl
    {
        private string CurrentImagePath = "";
        private int rowSelected;
        private int check = 0;
        private int nhanvienID = 0;
        public UC_ProfilePersonnelManager()
        {
            InitializeComponent();
        }
        private void _reset()
        {

            cmbTenNV.SelectedIndex = -1;
            cmbDanToc.SelectedIndex = -1;
            cmbTinhThanh.SelectedIndex = -1;
            cmbTonGiao.SelectedIndex = -1;
            cmbBangCap.SelectedIndex = -1;
            txtGhiChu.Text = "";
            imgNV.Image = null;
            errorProvider.Clear();
        }
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpinfo)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpThongTin.Enabled = grpinfo;
        }
        private void _formatDT()
        {
            dtListProfile.Columns[1].Width = 200;
        }
        private Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void _loadImage(string path)
        {
            string AppPath = Application.StartupPath;
            string file = AppPath + path;
            if (File.Exists(file))
            {
                imgNV.Image = null;
                FileInfo fileInfo = new FileInfo(file);
                FileStream fileStream = fileInfo.OpenRead();
                imgNV.Image = resizeImage(Image.FromStream(fileStream), new Size(150, 200));
                fileStream.Close();
            }
        }
        /*
         * GetAll là hàm get child control trong C#
         * Sử dụng đệ quy để get theo type
         * Truyền vào 1 control và giá trị là txt
         * tham khảo tại stackoverflow
         */
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            //var tự động nhận biết kiểu dữ liệu trong scope
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, false, true, false, false, false);
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Personnel"].BringToFront();
        }

        private void UC_ProfilePersonnelManager_Load(object sender, EventArgs e)
        {
            /*
             * Gets or sets a value that indicates whether controls in this container will be automatically validated when the focus changes.
             * An AutoValidate enumerated value that indicates whether contained controls are implicitly validated on focus change. The default is Inherit.
             * Source: https://doc.microsoft.com
             */
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            DataTable dtTenNV = lib.cls_Employess._getProfileName();
            DataTable dtDanToc = lib.cls_Employess._getProfileNation();
            DataTable dtTonGiao = lib.cls_Employess._getProfileReligion();
            DataTable dtTinhThanh = lib.cls_Employess._getProfileCity();
            DataTable dtBangCap = lib.cls_Employess._getProfileDiploma();

            cmbTenNV.DataSource = dtTenNV;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";

            cmbDanToc.DataSource = dtDanToc;
            cmbDanToc.ValueMember = "DanTocID";
            cmbDanToc.DisplayMember = "TenDanToc";

            cmbTonGiao.DataSource = dtTonGiao;
            cmbTonGiao.ValueMember = "TonGiaoID";
            cmbTonGiao.DisplayMember = "TenTonGiao";

            cmbTinhThanh.DataSource = dtTinhThanh;
            cmbTinhThanh.ValueMember = "TinhThanhID";
            cmbTinhThanh.DisplayMember = "TenTinhThanh";

            cmbBangCap.DataSource = dtBangCap;
            cmbBangCap.ValueMember = "BangCapID";
            cmbBangCap.DisplayMember = "TenBangCap";

            _reset();
            _sttButton(true, false, true, false, false, false);
            _formatDT();
            dtListProfile.DataSource = lib.cls_Employess._showProfileInfo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanvienID == 0)
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool delProfile = lib.cls_Employess._delProfile(Convert.ToInt32(cmbTenNV.SelectedValue), Convert.ToInt32(cmbDanToc.SelectedValue), Convert.ToInt32(cmbTonGiao.SelectedValue), Convert.ToInt32(cmbTinhThanh.SelectedValue), Convert.ToInt32(cmbBangCap.SelectedValue));
                if (delProfile == true)
                {
                    MessageBox.Show("Xóa thành công hồ sơ nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reset();
                    _sttButton(true, false, true, false, false, false);
                    _formatDT();
                    dtListProfile.DataSource = lib.cls_Employess._showProfileInfo();
                    nhanvienID = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                //Get child control theo type truyền vào
                var getChildControls = GetAll(this, typeof(ComboBox));

                var listOfErrors = getChildControls.Select(c => errorProvider.GetError(c))
                                                   .Where(s => !string.IsNullOrEmpty(s))
                                                   .ToList();
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên:\n - " + string.Join("\n - ", listOfErrors.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (check == 1)
                {

                    if (lib.cls_Employess._checkProfile(Convert.ToInt32(cmbTenNV.SelectedValue)))
                    {
                        string pathImage = "\\AnhNV" + CurrentImagePath;
                        string ngayvaolam = dtpNgayVaoLam.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                        bool addProfile = lib.cls_Employess._addProfile(Convert.ToInt32(cmbTenNV.SelectedValue), ngayvaolam, Convert.ToInt32(cmbDanToc.SelectedValue), Convert.ToInt32(cmbTonGiao.SelectedValue), Convert.ToInt32(cmbTinhThanh.SelectedValue), Convert.ToInt32(cmbBangCap.SelectedValue), txtGhiChu.Text, pathImage);
                        if (addProfile == true)
                        {
                            MessageBox.Show("Thêm hồ sơ nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _reset();
                            _sttButton(true, false, true, false, false, false);
                            _formatDT();
                            dtListProfile.DataSource = lib.cls_Employess._showProfileInfo();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm hồ sơ nhân viên này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên này đã có trong hồ sơ. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string pathImage;
                    if (CurrentImagePath == "")
                    {
                        pathImage = dtListProfile.Rows[rowSelected].Cells[12].Value.ToString();
                    }
                    else
                    {
                        pathImage = "\\AnhNV" + CurrentImagePath;
                    }
                    string ngayvaolam = dtpNgayVaoLam.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    bool updateProfile = lib.cls_Employess._updateProfile(Convert.ToInt32(cmbTenNV.SelectedValue), ngayvaolam, Convert.ToInt32(cmbDanToc.SelectedValue), Convert.ToInt32(cmbTonGiao.SelectedValue), Convert.ToInt32(cmbTinhThanh.SelectedValue), Convert.ToInt32(cmbBangCap.SelectedValue), txtGhiChu.Text, pathImage);
                    if (updateProfile == true)
                    {
                        MessageBox.Show("Cập nhật hồ sơ nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reset();
                        _sttButton(true, false, true, false, false, false);
                        _formatDT();
                        dtListProfile.DataSource = lib.cls_Employess._showProfileInfo();
                        rowSelected = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật hồ sơ nhân viên này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, false, true, false, false, false);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string files = openFileDialog.FileName;
            CurrentImagePath = files.Substring(files.LastIndexOf("\\"));
            FileInfo fileInfo = new FileInfo(files);
            FileStream fileStream = fileInfo.OpenRead();
            imgNV.Image = resizeImage(Image.FromStream(fileStream), new Size(160, 200));
            fileStream.Close();
            if (!Directory.Exists("AnhNV"))
            {
                Directory.CreateDirectory("AnhNV");
            }
            //get path
            string appPath = Application.StartupPath + "\\AnhNV";
            //luu file vao application path
            imgNV.Image.Save(appPath + @"\" + CurrentImagePath, ImageFormat.Jpeg);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "";
            openFileDialog.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            openFileDialog.Multiselect = false; // cho phép chọn 1 ảnh
            openFileDialog.Title = "Ảnh Hồ Sơ Nhân Viên";
            openFileDialog.ShowDialog();
        }

        private void dtListProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Employess._showProfileInfo().Rows.Count > 0)
            {
                int index = dtListProfile.CurrentCell.RowIndex;
                nhanvienID = Convert.ToInt32(dtListProfile.Rows[index].Cells[0].Value);
                cmbTenNV.SelectedValue = Convert.ToInt32(dtListProfile.Rows[index].Cells[0].Value);
                cmbDanToc.SelectedValue = Convert.ToInt32(dtListProfile.Rows[index].Cells[4].Value);
                cmbTonGiao.SelectedValue = Convert.ToInt32(dtListProfile.Rows[index].Cells[6].Value);
                cmbTinhThanh.SelectedValue = Convert.ToInt32(dtListProfile.Rows[index].Cells[8].Value);
                cmbBangCap.SelectedValue = Convert.ToInt32(dtListProfile.Rows[index].Cells[10].Value);
                txtGhiChu.Text = dtListProfile.Rows[index].Cells[11].Value.ToString();
                dtpNgayVaoLam.Value = Convert.ToDateTime(dtListProfile.Rows[index].Cells[2].Value);
                _loadImage(dtListProfile.Rows[index].Cells[12].Value.ToString());
                rowSelected = index;
                btnSua.Enabled = true;
            }
        }

        private void cmbTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTenNV.SelectedValue == null)
            {
                errorProvider.SetError(cmbTenNV, "Vui lòng chọn tên nhân viên.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbTenNV, "");
            }
        }

        private void cmbDanToc_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDanToc.SelectedValue == null)
            {
                errorProvider.SetError(cmbDanToc, "Vui lòng chọn Dân Tộc");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbDanToc, "");
            }
        }

        private void cmbTonGiao_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTonGiao.SelectedValue == null)
            {
                errorProvider.SetError(cmbTonGiao, "Vui lòng chọn Tôn Giáo");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbTonGiao, "");
            }
        }

        private void cmbTinhThanh_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTinhThanh.SelectedValue == null)
            {
                errorProvider.SetError(cmbTinhThanh, "Vui lòng chọn Tỉnh Thành");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbTinhThanh, "");
            }
        }

        private void cmbBangCap_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBangCap.SelectedValue == null)
            {
                errorProvider.SetError(cmbBangCap, "Vui lòng chọn Bằng cấp");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbBangCap, "");
            }
        }
    }
}
