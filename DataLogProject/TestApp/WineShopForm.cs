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

namespace TestApp
{
    public partial class WineShopForm : Form
    {
        UserCustomer _customer;
        List<Wine> listWine;
        CustomerLog _customerLog;

        public WineShopForm(UserCustomer customer)
        {
            InitializeComponent();
            _customer = customer;
            listWine = new List<Wine>();
            _customerLog = new CustomerLog("prodajaVina", "vlasnikVinarije", "1234");
            AddWine();


            _customerLog.LogEvent(_customer.username, "Ulogovanje");
            _customerLog.RegisterCustomer(_customer.username);
        }

        public void AddWine()
        {
            listWine.Add(new Wine("Merlot", "Irish ", 12, "red"));
            listWine.Add(new Wine("Cabernet Sauvignon", "England ", 15, "red"));
            listWine.Add(new Wine("Pinot Noir", "Italy ", 13.5, "red"));
            listWine.Add(new Wine("Chardonnay", "Dutch ", 10, "white"));
            listWine.Add(new Wine("Riesling", "Spain ", 12, "white"));
            listWine.Add(new Wine("Muscat Blanc", "Belgium ", 10, "white"));
            listWine.Add(new Wine("Barbera", "Italy ", 10, "black"));
            listWine.Add(new Wine("Aglianico", "Padova ", 12, "black"));
            listWine.Add(new Wine("Corvina", "Italy ", 10, "black"));
            Wines.DataSource = listWine;
            Wines.DisplayMember = "name";
        }

        private void btnComment_MouseHover(object sender, EventArgs e)
        {
            btnRate.ForeColor = Color.DarkSeaGreen;
        }

        private void btnOrder_MouseHover(object sender, EventArgs e)
        {
            btnDetails.ForeColor = Color.DarkSeaGreen;
        }

        private void btnDetails_MouseHover(object sender, EventArgs e)
        {
            btnComment.ForeColor = Color.DarkSeaGreen;
        }

       

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (Wines.SelectedIndex < 0)
                return;

            _customerLog.LogCustomerView(_customer.username, listWine[Wines.SelectedIndex].name, "ViseInformacija");
            _customerLog.LogEvent(_customer.username, "KlikNaViseInformacija");

            Wine selectedWine = listWine[Wines.SelectedIndex];
            MessageBox.Show("Name:" + selectedWine.name + "\nCountry:" + selectedWine.country
                            + "\nAlcohol:" + selectedWine.alcohol + "\nType of wine:" + selectedWine.typeOfWine);
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (Wines.SelectedIndex < 0)
                return;

            _customerLog.LogCustomerView(_customer.username, listWine[Wines.SelectedIndex].name, "Ocenio");
            _customerLog.LogEvent(_customer.username, "KlikNaOceni");
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (Wines.SelectedIndex < 0)
                return;

            _customerLog.LogCustomerView(_customer.username, listWine[Wines.SelectedIndex].name, "Komentarisao");
            _customerLog.LogEvent(_customer.username, "KlikNaKomentarisi");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Wines.SelectedIndex < 0)
                return;

            _customerLog.LogCustomerView(_customer.username, listWine[Wines.SelectedIndex].name, "Narucio");
            _customerLog.LogEvent(_customer.username, "KlikNaNaruciti");
        }

        private void Wines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Wines.SelectedIndex < 0)
                return;

            _customerLog.LogCustomerView(_customer.username, listWine[Wines.SelectedIndex].name, "KlikNaNaziv");
        }

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRate_MouseEnter(object sender, EventArgs e)
        {
            btnRate.ForeColor = Color.PaleTurquoise;
        }

        private void btnRate_MouseHover_1(object sender, EventArgs e)
        {
            btnRate.ForeColor = Color.PaleTurquoise;
        }

        private void btnRate_MouseLeave(object sender, EventArgs e)
        {
            btnRate.ForeColor = Color.DarkSlateGray;
        }

        private void btnComment_MouseEnter(object sender, EventArgs e)
        {
            btnComment.ForeColor = Color.PaleTurquoise;
        }

        private void btnComment_MouseHover_1(object sender, EventArgs e)
        {
            btnComment.ForeColor = Color.PaleTurquoise;
        }

        private void btnComment_MouseLeave(object sender, EventArgs e)
        {
            btnComment.ForeColor = Color.DarkSlateGray;
        }

        private void btnDetails_MouseEnter(object sender, EventArgs e)
        {
            btnDetails.ForeColor = Color.PaleTurquoise;
        }

        private void btnDetails_MouseHover_1(object sender, EventArgs e)
        {
            btnDetails.ForeColor = Color.PaleTurquoise;
        }

        private void btnDetails_MouseLeave(object sender, EventArgs e)
        {
            btnDetails.ForeColor = Color.DarkSlateGray;
        }

        private void btnOrder_MouseEnter(object sender, EventArgs e)
        {
            btnOrder.ForeColor = Color.PaleTurquoise;
        }

        private void btnOrder_MouseHover_1(object sender, EventArgs e)
        {
            btnOrder.ForeColor = Color.PaleTurquoise;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.ForeColor = Color.DarkSlateGray;
        }
    }
}
