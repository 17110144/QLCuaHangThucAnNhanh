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

namespace FastFood.PresentationLayer.UCSytem
{
    public partial class UC_Personnel : UserControl
    {
        public UC_Personnel()
        {
            InitializeComponent();
        }
        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_PersonnelManager"))
            //{
            //    UC_PersonnelManager personnelManager = new UC_PersonnelManager();
            //    personnelManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(personnelManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_PersonnelManager"].BringToFront();
        }

        private void btnHoSoNhanVien_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_ProfilePersonnelManager"))
            //{
            //    UC_ProfilePersonnelManager profilePersonnelManager = new UC_ProfilePersonnelManager();
            //    profilePersonnelManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(profilePersonnelManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_ProfilePersonnelManager"].BringToFront();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_DepartmentManager"))
            //{
            //    UC_DepartmentManager departmentManager = new UC_DepartmentManager();
            //    departmentManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(departmentManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_DepartmentManager"].BringToFront();
        }

        private void btnChucDanh_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_OfficeManager"))
            //{
            //    UC_OfficeManager officeManager = new UC_OfficeManager();
            //    officeManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(officeManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_OfficeManager"].BringToFront();
        }
    }
}
