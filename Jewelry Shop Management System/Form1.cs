using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Shop_Management_System
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top -= 1;
            if (label1.Top <= 200)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Top += 1;
            if (label1.Top >= 240)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 458)
            {
                frmLogin frmLogin = new frmLogin();
                Hide();
                frmLogin.Show();
                timer3.Stop();

            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
