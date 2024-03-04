using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;


namespace AdminApp
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MistyRose;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.MistyRose;
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datID = tbxID.Text;
            String datPassword = tbxPassword.Text;
            Admin a = DataProvider.GetAdmin(datID);

            bool uspesno;
            if (a.password == datPassword)
                uspesno = true;
            else
                uspesno = false;


            if (uspesno)
            {
                AdminAddUserForm admF = new AdminAddUserForm(a);
                admF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik sa zadatom kombinacjom ID-a i lozinke.");
            }
        }
    }
}
