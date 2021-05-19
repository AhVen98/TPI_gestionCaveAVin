using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineManager
{
    public partial class AlertsManagementfrm : Form
    {
        DBRequest req = new DBRequest();
        public AlertsManagementfrm()
        {
            InitializeComponent();
        }

        private void AlertsManagementfrm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadSelected();
        }

        public void LoadData()
        {
            //initializing the lists for the dropdown field
            List<string> lstWines;
            List<string> listAlerts;

            //list for all wines in "add an alert"
            lstWines = req.GetListWines();
            for (int i = 0; i < lstWines.Count; i++)
            {
                comboWineChoice.Items.Add(lstWines[i].ToString());
            }

            //list for all alerts in "remove an alert"
            listAlerts = req.GetListAlerts();
            for (int i = 0; i < listAlerts.Count; i++)
            {
                comboAlertOUT.Items.Add(listAlerts[i].ToString());
            }


            grpAddAlert.Show();
            grpDel.Hide();

            dvgBottles.ColumnCount = 3;
            //option for display
            dvgBottles.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgBottles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgBottles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgBottles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgBottles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgBottles.GridColor = Color.Black;

            //columns name
            dvgBottles.Columns[0].Name = "Nom du casier";
            dvgBottles.Columns[1].Name = "Emplacement - description";
            dvgBottles.Columns[2].Name = "Bouteilles associées";
            dvgBottles.Columns[0].Width = 130;

            List<Alerts> lstAlert = Alerts.ShowAllAlerts();
            foreach (Alerts alert in lstAlert)
            {
                string[] row = { alert.Name, alert.Message, alert.LinkedBottles };
                dvgBottles.Rows.Add(row);
            }

        }

        public void LoadSelected()
        {
            dvgBottles.ColumnCount = 3;
            //option for display
            dvgBottles.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgBottles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgBottles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgBottles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgBottles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgBottles.GridColor = Color.Black;

            //columns name
            dvgBottles.Columns[0].Name = "Nom du vin";
            dvgBottles.Columns[1].Name = "Année";
            dvgBottles.Columns[2].Name = "Contenance";
            dvgBottles.Columns[0].Width = 130;

            List<Bottles> lstSelectedWines = new List<Bottles>();
            foreach (Bottles bot in lstSelectedWines)
            {
                string[] row = { bot.Name, bot.Year.ToString(), bot.Volume.ToString() };
                dvgBottles.Rows.Add(row);
            }
        }

        private void btnAddBottle_Click(object sender, EventArgs e)
        {
            string wineName = comboWineChoice.SelectedItem.ToString();


            //string[] row = { bot.Name, bot.Year.ToString(), bot.Volume.ToString() };
            //dvgBottles.Rows.Add(row);
            dvgBottlesSelected.Refresh();
        }

        private void btnDelAlert_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAlert_Click(object sender, EventArgs e)
        {

        }

        private void radAddAlert_Click(object sender, EventArgs e)
        {
            grpAddAlert.Show();
            grpDel.Hide();
            btnAddAlert.Show();
            btnDelAlert.Hide();
        }

        private void radDelAlerts_Click(object sender, EventArgs e)
        {
            grpDel.Show();
            grpAddAlert.Hide();
            btnDelAlert.Show();
            btnAddAlert.Hide();
        }
    }
}
