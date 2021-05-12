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

            //column width - default : 100px
            dvgBottles.Columns[0].Width = 55;
            dvgBottles.Columns[3].Width = 45;
            dvgBottles.Columns[4].Width = 50;
            dvgBottles.Columns[5].Width = 55;


            //columns name
            dvgBottles.Columns[1].Name = "Nom du vin";
            dvgBottles.Columns[2].Name = "Producteur";
            dvgBottles.Columns[3].Name = "Année";
            dvgBottles.Columns[4].Name = "Volume";
            dvgBottles.Columns[5].Name = "Couleurs";
            dvgBottles.Columns[6].Name = "Cépage(s)";
            dvgBottles.Columns[7].Name = "Description";
            dvgBottles.Columns[0].Name = "Quantité";

            List<Bottles> lstBottle = Bottles.ShowAllBottles();
            foreach (Bottles bot in lstBottle)
            {
               string[] row = { bot.BottleNumber.ToString(), bot.Name, bot.Manufacturer, bot.Year.ToString(), bot.Volume.ToString(), bot.Color, bot.Varietal.ToString(), bot.Description, };
               dvgBottles.Rows.Add(row);
            }
        }

            private void BtnMainPage_Click(object sender, EventArgs e)
        {
            //ShowMainPage();
        }

        private void radAddBottle_CheckedChanged(object sender, EventArgs e)
        {
                grpAdd.Visible = true;
                grpDel.Visible = false;
                btnAdd.Visible = true;
                btnDel.Visible = false;       
        }

        private void radDelBottles_CheckedChanged(object sender, EventArgs e)
        {
                grpDel.Visible = true;
                btnDel.Visible = true; 
                grpAdd.Visible = false;
                btnAdd.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string wineName;
            int number;
            string year;
            string description;

            wineName = txtBottleName.Text;
            bool successNumber = Int32.TryParse(txtNumber.Text, out number);

            //if all tests are okay, check 
            if (successNumber == true)
            {
                if (number < 1)
                {
                    MessageBox.Show("Le nombre de bouteilles spécifié n'est pas valide.");
                    txtNumber.Text = "";
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Le nombre de bouteilles spécifié n'est pas valide.");
                txtNumber.Text = "";
            }
        }
    }
}
