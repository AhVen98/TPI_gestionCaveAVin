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
        DBRequest req = new DBRequest();
        public BottlesManagementfrm()
        {
            InitializeComponent();
            
        }

        private void BottlesManagementfrm_Load(object sender, EventArgs e)
        {
            grpDel.Visible = false;
            btnDel.Visible = false;

            LoadData();

            /**
             * load all lists for the drop down fields, to be able to add bottles
             */
            //initializing the lists for the dropdown field
            List<string> lstManufacturers;
            List<string> lstColors;
            List<string> lstVarieties;
            List<double> lstVolumes;
            List<string> lstStorages;
            List<string> lstWines;
            List<int> lstYears;

            //list for all manufacturer in "add a bottle" and "remove a bottle"
            lstManufacturers = req.GetListManufacturers();
            for (int i = 0; i < lstManufacturers.Count; i++)
            {
                comboManufacturer.Items.Add(lstManufacturers[i].ToString());
                comboManufacturerOUT.Items.Add(lstManufacturers[i].ToString());
            }

            //list for all colors in "add a bottle"
            lstColors = req.GetListColors();
            for (int i = 0; i < lstColors.Count; i++)
            {
                comboColor.Items.Add(lstColors[i].ToString());
            }

            //list for possible volumes in "add a bottle" and "remove a bottle"
            // fixed -> to enable other volumes, it has to be added in the list 
            lstVolumes = new List<double>() { 0.2, 0.375, 0.5, 0.75, 1.0, 1.5, 3 };
            for (int i = 0; i < lstVolumes.Count; i++)
            {
                comboVolume.Items.Add(lstVolumes[i].ToString());
                comboVolumeOUT.Items.Add(lstVolumes[i].ToString());
            }

            /** 
             * list for all varieties in "add a bottle"
             * there are 3 dropdown fields with the same list, so all are initialized at the same time
             */
            lstVarieties = req.GetListVarieties();
            for (int i = 0; i < lstVarieties.Count; i++)
            {
                comboVariety1.Items.Add(lstVarieties[i].ToString());
                comboVariety2.Items.Add(lstVarieties[i].ToString());
                comboVariety3.Items.Add(lstVarieties[i].ToString());
            }

            //list for all storageBoxes in "add a bottle"
            lstStorages = req.GetListStorages();
            for (int i = 0; i < lstStorages.Count; i++)
            {
                comboStorage.Items.Add(lstStorages[i].ToString());
            }

            //list for all years in "remove a bottle"
            lstYears = req.GetListDistinctYears();
            for (int i = 0; i < lstYears.Count; i++)
            {
                comboYearOUT.Items.Add(lstYears[i].ToString());
            }

            lstWines = req.GetListWines();
            for (int i = 0; i < lstWines.Count; i++)
            {
                comboWine.Items.Add(lstWines[i].ToString());
            }


        }

        private void BtnMainPage_Click(object sender, EventArgs e)
        {
            //ShowMainPage();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //initializing variables to stock informations from the wine bottle
            string wineName = "";
            string manufacturer = "";
            int number = 0;
            double volume = 0;
            int year = 0;

            // initializing the boolean to check if everything is correct -> all is false by default, so that if it works, it changes to true
            bool successName = false;
            bool successManu = false;
            bool successNumber = false;
            bool successYear = false;
            bool successVolume = false;
            bool successFormat = false;
            bool successPresence = false;
            bool successOut = false;
            bool successAlert = false;
            bool successLog = false;

            /**
             * verification of data type
             * if a field is empty and shouldn't be -> the bottle won't get out
             */
            if (comboWine.SelectedIndex != -1)
            {
                wineName = comboWine.SelectedItem.ToString();
                successName = true;
            }
            if (comboVolumeOUT.SelectedIndex != -1)
            {
                successVolume = Double.TryParse(comboVolumeOUT.SelectedItem.ToString(), out volume);
            }
            if (comboManufacturerOUT.SelectedIndex != -1)
            {
                manufacturer = comboManufacturerOUT.SelectedItem.ToString();
                successManu = true;
            }
            if (txtNumberOUT.Text != "")
            {
                successNumber = Int32.TryParse(txtNumberOUT.Text, out number);
                if (number < 1)
                {
                    MessageBox.Show("Le nombre de bouteilles spécifié n'est pas valide.");
                    txtNumberOUT.Text = "";
                }
            }
            if (comboYearOUT.SelectedIndex != -1)
            {
                successYear = Int32.TryParse(comboYearOUT.SelectedItem.ToString(), out year);
            }

            //verify if the bottle to delete already exists in database -> true : present, false : non present
            // occur uniquely if the volume, the name and the year have been validated
            if (successVolume && successName && successYear)
            {
                successPresence = req.CheckBottlePresence(wineName, year, volume);
            }
            // if all verification are ok -> will be true, otherwise, will be false
            successFormat = successNumber && successYear && successName && successManu ;
            successAlert = req.CheckAlertPresenceByBottleName(wineName);
            // all checks passed, bottle present in DB
            if (successFormat == true && successPresence)
            {
                if (successAlert)
                {
                    MessageBox.Show("Attention, cette bouteille est prévue pour un évènement !!");
                }
                successOut = Bottles.RemoveBottle(wineName, number, volume, manufacturer, year);
                // message box to show, depending on the result when getting the right number of bottle out
                if (successOut)
                {
                    int wineID = req.GetIDBottleByName(wineName);
                    successLog = Logs.AddLog("retrait", wineID);
                    MessageBox.Show("Le retrait de bouteille(s) a été effectué correctement.");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors du retrait de bouteille(s). Veuillez réessayer.");
                }
            }
            // all checks passed, but the combination of data does not concord with DB
            else if (successFormat == true && !successPresence)
            {
                MessageBox.Show("Cette combinaison de données n'existe pas dans les bouteilles présentes. Veuillez vérifier vos informations.");
            }
            // problems with at least 1 check
            else
            {
                MessageBox.Show("Une des valeurs spécifiées est incorrecte.");
                txtNumber.Text = "";
                txtYear.Text = "";
            }
            LoadData();
        }


        /**
         * when clicking on "adding the bottle", check if every parameter needed is present and if the datatype is correct
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //initializing variables to stock informations from the wine bottle
            string wineName = "";
            string color ="";
            string manufacturer = "";
            string description ="";
            string storage = "";
            int number = 0;
            double volume = 0;
            int year = 0;
            List<string> varietal = new List<string>();

            // initializing variables to compare the logic behind some values
            int actualYear = DateTime.Now.Year;
            // initializing the boolean to check if everything is correct -> all is false by default, so that if it works, it changes to true
            bool successName = false;
            bool successColor = false;
            bool successManu = false;
            bool successStorage = false;
            bool successDescription = false;
            bool successNumber = false;
            bool successYear = false;
            bool successVolume = false;
            bool successVarietal = false;
            bool successFormat = false;
            bool successPresence = false;
            bool successAdd = false;
            bool successLog = false;

            /**
             * verification of data type
             * if a field is empty and shouldn't be -> the bottle won't be added
             */
            if (txtBottleName.Text != "")
            {
                wineName = txtBottleName.Text;
                successName = true;
            }
            if (comboColor.SelectedIndex != -1)
            {
                color = comboColor.SelectedItem.ToString();
                successColor = true;
            }
            if (comboVolume.SelectedIndex != -1)
            {
                successVolume = Double.TryParse(comboVolume.SelectedItem.ToString(), out volume);
            }
            if (comboManufacturer.SelectedIndex != -1)
            {
                manufacturer = comboManufacturer.SelectedItem.ToString();
                successManu = true;
            }
            if (txtNumber.Text != "")
            {
                successNumber = Int32.TryParse(txtNumber.Text, out number);
                if (number < 1)
                {
                    MessageBox.Show("Le nombre de bouteilles spécifié n'est pas valide.");
                    txtNumber.Text = "";
                }
            }
            if(comboStorage.SelectedIndex != -1)
            {
                storage = comboStorage.SelectedItem.ToString();
                successStorage = true;
            }
            if(rtxtDescription.Text != "" && rtxtDescription.TextLength < 200)
            {
                description = rtxtDescription.Text;
                successDescription = true;
            }
            if (txtYear.Text != "")
            {
                successYear = Int32.TryParse(txtYear.Text, out year);
                if (year < 1900 || year > actualYear)
                {
                    MessageBox.Show("L'année de production n'est pas valide.");
                    txtYear.Text = "";
                }
            }
            if(comboVariety1.SelectedIndex != -1 || comboVariety2.SelectedIndex != -1 || comboVariety3.SelectedIndex != -1)
            {
                successVarietal = true;
                if (comboVariety1.SelectedIndex != -1)
                {
                    varietal.Add(comboVariety1.SelectedItem.ToString());
                }
                if (comboVariety2.SelectedIndex != -1)
                {
                    varietal.Add(comboVariety2.SelectedItem.ToString());
                }
                if (comboVariety3.SelectedIndex != -1)
                {
                    varietal.Add(comboVariety3.SelectedItem.ToString());
                }
            }

            successYear = Int32.TryParse(txtYear.Text, out year);
            //verify if the bottle to add already exists in database -> true : present, false : non present
            // occur uniquely if the volume, the name and the year have been validated
            if(successVolume && successName && successYear)
            {
                successPresence = req.CheckBottlePresence(wineName, year, volume);
            }
            // if all verification are ok -> will be true, otherwise, will be false
            successFormat = successNumber && successYear && successName && successColor && successManu && successStorage;
            // all checks passed, bottle not present
            if (successFormat == true && !successPresence)
            {
                // different requests, depending on parameters given
                if (successDescription && successVarietal)
                {
                    successAdd = Bottles.AddBottleWithDescAndVarietal(wineName, color, number, volume, manufacturer, year, storage, varietal, description);
                }   
                else if (successVarietal)
                {
                    successAdd = Bottles.AddBottleWithVarietal(wineName, color, number, volume, manufacturer, year, storage, varietal);
                }
                else if(successDescription)
                {
                    successAdd = Bottles.AddBottleWithDesc(wineName, color, number, volume, manufacturer, year, storage, description);
                }
                else
                {
                    successAdd = Bottles.AddBottle(wineName, color, number, volume, manufacturer, year, storage);
                }
                // message box to show, depending on the result when adding the bottle
                if (successAdd)
                {
                    int wineID = req.GetIDBottleByName(wineName);
                    successLog = Logs.AddLog("ajoutNouvelle", wineID);
                    MessageBox.Show("L'ajout de la bouteille a été effectué correctement.");    
                }  
                else    
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout de la bouteille. Veuillez réessayer.");
                }
            }
            // all checks passed, bottle already present
            else if(successFormat == true && successPresence)
            {
                successAdd = Bottles.UpdateBottle(wineName, number, volume, year);
                if (successAdd)
                {
                    int wineID = req.GetIDBottleByName(wineName);
                    successLog = Logs.AddLog("ajoutExistante", wineID);
                    MessageBox.Show("La mise à jour du nombre de bouteilles a été effectuée correctement.");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour du nombre de bouteilles. Veuillez réessayer.");
                }
            }
            // problems with at least 1 check
            else
            {
                MessageBox.Show("Une des valeurs spécifiées est incorrecte.");
                txtNumber.Text = "";
                txtYear.Text = "";
            }
            LoadData();
        }


        /**
         * when clicking the add bottle radio button 
         * -> show the form and the button to delete a bottle
         * -> hide the form and the button to add a bottle
         */
        private void radDelBottles_Click(object sender, EventArgs e)
        {
            grpAdd.Hide();
            btnAdd.Hide();
            grpDel.Show();
            btnDel.Show();
        }

        /**
         * when clicking the add bottle radio button 
         * -> show the form and the button to add a bottle
         * -> hide the form and the button to delete a bottle
         */
        private void radAddBottle_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpDel.Visible = false;
            btnAdd.Visible = true;
            btnDel.Visible = false;
        }


        /**
         * method to load all data pertaining to the bottles, to show them on screen
         */
        private void LoadData()
        {
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

            //delete all datas already contained in the datagridview
            dvgBottles.Rows.Clear();

            List<Bottles> lstBottle = Bottles.ShowAllBottles();
            foreach (Bottles bot in lstBottle)
            {
                string[] row = { bot.BottleNumber.ToString(), bot.Name, bot.Manufacturer, bot.Year.ToString(), bot.Volume.ToString(), bot.Color, bot.Varietal.ToString(), bot.Description };
                dvgBottles.Rows.Add(row);
            }

        }
    }
}
