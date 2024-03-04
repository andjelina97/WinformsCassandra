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
using CassandraDataLayer.QueryEntities;


namespace AdminApp
{
    public partial class AdminAddUserForm : Form
    {
        Admin _admin;
        CustomerLog customerLog;

        public AdminAddUserForm(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
            if (_admin.id != "root1")
                btnAddAdmin.Enabled = false;

            customerLog = new CustomerLog("logovanjeAdministratora", "root", "1234");
            customerLog.LogEvent(admin.id, "Ulogovanje");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MistyRose;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MistyRose;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MistyRose;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.MistyRose;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerLog.LogEvent(_admin.id, "DodavanjeVlasnika");

            User v = new User();
            v.id = tbxID.Text;
            v.username = tbxUsername.Text;
            v.password = tbxPassword.Text;
            v.company = tbxCompany.Text;
            v.email = tbxEmail.Text;

            bool uspesnost = DataProvider.AddUser(v);
            if (uspesnost)
            {
                MessageBox.Show("Uspesno je dodat vlasnik " + v.username + ".");
            }
            else
            {
                MessageBox.Show("!!! Nije uspesno je dodat vlasnik " + v.username + ".");
            }

            tbxID.ResetText();
            tbxUsername.ResetText();
            tbxPassword.ResetText();
            tbxEmail.ResetText();
            tbxCompany.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerLog.LogEvent(_admin.id, "BrisanjeVlasnika");

            if (tbxID.Text == "" || tbxUsername.Text == "")
            {
                MessageBox.Show("Moraju biti uneti username i ID vlasnika koga zelite da obriste.");
                return;
            }

            String id = tbxID.Text;
            String username = tbxUsername.Text;
            bool uspesnost = DataProvider.DeleteUser(username, id);
            if (uspesnost)
            {
                MessageBox.Show("Uspesno je obrisan vlasnik " + username + ".");
            }
            else
            {
                MessageBox.Show("!!! Nije uspesno je obrisan vlasnik " + username + ".");
            }

            tbxID.ResetText();
            tbxUsername.ResetText();
            tbxPassword.ResetText();
            tbxEmail.ResetText();
            tbxCompany.ResetText();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AdminDataForm adaf = new AdminDataForm(_admin, customerLog);
            adaf.ShowDialog();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void btnAddAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void btnAddAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }

        private void btnAddAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }
    }
}
