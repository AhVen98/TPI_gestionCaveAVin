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
    public partial class Logsfrm : Form
    {
        public Logsfrm()
        {
            InitializeComponent();
        }

        private void Logsfrm_Load(object sender, EventArgs e)
        {
            dvgLogs.ColumnCount = 3;
            //option for display
            dvgLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgLogs.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgLogs.GridColor = Color.Black;

            //column width - default : 100px
            dvgLogs.Columns[0].Width = 60;
            dvgLogs.Columns[1].Width = 120;

            //columns name
            dvgLogs.Columns[0].Name = "Date et Heure";
            dvgLogs.Columns[1].Name = "Élément associé";
            dvgLogs.Columns[2].Name = "Action";

            List<Logs> lstLogs = Logs.GetAllLogs();
            foreach (Logs log in lstLogs)
            {
                string[] row = { log.ExactTime.ToString(), log.Element, log.Action };
                dvgLogs.Rows.Add(row);
            }
        }

    }
}
