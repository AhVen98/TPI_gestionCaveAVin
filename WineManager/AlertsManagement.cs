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
            grpAddAlert.Show();
            grpDel.Hide();
            btnAddAlert.Show();
            btnDelAlert.Hide();
        }

        public void LoadData()
        {
            //initializing the lists for the dropdown field
            List<string> lstWines;
            List<string> listAlerts;

            //clearing already present data
            comboAlertOUT.Items.Clear();
            comboWineChoice.Items.Clear();

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
                dvgBottlesSelected.Rows.Add(row);
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
            //initializing variables to stock informations from the alert
            string alert = "";
            string message = "";
            List<Bottles> lstBottles = new List<Bottles>();

            // initializing the boolean to check if everything is correct -> all is false by default, so that if it works, it changes to true
            bool successAlert = false;
            bool successDel = false;

            /**
             * verification of data type
             * if a field is empty and shouldn't be -> the bottle won't be added
             */
            if (comboAlertOUT.SelectedIndex != -1)
            {
                successAlert = true;
            }

            // all checks passed
            if (successAlert)
            {
                successDel = Alerts.DelAlert(comboAlertOUT.SelectedItem.ToString());

                // message box to show, depending on the result when adding the alert
                if (successDel)
                {
                    MessageBox.Show("L'alerte a été correctement supprimée.");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout de l'alerte. Veuillez réessayer.");
                }
            }
            // problems with at least 1 check
            else
            {
                MessageBox.Show("Une des valeurs spécifiées est incorrecte.");
            }
            LoadData();
            grpAddAlert.Hide();
            grpDel.Show();
        }

        private void btnAddAlert_Click(object sender, EventArgs e)
        {
            //initializing variables to stock informations from the alert
            string alert = "";
            string message = "";
            List<Bottles> lstBottles = new List<Bottles>();

            // initializing the boolean to check if everything is correct -> all is false by default, so that if it works, it changes to true
            bool successAlert = false;
            bool successMessage = false;
            bool successBottles = false;
            bool successFormat = false;
            bool successPresence = false;
            bool successAdd = false;

            /**
             * verification of data type
             * if a field is empty and shouldn't be -> the bottle won't be added
             */
            if (txtAlert.Text != "")
            {
                alert = txtAlert.Text;
                successAlert = true;
            }
            if (rtxtMessage.Text != "")
            {
                message = rtxtMessage.Text;
                successMessage = true;
            }
            if(lstSelectedWines.Count != 0)
            {
                successBottles = true;
            }

            //verify if the bottle to add already exists in database -> true : present, false : non present
            
            // occur uniquely if the volume, the name and the year have been validated
            if (successAlert && successMessage)
            {
                successPresence = req.CheckAlertPresence(alert);
            }
            // if all verification are ok -> will be true, otherwise, will be false
            successFormat = successMessage && successAlert && successBottles && !successPresence;
            // all checks passed
            if (successFormat)
            {
                // adding the alert to the DB
                successAdd = Alerts.AddAlert(alert, message);
                foreach(Bottles bot in lstSelectedWines)
                {
                    Bottles.AddAlertToBottle(bot.Name, alert);
                }

                // message box to show, depending on the result when adding the alert
                if (successAdd)
                {
                    MessageBox.Show("L'ajout de l'alerte a été effectué correctement.");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout de l'alerte. Veuillez réessayer.");
                }
            }
            // problems with at least 1 check
            else
            {
                MessageBox.Show("Une des valeurs spécifiées est incorrecte.");
                txtAlert.Text = "";
                rtxtMessage.Text = "";
                comboWineChoice.Items.Clear();
            }
            LoadData();
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
