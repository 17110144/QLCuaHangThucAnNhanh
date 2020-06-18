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
using FastFood.UCFunction;

namespace FastFood.UCSytems
{
    public partial class UC_Category : UserControl
    {
        public UC_Category()
        {
            InitializeComponent();
        }

        private void btnSysFood_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_CityCategory"))
            {
                UC_CityCategory cityCategory = new UC_CityCategory();
                cityCategory.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(cityCategory);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_CityCategory"].BringToFront();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {

            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_ReligionManager"))
            //{
            //    UC_ReligionManager religionManager = new UC_ReligionManager();
            //    religionManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(religionManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_ReligionManager"].BringToFront();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_NationManager"))
            //{
            //    UC_NationManager nationManager = new UC_NationManager();
            //    nationManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(nationManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_NationManager"].BringToFront();
        }

        private void btnBangCap_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_DegreeManager"))
            //{
            //    UC_DegreeManager degreeManager = new UC_DegreeManager();
            //    degreeManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(degreeManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_DegreeManager"].BringToFront();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_OfficesManager"))
            //{
            //    UC_OfficesManager officesManager = new UC_OfficesManager();
            //    officesManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(officesManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_OfficesManager"].BringToFront();
        }
    }
}
