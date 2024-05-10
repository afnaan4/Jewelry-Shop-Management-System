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
using System.Xml.Linq;

namespace Jewelry_Shop_Management_System
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source = DESKTOP-OQQV4QN\\AFNAAN; Initial Catalog=xafsa; Integrated Security =true;");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from Bill", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void ClearData()
        {
           txtId.Clear();
           txtProduct.Clear();
            txtCuName.Clear();
            txtCustomerId.Clear();
            txtPRQu.Clear();
            txtTotal.Clear();
            txtUnit.Clear();
            ID = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = " ";
            txtProduct.Text = " ";
            txtCustomerId.Text = " ";
            txtCuName.Text = "";
            txtPRQu.Text = " ";
            txtTotal.Text = " ";
            txtUnit.Text = " ";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            Hide();
            frmDashboard.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "" && txtCuName.Text != "" && txtCustomerId.Text != "" && txtProduct.Text != "" && txtPRQu.Text != "" && txtTotal.Text != "" && txtUnit.Text != "")
            {
                cmd = new SqlCommand("Insert into Bill values(@BillID,@Product,@CusID,@CusName,@PrQu,@Total,@UnitPr)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@BillID", txtId.Text);
                cmd.Parameters.AddWithValue("@Product", txtProduct.Text);
                cmd.Parameters.AddWithValue("@CusID", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@CusName", txtCuName.Text);
                cmd.Parameters.AddWithValue("@PrQu", txtPRQu.Text);
                cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                cmd.Parameters.AddWithValue("@UnitPr", txtUnit.Text);


                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Seccessfuly");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                cmd = new SqlCommand("Delete Bill where BillID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtId.Text);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Deleted secccessfuly");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please try again");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtCuName.Text != "" && txtCustomerId.Text != "" && txtProduct.Text != "" && txtPRQu.Text != "" && txtTotal.Text != "" && txtUnit.Text != "")
            {
                cmd = new SqlCommand("Insert into Bill values(@BillID,@Product,@CusID,@CusName,@PrQu,@Total,@UnitPr)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@BillID", txtId.Text);
                cmd.Parameters.AddWithValue("@Product", txtProduct.Text);
                cmd.Parameters.AddWithValue("@CusID", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@CusName", txtCuName.Text);
                cmd.Parameters.AddWithValue("@PrQu", txtPRQu.Text);
                cmd.Parameters.AddWithValue("@Total", txtTotal.Text);
                cmd.Parameters.AddWithValue("@UnitPr", txtUnit.Text);


                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Seccessfuly");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                cmd = new SqlCommand("Delete Bill where BillID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtId.Text);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();

                cn.Close();
                MessageBox.Show("Deleted secccessfuly");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please try again");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtId.Text = " ";
            txtProduct.Text = " ";
            txtCustomerId.Text = " ";
            txtCuName.Text = "";
            txtPRQu.Text = " ";
            txtTotal.Text = " ";
            txtUnit.Text = " ";
        
    }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            Hide();
            frmDashboard.Show();
        }
    }
}
