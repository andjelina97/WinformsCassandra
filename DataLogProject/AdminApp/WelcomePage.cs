using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserApp;
using TestApp;


namespace AdminApp
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.LightBlue;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.LightBlue;
        }

        private void btnCustomer_MouseHover(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.LightBlue;
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoginForm admF = new LoginForm();
            admF.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin admF = new AdminLogin();
            admF.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin admF = new UserLogin();
            admF.ShowDialog();
        }

        private void btnAdmin_MouseHover_1(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.LightGoldenrodYellow;
            btnAdmin.BackColor = Color.Gainsboro;

        }

        private void btnUser_MouseHover_1(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.LightGoldenrodYellow;
            btnUser.BackColor = Color.Gainsboro;
        }

        private void btnCustomer_MouseHover_1(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.LightGoldenrodYellow;
            btnCustomer.BackColor = Color.Gainsboro;
        }

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.LightGoldenrodYellow;
            btnAdmin.BackColor = Color.Gainsboro;
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.LightGoldenrodYellow;
            btnUser.BackColor = Color.Gainsboro;
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.LightGoldenrodYellow;
            btnCustomer.BackColor = Color.Gainsboro;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.DimGray;
            btnAdmin.BackColor = Color.Beige;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.ForeColor = Color.DimGray;
            btnUser.BackColor = Color.Beige;
        }

        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.DimGray;
            btnCustomer.BackColor = Color.Beige;
        }
    }
}
