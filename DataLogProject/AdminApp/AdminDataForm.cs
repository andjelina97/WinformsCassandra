using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer.QueryEntities;
using CassandraDataLayer;
using TestApp;

namespace AdminApp
{
    public partial class AdminDataForm : Form
    {
        List<Admin> _admins;
        Admin _admin;
        CustomerLog _customerLog;


        public AdminDataForm(Admin admin, CustomerLog customerLog)
        {
            InitializeComponent();
            _admin = admin;
            _customerLog = customerLog;
            _customerLog.LogEvent(_admin.id, "OtvorenoDodavanjeAdministratora");
            _admins = DataProvider.GetAdmins();
            dgvAdmins.DataSource = _admins;
        }

        private void btnAddAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }

        private void btnAddAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }

        private void btnDeleteAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteAdmin.ForeColor = Color.MistyRose;
        }

        private void btnDeleteAdmin_MouseHover(object sender, EventArgs e)
        {
            btnDeleteAdmin.ForeColor = Color.MistyRose;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            _customerLog.LogEvent(_admin.id, "DodatAdministrator");
            String id = tbxId.Text;
            bool postoji = false;
            foreach (Admin adm in _admins)
            {
                if (id == adm.id)
                {
                    postoji = true;
                    break;
                }
            }

            if (postoji)
            {
                MessageBox.Show("Vec postoji administrator sa tim id-om.");
                return;
            }


            String password = tbxPassword.Text;
            String ime = tbxIme.Text;
            String prezime = tbxPrezime.Text;
            String brojTelefona = tbxBrojTelefona.Text;

            Admin admin = new Admin();

            admin.id = id;
            admin.password = password;
            admin.name = ime;
            admin.surname = prezime;
            admin.phonenumber = brojTelefona;

            bool uspesno = DataProvider.AddAdmin(admin);

            if (!uspesno)
            {
                MessageBox.Show("Nije dodat administrator (doslo je do greske). " + id);
                return;
            }

            _admins.Add(admin);
            MessageBox.Show("Dodat je administrator ." + id);
            dgvAdmins.DataSource = null;
            dgvAdmins.DataSource = _admins;

            tbxId.ResetText();
            tbxPassword.ResetText();
            tbxIme.ResetText();
            tbxPrezime.ResetText();
            tbxBrojTelefona.ResetText();

        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            _customerLog.LogEvent(_admin.id, "ObrisanAdministrator");
            if (dgvAdmins.SelectedRows.Count <= 0 || dgvAdmins.SelectedRows[0].Index < 0)
                return;
            int red = dgvAdmins.SelectedRows[0].Index;
            String id = _admins[red].id;
            if (id == "root1")
            {
                MessageBox.Show("Ne moze se obrisati root administrator");
                return;
            }

            DataProvider.DeleteAdmin(id);
            _admins.RemoveAt(red);
            dgvAdmins.DataSource = null;
            dgvAdmins.DataSource = _admins;

        }

        private void btnAddAdmin_MouseEnter_1(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }

        private void btnAddAdmin_MouseHover_1(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.MistyRose;
        }

        private void btnAddAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAddAdmin.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void btnDeleteAdmin_MouseEnter_1(object sender, EventArgs e)
        {
            btnDeleteAdmin.ForeColor = Color.MistyRose;
        }

        private void btnDeleteAdmin_MouseHover_1(object sender, EventArgs e)
        {
            btnDeleteAdmin.ForeColor = Color.MistyRose;
        }

        private void btnDeleteAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteAdmin.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
