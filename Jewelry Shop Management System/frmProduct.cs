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
    public partial class frmProduct : Form
    {
        public frmProduct()
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
            da = new SqlDataAdapter("Select * from product", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void ClearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtUnit.Clear();
            txtQun.Clear();

            ID = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            Hide();
            dashboard.Show();   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "")
            {
                cmd = new SqlCommand("Delete product where PrID=@id", cn);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtCategory.Text != "" && txtQun.Text != "" && txtUnit.Text != "")
            {
                cmd = new SqlCommand("Update product set PrName=@prname, PrCat=@prCat ,PrQu=@Prqu ,PrUnit=@prUnit where CusID=@id", cn);
                ID = Convert.ToInt32(txtId.Text);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@prname", txtName.Text);
                cmd.Parameters.AddWithValue("@prCat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@PrQu", txtQun.Text);
                cmd.Parameters.AddWithValue("@PrUnit", txtUnit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                cn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the record");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtCategory.Text != "" && txtQun.Text != "" && txtUnit.Text != "")
            {
                cmd = new SqlCommand("Insert into product values(@PrID,@PrName,@PrCat,@PrQu,@PrUnit)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@PrID", txtId.Text);
                cmd.Parameters.AddWithValue("@PrName", txtName.Text);
                cmd.Parameters.AddWithValue("@PrCat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@PrQu", txtQun.Text);
                cmd.Parameters.AddWithValue("@PrUnit", txtUnit.Text);


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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "")
            {
                cmd = new SqlCommand("Delete product where PrID=@id", cn);
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtId.Text = " ";
            txtCategory.Text = " ";
            txtName.Text = " ";
            txtQun.Text = " ";
            txtUnit.Text = " ";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            Hide();
            dashboard.Show();
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {

            if (txtId.Text != "" && txtName.Text != "" && txtCategory.Text != "" && txtQun.Text != "" && txtUnit.Text != "")
            {
                cmd = new SqlCommand("Insert into product values(@PrID,@PrName,@PrCat,@PrQu,@PrUnit)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@PrID", txtId.Text);
                cmd.Parameters.AddWithValue("@PrName", txtName.Text);
                cmd.Parameters.AddWithValue("@PrCat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@PrQu", txtQun.Text);
                cmd.Parameters.AddWithValue("@PrUnit", txtUnit.Text);


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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

