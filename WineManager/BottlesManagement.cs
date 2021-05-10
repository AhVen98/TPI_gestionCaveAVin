using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineManager;

namespace WineManager
{
    public partial class BottlesManagementfrm : Form
    {
        public BottlesManagementfrm()
        {
            InitializeComponent();
        }

        private void BottlesManagementfrm_Load(object sender, EventArgs e)
        {
            List<string> lstTab = new List<string>();

            dvgBottles.ColumnCount = 8;
            //option for display
            dvgBottles.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgBottles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgBottles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgBottles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgBottles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgBottles.GridColor = Color.Black;

            //columns name
            dvgBottles.Columns[0].Name = "Nom du vin";
            dvgBottles.Columns[1].Name = "Producteur";
            dvgBottles.Columns[2].Name = "xxx";
            dvgBottles.Columns[3].Name = "xxx";
            dvgBottles.Columns[4].Name = "xxx";
            dvgBottles.Columns[5].Name = "xxx";
            dvgBottles.Columns[6].Name = "xxx";
            dvgBottles.Columns[7].Name = "xxx";
            dvgBottles.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            //List<Bottles> lstBottle = Bottles.Load();
            //foreach (Bottles bot in lstBottle)
            {
               // string[] row = { bot.Name, bot.Manufacturer, bot.State, bot.Renter, bot.ExpectedReturn.ToString(), bot.ID.ToString() };
               // dvgBottles.Rows.Add(row);
            }
        }

            private void BtnMainPage_Click(object sender, EventArgs e)
        {

        }

    }
}
