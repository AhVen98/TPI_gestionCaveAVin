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
    public partial class Researchfrm : Form
    {
        public Researchfrm()
        {
            InitializeComponent();
        }

        private void Researchfrm_Load(object sender, EventArgs e)
        {
            /**
             * load all values for the summary of bottles
             */
            List<string> lstTab = new List<string>();

            dvgBottles.ColumnCount = 9;
            //option for display
            dvgBottles.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgBottles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgBottles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgBottles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgBottles.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgBottles.GridColor = Color.Black;

            //column width - default : 100px
            dvgBottles.Columns[0].Width = 55;
            dvgBottles.Columns[3].Width = 45;
            dvgBottles.Columns[4].Width = 50;
            dvgBottles.Columns[5].Width = 55;
            dvgBottles.Columns[8].Width = 55;


            //columns name
            dvgBottles.Columns[1].Name = "Nom du vin";
            dvgBottles.Columns[2].Name = "Producteur";
            dvgBottles.Columns[3].Name = "Année";
            dvgBottles.Columns[4].Name = "Volume";
            dvgBottles.Columns[5].Name = "Couleurs";
            dvgBottles.Columns[6].Name = "Cépage(s)";
            dvgBottles.Columns[7].Name = "Description";
            dvgBottles.Columns[8].Name = "Casier";
            dvgBottles.Columns[0].Name = "Quantité";

            List<Bottles> lstBottle = Bottles.ShowAllBottles();
            foreach (Bottles bot in lstBottle)
            {
                string[] row = { bot.BottleNumber.ToString(), bot.Name, bot.Manufacturer, bot.Year.ToString(), bot.Volume.ToString(), bot.Color, bot.Varietal.ToString(), bot.Description, bot.Storage};
                dvgBottles.Rows.Add(row);
            }
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            string research;
            if(txtResearch != "")
            {
                research = txtResearch.Text;
                Bottles.Research(research);
            }
            else
            {
                MessageBox.Show("Sans texte de reserche, cela ne fonctionnera pas");
            }
        }
    }
}
