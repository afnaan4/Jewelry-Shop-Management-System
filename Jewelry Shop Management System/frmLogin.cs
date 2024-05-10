using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Shop_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = DESKTOP-OQQV4QN\\AFNAAN; Initial Catalog=xafsa; Integrated Security =true;");
            string qry = "Select * from usertbl where UserName='" + txtName.Text.Trim() + "'and UserPassword='" + txtPasswod.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                 FrmDashboard FrmMain = new FrmDashboard();
                Hide();
                FrmMain.Show();
            }
            else
            {
                MessageBox.Show("Plze provide your details");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPasswod.UseSystemPasswordChar = false;

            }
            else
            {
                txtPasswod.UseSystemPasswordChar= true; 
            }

        }
    }
}
