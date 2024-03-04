using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;


namespace TestApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.PaleTurquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Morate popuniti polja.");
                return;
            }

            String username = tbxUsername.Text;
            String password = tbxPassword.Text;
            UserCustomer customer = new UserCustomer();
            customer.username = username;
            customer.password = password;

            if (rbtOrderWine.Checked)
            {
                WineShopForm app = new WineShopForm(customer);
                app.ShowDialog();
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkSlateGray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.PaleTurquoise;
        }
    }
}
