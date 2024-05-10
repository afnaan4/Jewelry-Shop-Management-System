using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Shop_Management_System
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            Hide();
            customers.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            Hide();
            dashboard.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            Hide();
            product.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            Hide();
            login.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBill frmBill = new frmBill();
            Hide();
            frmBill.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            Hide();
            frmDashboard.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            Hide();
            frmCustomers.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            Hide();
            frmProduct.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmBill frmBill2 = new frmBill();   
            Hide();
            frmBill2.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            Hide();
            frmLogin.Show();
        }
    }
}
