namespace FastFood.PresentationLayer.UCFunction
{
    partial class UC_TimeSheetManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnHienThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.lblThang = new System.Windows.Forms.Label();
            this.dtList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoPhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamCongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.btnNop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(55, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 28);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "CHẤM CÔNG";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnHienThi);
            this.grpThongTin.Controls.Add(this.dtpThang);
            this.grpThongTin.Controls.Add(this.lblThang);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpThongTin.Location = new System.Drawing.Point(37, 79);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTin.Size = new System.Drawing.Size(1133, 123);
            this.grpThongTin.TabIndex = 70;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chấm công";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHienThi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienThi.BorderRadius = 5;
            this.btnHienThi.ButtonText = "HIỂN THỊ";
            this.btnHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnHienThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHienThi.Iconimage = null;
            this.btnHienThi.Iconimage_right = null;
            this.btnHienThi.Iconimage_right_Selected = null;
            this.btnHienThi.Iconimage_Selected = null;
            this.btnHienThi.IconMarginLeft = 0;
            this.btnHienThi.IconMarginRight = 0;
            this.btnHienThi.IconRightVisible = true;
            this.btnHienThi.IconRightZoom = 0D;
            this.btnHienThi.IconVisible = true;
            this.btnHienThi.IconZoom = 90D;
            this.btnHienThi.IsTab = false;
            this.btnHienThi.Location = new System.Drawing.Point(808, 52);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnHienThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHienThi.selected = false;
            this.btnHienThi.Size = new System.Drawing.Size(128, 33);
            this.btnHienThi.TabIndex = 74;
            this.btnHienThi.Text = "HIỂN THỊ";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHienThi.Textcolor = System.Drawing.Color.White;
            this.btnHienThi.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(579, 52);
            this.dtpThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(219, 32);
            this.dtpThang.TabIndex = 3;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(504, 55);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(65, 25);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng";
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtList.ColumnHeadersHeight = 50;
            this.dtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgayCongChuan,
            this.NgayDiLam,
            this.NgayNghi,
            this.NgayTinhLuong,
            this.GhiChu,
            this.TrangThai,
            this.BoPhanID,
            this.NhanVienID,
            this.ChamCongID,
            this.Thang});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtList.DoubleBuffered = true;
            this.dtList.EnableHeadersVisualStyles = false;
            this.dtList.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.dtList.HeaderForeColor = System.Drawing.Color.White;
            this.dtList.Location = new System.Drawing.Point(8, 34);
            this.dtList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtList.MultiSelect = false;
            this.dtList.Name = "dtList";
            this.dtList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtList.RowHeadersVisible = false;
            this.dtList.RowHeadersWidth = 50;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtList.Size = new System.Drawing.Size(1117, 423);
            this.dtList.TabIndex = 1;
            this.dtList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtList_CellFormatting);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayCongChuan
            // 
            this.NgayCongChuan.DataPropertyName = "NgayCongChuan";
            this.NgayCongChuan.HeaderText = "Ngày công chuẩn";
            this.NgayCongChuan.MinimumWidth = 6;
            this.NgayCongChuan.Name = "NgayCongChuan";
            // 
            // NgayDiLam
            // 
            this.NgayDiLam.DataPropertyName = "NgayDiLam";
            this.NgayDiLam.HeaderText = "Ngày đi làm";
            this.NgayDiLam.MinimumWidth = 6;
            this.NgayDiLam.Name = "NgayDiLam";
            // 
            // NgayNghi
            // 
            this.NgayNghi.DataPropertyName = "NgayNghi";
            this.NgayNghi.HeaderText = "Ngày nghỉ";
            this.NgayNghi.MinimumWidth = 6;
            this.NgayNghi.Name = "NgayNghi";
            // 
            // NgayTinhLuong
            // 
            this.NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            this.NgayTinhLuong.HeaderText = "Ngày tính lương";
            this.NgayTinhLuong.MinimumWidth = 6;
            this.NgayTinhLuong.Name = "NgayTinhLuong";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BoPhanID
            // 
            this.BoPhanID.DataPropertyName = "BoPhanID";
            this.BoPhanID.HeaderText = "BoPhanID";
            this.BoPhanID.MinimumWidth = 6;
            this.BoPhanID.Name = "BoPhanID";
            this.BoPhanID.Visible = false;
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.MinimumWidth = 6;
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = false;
            // 
            // ChamCongID
            // 
            this.ChamCongID.DataPropertyName = "ChamCongID";
            this.ChamCongID.HeaderText = "ChamCongID";
            this.ChamCongID.MinimumWidth = 6;
            this.ChamCongID.Name = "ChamCongID";
            this.ChamCongID.Visible = false;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Thang";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.Visible = false;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dtList);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpDanhSach.Location = new System.Drawing.Point(37, 209);
            this.grpDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDanhSach.Size = new System.Drawing.Size(1133, 476);
            this.grpDanhSach.TabIndex = 79;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chấm công";
            // 
            // btnNop
            // 
            this.btnNop.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnNop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNop.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNop.BorderRadius = 5;
            this.btnNop.ButtonText = "NỘP";
            this.btnNop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNop.DisabledColor = System.Drawing.Color.Gray;
            this.btnNop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNop.Iconimage = null;
            this.btnNop.Iconimage_right = null;
            this.btnNop.Iconimage_right_Selected = null;
            this.btnNop.Iconimage_Selected = null;
            this.btnNop.IconMarginLeft = 0;
            this.btnNop.IconMarginRight = 0;
            this.btnNop.IconRightVisible = true;
            this.btnNop.IconRightZoom = 0D;
            this.btnNop.IconVisible = true;
            this.btnNop.IconZoom = 90D;
            this.btnNop.IsTab = false;
            this.btnNop.Location = new System.Drawing.Point(1001, 693);
            this.btnNop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNop.Name = "btnNop";
            this.btnNop.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnNop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnNop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNop.selected = false;
            this.btnNop.Size = new System.Drawing.Size(168, 54);
            this.btnNop.TabIndex = 83;
            this.btnNop.Text = "NỘP";
            this.btnNop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNop.Textcolor = System.Drawing.Color.White;
            this.btnNop.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.ButtonText = "LƯU";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 90D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(827, 693);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(167, 54);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::FastFood.Properties.Resources.left_round_32px;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 39);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 69;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UC_TimeSheetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_TimeSheetManager";
            this.Size = new System.Drawing.Size(1191, 762);
            this.Load += new System.EventHandler(this.UC_TimeSheetManager_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lblThang;
        private Bunifu.Framework.UI.BunifuFlatButton btnHienThi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtList;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private Bunifu.Framework.UI.BunifuFlatButton btnNop;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoPhanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChamCongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
