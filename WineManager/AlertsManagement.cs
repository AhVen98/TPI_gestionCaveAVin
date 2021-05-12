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
        public AlertsManagementfrm()
        {
            InitializeComponent();
        }

        private void AlertsManagementfrm_Load(object sender, EventArgs e)
        {
            List<string> lstTab = new List<string>();

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
    }
}
