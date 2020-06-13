namespace FastFood.Forms
{
    partial class frm_Connect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Connect));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblSeverName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSelectDB = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.cmbSelectDB = new System.Windows.Forms.ComboBox();
            this.btnGetDB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(434, 28);
            this.panelHeader.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(402, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONNECT TO SEVER";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 28);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(4, 383);
            this.panelLeft.TabIndex = 5;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(430, 28);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(4, 383);
            this.panelRight.TabIndex = 6;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(4, 407);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(426, 4);
            this.panelFooter.TabIndex = 7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // lblSeverName
            // 
            this.lblSeverName.AutoSize = true;
            this.lblSeverName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeverName.Location = new System.Drawing.Point(12, 138);
            this.lblSeverName.Name = "lblSeverName";
            this.lblSeverName.Size = new System.Drawing.Size(89, 20);
            this.lblSeverName.TabIndex = 9;
            this.lblSeverName.Text = "Sever name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Authentication:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(39, 204);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 20);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "User name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(39, 234);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblSelectDB
            // 
            this.lblSelectDB.AutoSize = true;
            this.lblSelectDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDB.Location = new System.Drawing.Point(12, 318);
            this.lblSelectDB.Name = "lblSelectDB";
            this.lblSelectDB.Size = new System.Drawing.Size(119, 20);
            this.lblSelectDB.TabIndex = 14;
            this.lblSelectDB.Text = "Select Database:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(174, 201);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 27);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(174, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 27);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(174, 135);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(248, 27);
            this.txtServerName.TabIndex = 17;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(174, 167);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(248, 28);
            this.cmbAuthor.TabIndex = 18;
            this.cmbAuthor.SelectedValueChanged += new System.EventHandler(this.cmbAuthor_SelectedValueChanged);
            // 
            // cmbSelectDB
            // 
            this.cmbSelectDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDB.FormattingEnabled = true;
            this.cmbSelectDB.Location = new System.Drawing.Point(174, 315);
            this.cmbSelectDB.Name = "cmbSelectDB";
            this.cmbSelectDB.Size = new System.Drawing.Size(248, 28);
            this.cmbSelectDB.TabIndex = 20;
            // 
            // btnGetDB
            // 
            this.btnGetDB.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnGetDB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGetDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetDB.BorderRadius = 5;
            this.btnGetDB.ButtonText = "Lấy danh sách Database";
            this.btnGetDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetDB.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDB.ForeColor = System.Drawing.Color.White;
            this.btnGetDB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetDB.Iconimage = null;
            this.btnGetDB.Iconimage_right = null;
            this.btnGetDB.Iconimage_right_Selected = null;
            this.btnGetDB.Iconimage_Selected = null;
            this.btnGetDB.IconMarginLeft = 0;
            this.btnGetDB.IconMarginRight = 0;
            this.btnGetDB.IconRightVisible = true;
            this.btnGetDB.IconRightZoom = 0D;
            this.btnGetDB.IconVisible = true;
            this.btnGetDB.IconZoom = 90D;
            this.btnGetDB.IsTab = false;
            this.btnGetDB.Location = new System.Drawing.Point(237, 269);
            this.btnGetDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetDB.Name = "btnGetDB";
            this.btnGetDB.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnGetDB.OnHovercolor = System.Drawing.Color.Black;
            this.btnGetDB.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetDB.selected = false;
            this.btnGetDB.Size = new System.Drawing.Size(184, 33);
            this.btnGetDB.TabIndex = 80;
            this.btnGetDB.Text = "Lấy danh sách Database";
            this.btnGetDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetDB.Textcolor = System.Drawing.Color.White;
            this.btnGetDB.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDB.Click += new System.EventHandler(this.btnGetDB_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Activecolor = System.Drawing.Color.Empty;
            this.btnConnect.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.BorderRadius = 5;
            this.btnConnect.ButtonText = "Connect";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnect.Iconimage = null;
            this.btnConnect.Iconimage_right = null;
            this.btnConnect.Iconimage_right_Selected = null;
            this.btnConnect.Iconimage_Selected = null;
            this.btnConnect.IconMarginLeft = 0;
            this.btnConnect.IconMarginRight = 0;
            this.btnConnect.IconRightVisible = true;
            this.btnConnect.IconRightZoom = 0D;
            this.btnConnect.IconVisible = true;
            this.btnConnect.IconZoom = 90D;
            this.btnConnect.IsTab = false;
            this.btnConnect.Location = new System.Drawing.Point(208, 363);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnConnect.OnHovercolor = System.Drawing.Color.Black;
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnect.selected = false;
            this.btnConnect.Size = new System.Drawing.Size(103, 33);
            this.btnConnect.TabIndex = 81;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnect.Textcolor = System.Drawing.Color.White;
            this.btnConnect.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Empty;
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(319, 363);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(103, 33);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(61, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(314, 75);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // frm_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnGetDB);
            this.Controls.Add(this.cmbSelectDB);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblSelectDB);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSeverName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Sever";
            this.Load += new System.EventHandler(this.frm_Connect_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelFooter;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSelectDB;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeverName;
        private System.Windows.Forms.ComboBox cmbSelectDB;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnect;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetDB;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}