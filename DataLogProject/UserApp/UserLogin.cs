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

namespace UserApp
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LemonChiffon;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LemonChiffon;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DimGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datUsername = tbxUsername.Text;
            String datPassword = tbxPassword.Text;
            User v = DataProvider.GetUser(datUsername);

            bool uspesno;
            if (v.password == datPassword)
                uspesno = true;
            else
                uspesno = false;


            if (uspesno)
            {
                UserForm vlasnikF = new UserForm(v);
                vlasnikF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ne postoji korisnik sa zadatom kombinacjom ID-a i lozinke.");
            }
        }
    }
}
