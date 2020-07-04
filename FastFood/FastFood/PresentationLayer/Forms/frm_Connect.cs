using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.Forms
{
    public partial class frm_Connect : Form
    {
        public frm_Connect()
        {
            InitializeComponent();
        }

        private void frm_Connect_Load(object sender, EventArgs e)
        {
            cmbAuthor.ValueMember = "Value";
            cmbAuthor.DisplayMember = "Text";
            var items = new[] {
                new { Text = "Windows Authentication", Value = "1" },
                new { Text = "SQL Server Authentication", Value = "2" },
            };
            cmbAuthor.DataSource = items;
            lblSelectDB.Enabled = false;
            cmbSelectDB.Enabled = false;
            btnGetDB.Enabled = false;
        }

        private void cmbAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbAuthor.SelectedValue) == 1)
            {
                lblPassword.Enabled = false;
                lblUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
            }
            else
            {
                lblPassword.Enabled = true;
                lblUserName.Enabled = true;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
            }
        }

        private void btnGetDB_Click(object sender, EventArgs e)
        {
            lblSelectDB.Enabled = true;
            cmbSelectDB.Enabled = true;

            string connString = null;

            if (cmbAuthor.SelectedIndex == 0)
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;Integrated Security=True";
            }
            else
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=master;User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                SqlDataAdapter dA = new SqlDataAdapter("SELECT name FROM sys.databases WHERE name not in('master','model','msdb','tempdb')", conn);
                DataTable dt = new DataTable();
                dA.Fill(dt);
                dA.Dispose();
                conn.Close();

                cmbSelectDB.DataSource = dt;
                cmbSelectDB.DisplayMember = "name";
                cmbSelectDB.ValueMember = "name";

                btnGetDB.Enabled = false;
                lblSeverName.Enabled = false;
                txtServerName.Enabled = false;
                btnConnect.Enabled = true;
                cmbAuthor.Enabled = false;
                lblPassword.Enabled = false;
                lblUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
            }
            catch (Exception ex)
            {
                btnConnect.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            btnGetDB.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbSelectDB.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn 1 CSDL.");
                return;
            }

            string connString = null;
            if (cmbAuthor.SelectedIndex == 0)
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cmbSelectDB.SelectedValue.ToString() + ";Integrated Security=True";
            }
            else
            {
                connString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + cmbSelectDB.SelectedValue.ToString() + ";User ID=" + txtUserName.Text.Trim() + ";password=" + txtPassword.Text.Trim();
            }

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("TESTCONNECTION", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = command.ExecuteReader();
                bool flag = false;

                while (dataReader.Read())
                {
                    if (dataReader[0].ToString().Equals("True"))
                    {
                        flag = true;
                    }
                    break;
                }
                conn.Close();

                if (flag)
                {
                    flag = false;
                    File.WriteAllText("config.env", connString);
                    this.Hide();
                    new frm_Splash().Show();
                }
                else
                {
                    MessageBox.Show("Không thể đọc file config. Vui lòng kiểm tra và thử lại.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Vui lòng cấp quyền ghi file config.env.\n" + ex.Message);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
