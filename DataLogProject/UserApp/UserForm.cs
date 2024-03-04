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
using Application = CassandraDataLayer.QueryEntities.Application;

namespace UserApp
{
    public partial class UserForm : Form
    {
        User _thisUser;
        List<Application> _aplikacije;
        CustomerLog customerLog;

        public UserForm(User user)
        {
            InitializeComponent();
            _thisUser = user;
            _aplikacije = VratiSveAplikacije();
            Applications.DataSource = _aplikacije;
            Applications.DisplayMember = "nazivAplikacije";

            if (_thisUser.id == "root1")
            {
               // btnAdd.Enabled = false;
                //btnDelete.Enabled = false;
            }

            //Ukljucivanje logovanja podataka
            customerLog = new CustomerLog("logovanjeVlasnika", "root", "1234");
            customerLog.LogEvent(_thisUser.username, "Ulogovanje");
            OsveziListBox();
        }

        public List<Application> VratiSveAplikacije()
        {
            List<Application> povratna = null;
            povratna = DataProvider.GetApps(_thisUser.id);
            return povratna;
        }

        public void OsveziListBox()
        {
            Applications.DataSource = null;
            Applications.DataSource = _aplikacije;
            Applications.DisplayMember = "App names";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerLog.LogEvent(_thisUser.username, "Brisanje aplikacije.");
            if (Applications.SelectedIndex < 0)
                return;

            int selektovanIndeks = Applications.SelectedIndex;
            String nazivAplikacije = _aplikacije[selektovanIndeks].appName;
            DataProvider.DeleteApp(nazivAplikacije, _thisUser.id);
            _aplikacije.RemoveAt(selektovanIndeks);
            OsveziListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customerLog.LogEvent(_thisUser.username, "Dodavanje aplikacije.");
            String nazivAplikacije = tbxNaziv.Text;
            bool postoji = false;
            foreach (Application appl in _aplikacije)
            {
                if (nazivAplikacije == appl.appName)
                {
                    postoji = true;
                    break;
                }
            }

            if (postoji)
            {
                MessageBox.Show("Vec postoji aplikacija sa tim nazivom.");
                return;
            }


            String tip = tbxTip.Text;
            String namena = tbxNamena.Text;
            String usloviKoriscenja = tbxUsloviKoriscenja.Text;

            Application app = new Application();

            app.appName = nazivAplikacije;
            app.appType = tip;
            app.purposeOfApp = namena;
            app.termsOfUse = usloviKoriscenja;

            bool uspesno = DataProvider.AddApp(app, _thisUser.id);

            if (!uspesno)
            {
                MessageBox.Show("Nije dodata aplikacija (doslo je do greske)." + nazivAplikacije);
                return;
            }

            _aplikacije.Add(app);
            MessageBox.Show("Dodata je aplikacija ." + nazivAplikacije);
            OsveziListBox();

            tbxNamena.ResetText();
            tbxNaziv.ResetText();
            tbxTip.ResetText();
            tbxUsloviKoriscenja.ResetText();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Applications.SelectedIndex < 0)
                return;

            int selektovanIndeks = Applications.SelectedIndex;
            Application aplikacija = _aplikacije[selektovanIndeks];

            UserSearchForm vpaf = new UserSearchForm(aplikacija, _thisUser);
            customerLog.LogEvent(_thisUser.username, "Otvoreno pretrazivanje");
            vpaf.ShowDialog();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            customerLog.LogEvent(_thisUser.username, "Izlogovanje");
        }

       

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.LemonChiffon;
        }

        private void btnSearch_MouseHover_1(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.LemonChiffon;
        }

        private void btnSearch_MouseLeave_1(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.DimGray;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.LemonChiffon;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.LemonChiffon;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.DimGray;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.LemonChiffon;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.LemonChiffon;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.DimGray;
        }
    }
}
