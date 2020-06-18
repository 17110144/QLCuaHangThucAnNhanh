using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FastFood.Forms
{
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void openLoginForm()
        {
            Thread.Sleep(1500);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new frm_Login().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new frm_Login().Show();
                this.Visible = false;
            }
        }

        private void _openConnectForm()
        {
            Thread.Sleep(1500);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    new frm_Connect().Show();
                    this.Visible = false;
                });
            }
            else
            {
                new frm_Connect().Show();
                this.Visible = false;
            }
        }
        private void _testConnectDB()
        {
            
            if (!lib.cls_TestConnectDB._testConnect())
            {
                lblStatus.Text = "...Không thể kết nối đến CSDL. Đang cấu hình lại";
                Thread th = new Thread(new ThreadStart(_openConnectForm));
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                lblStatus.Text = "...Kết nối thành công. Đang mở ứng dụng";
                Thread th = new Thread(new ThreadStart(openLoginForm));
                th.IsBackground = true;
                th.Start();
            }
            

        }

        private void _threadFunction()
        {
            Thread.Sleep(2000);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblStatus.Text = "...Đang kiểm tra kết nối đến CSDL";
                });
            }
            else
            {
                lblStatus.Text = "...Đang kiểm tra kết nối đến CSDL";
            }
            Thread.Sleep(1500);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    _testConnectDB();
                });
            }
            else
            {
                _testConnectDB();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Splash_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "...Đang mở ứng dụng";
            Thread th = new Thread(new ThreadStart(_threadFunction));
            th.IsBackground = true;
            th.Start();
        }
    }
}
