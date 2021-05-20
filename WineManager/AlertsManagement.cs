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
        List<Bottles> lstSelectedWines = new List<Bottles>();

        public AlertsManagementfrm()
        {
            InitializeComponent();
        }

        private void AlertsManagementfrm_Load(object sender, EventArgs e)
        {
            LoadData();
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

            dvgAlerts.ColumnCount = 3;
            //option for display
            dvgAlerts.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgAlerts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgAlerts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgAlerts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgAlerts.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgAlerts.GridColor = Color.Black;

            //columns name
            dvgAlerts.Columns[0].Name = "Nom de l'alerte";
            dvgAlerts.Columns[1].Name = "Message de l'alerte";
            dvgAlerts.Columns[2].Name = "Bouteilles associées";
            dvgAlerts.Columns[0].Width = 130;

            dvgAlerts.Rows.Clear();

            List<Alerts> lstAlert = Alerts.ShowAllAlerts();
            foreach (Alerts alert in lstAlert)
            {
                string[] row = { alert.Name, alert.Message, alert.LinkedBottles };
                dvgAlerts.Rows.Add(row);
            }

        }

        public void LoadSelectedBottles()
        {
            /**
             * defining the datagrid for "adding an alert"
             */
            dgvSelected.ColumnCount = 3;
            //option for display
            dgvSelected.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvSelected.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSelected.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvSelected.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSelected.GridColor = Color.Black;

            //columns name
            dgvSelected.Columns[0].Name = "Nom du vin";
            dgvSelected.Columns[1].Name = "Année";
            dgvSelected.Columns[2].Name = "Volume";
            dgvSelected.Columns[0].Width = 130;

            dgvSelected.Rows.Clear();

            foreach (Bottles bot in lstSelectedWines)
            {
                string[] row = { bot.Name, bot.Year.ToString(), bot.Volume.ToString() };
                dgvSelected.Rows.Add(row);
            }
        }


        public void LoadBottlesFromAlerts(string alertName)
        {
            int alertID = req.GetAlertIDFromName(alertName);
            /**
             * defining the datagridview for "removing an alert"
             */
            dvgBottlesSelected.ColumnCount = 3;
            //option for display
            dvgBottlesSelected.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgBottlesSelected.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgBottlesSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgBottlesSelected.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgBottlesSelected.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgBottlesSelected.GridColor = Color.Black;

            //columns name
            dvgBottlesSelected.Columns[0].Name = "Nom du vin";
            dvgBottlesSelected.Columns[1].Name = "Année";
            dvgBottlesSelected.Columns[2].Name = "Volume";
            dvgBottlesSelected.Columns[0].Width = 130;

            dvgBottlesSelected.Rows.Clear();

            List<Bottles> lstWinesFromAlert = new List<Bottles>();
            lstWinesFromAlert = Bottles.GetBottlesWithAlert(alertID);
            foreach (Bottles bot in lstWinesFromAlert)
            {
                string[] row = { bot.Name, bot.Year.ToString(), bot.Volume.ToString() };
                dgvSelected.Rows.Add(row);
            }
        }

        private void btnAddBottle_Click(object sender, EventArgs e)
        {
            string wineName;
            LoadSelectedBottles();
            if(comboWineChoice.SelectedIndex != -1)
            {
                wineName = comboWineChoice.SelectedItem.ToString();
                Bottles bot = Bottles.GetBottleWithName(wineName);
                lstSelectedWines.Add(bot);
            }
            else
            {
                MessageBox.Show("Aucune bouteille n'est actuellement sélectionnée");
            }
            LoadSelectedBottles();
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

        private void btnShowBottles_Click(object sender, EventArgs e)
        {
            if(comboAlertOUT.SelectedIndex!= -1)
            {
                LoadBottlesFromAlerts(comboAlertOUT.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Aucune alerte n'est actuellement sélectionnée.");
            }
        }
    }
}
