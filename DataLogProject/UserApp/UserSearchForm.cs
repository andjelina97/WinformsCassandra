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
    public partial class UserSearchForm : Form
    {
        User _user;
        Application _aplikacija;
        List<Object> _pretraga;
        CustomerLog customerLog;

        public UserSearchForm(Application aplikacija, User vlasnik)
        {
            InitializeComponent();
            _user = vlasnik;
            _aplikacija = aplikacija;
            _pretraga = new List<Object>();
            customerLog = new CustomerLog(_aplikacija.appName, _user.username, _user.password);
        }

        private void OsveziListu()
        {
            dgvSearch.DataSource = null;
            dgvSearch.DataSource = _pretraga;
            if (dgvSearch.ColumnCount <= 0)
                return;
            dgvSearch.Columns[0].Visible = false;
            //dgvSearch.Columns[1].Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LemonChiffon;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String parametarPtretrage = tbxParametarPretrage.Text;
            if (rbtInteresovanjeKorisnika.Checked)
            {
                _pretraga.RemoveRange(0, _pretraga.Count);
                List<LogView> lp = new List<LogView>();
                lp = customerLog.GetLogsView(parametarPtretrage);
                foreach (LogView logPreg in lp)
                    _pretraga.Add(logPreg);
            }
            else if (rbtDogadjajiKorisnika.Checked)
            {
                _pretraga.RemoveRange(0, _pretraga.Count);
                List<LogEvent> lp = new List<LogEvent>();
                lp = customerLog.GetLogsEvent(parametarPtretrage);
                foreach (LogEvent logPreg in lp)
                    _pretraga.Add(logPreg);
            }
            else if (rbtInteresovanjePredmeta.Checked)
            {
                _pretraga.RemoveRange(0, _pretraga.Count);
                int broj = customerLog.GetSubjectLogsView(parametarPtretrage);
                Count countPredmeta = new Count();
                countPredmeta.count = broj.ToString();
                countPredmeta.prvaKol = "";
                countPredmeta.drugaKol = "";
                countPredmeta.nazivPredmeta = parametarPtretrage;
                _pretraga.Add(countPredmeta);
            }
            else if (rbtKorisniciPredmet.Checked)
            {
                _pretraga.RemoveRange(0, _pretraga.Count);
                List<LogView> lp = new List<LogView>();
                lp = customerLog.GetLogsSubjectNameView(parametarPtretrage);
                foreach (LogView logPreg in lp)
                    _pretraga.Add(logPreg);
            }
            else
                return;

            OsveziListu();
        }

        public class Count
        {
            public String prvaKol { get; set; }
            public String drugaKol { get; set; }
            public String nazivPredmeta { get; set; }
            public String count { get; set; }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LemonChiffon;
        }
    }
}
