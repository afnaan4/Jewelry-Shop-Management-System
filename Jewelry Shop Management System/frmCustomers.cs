using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Jewelry_Shop_Management_System
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
    
    SqlConnection cn = new SqlConnection("Data Source = DESKTOP-OQQV4QN\\AFNAAN; Initial Catalog=xafsa; Integrated Security =true;");
    SqlCommand cmd;
    SqlDataAdapter da;
    int ID = 0;

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from Customer", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void ClearData()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
           
            ID = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtCustomerName.Text != "" && txtPhone.Text != "")
            {
                cmd = new SqlCommand("Insert into customer values(@CusID,@CusFName,@CusLName)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CusID", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@CusFName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@CusLName", txtPhone.Text);

               
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = " ";
            txtCustomerName.Text = " ";
            txtPhone.Text = " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                cmd = new SqlCommand("Delete customer where CusID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtCustomerId.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCustomerName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtCustomerName.Text != "" && txtPhone.Text != "")
            {
                cmd = new SqlCommand("Update customer set CusFname=@fname, CusPhone=@Phone where CusID=@id", cn);
                ID = Convert.ToInt32(txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@fname", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                cn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the ecord");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            Hide();
            frmDashboard.Show();
        }

        private void GnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtCustomerName.Text != "" && txtPhone.Text != "")
            {
                cmd = new SqlCommand("Insert into customer values(@CusID,@CusFName,@CusLName)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CusID", txtCustomerId.Text);
                cmd.Parameters.AddWithValue("@CusFName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@CusLName", txtPhone.Text);


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

        private void gnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                cmd = new SqlCommand("Delete customer where CusID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtCustomerId.Text);
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

        private void gnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = " ";
            txtCustomerName.Text = " ";
            txtPhone.Text = " ";
        }

        private void gnHome_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            Hide();
            frmDashboard.Show();
        
    }
    }
    }

