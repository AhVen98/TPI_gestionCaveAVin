using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace WineManager
{
    public partial class Researchfrm : Form
    {
        List<Bottles> lstBottle = new List<Bottles>();
        public Researchfrm()
        {
            InitializeComponent();
        }

        private void Researchfrm_Load(object sender, EventArgs e)
        {
            List<string> lstTab = new List<string>();

            // get a list of all bottles in DB
            lstBottle = Bottles.ShowAllBottles();
            
            LoadData(lstBottle);
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            string keyword;
            if (txtResearch.Text != "")
            {
                keyword = txtResearch.Text;
                lstBottle = Bottles.ResearchByKeyword(keyword);
                // method to reload the data, specifying the data to use
                LoadData(lstBottle);
            }
            else
            {
                MessageBox.Show("Sans texte de reserche, cela ne fonctionnera pas");
            }
        }

        /**
         * method to load the data in datagridview
         * the lst parameter is the list to be shown on the application
         */
        private void LoadData(List<Bottles> lst)
            {
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

            //delete all datas already contained in the datagridview
            dvgBottles.Rows.Clear();

            foreach (Bottles bot in lst)
                {
                    string[] row = { bot.BottleNumber.ToString(), bot.Name, bot.Manufacturer, bot.Year.ToString(), bot.Volume.ToString(), bot.Color, bot.Varietal.ToString(), bot.Description, bot.Storage };
                    dvgBottles.Rows.Add(row);
                }
            }


        /**
         * method to order the list by wineColor
         */
        private void radColor_Click(object sender, EventArgs e)
        {
            
            lstBottle = Bottles.OrderByColor();
            // method to reload the data, specifying the data to use
            LoadData(lstBottle);
        }


        /**
         * method to order the list by manufacturer
         */
        private void radManufacturer_Click(object sender, EventArgs e)
        {
            List<Bottles> lstBottle = new List<Bottles>();

            lstBottle = Bottles.OrderByManufacturer();
            // method to reload the data, specifying the data to use
            LoadData(lstBottle);
        }


        /**
         * method to order the list by country
         */
        private void radCountry_Click(object sender, EventArgs e)
        {
            lstBottle = Bottles.OrderByCountry();
            // method to reload the data, specifying the data to use
            LoadData(lstBottle);
        }


        /**
         * method to order the list by varietal
         */
        private void radVariety_Click(object sender, EventArgs e)
        {
            lstBottle = Bottles.OrderByVarietal();
            // method to reload the data, specifying the data to use
            LoadData(lstBottle);
        }


        
        private Table CreateTable(List<Bottles> lst)
        {
            // Getting Rows & Columns Counts
            int numRow = lst.Count();
            int numCol = 9;

            // defining the header for the table
            string hName = "Nom du vin";
            string hQuantity = "Quantité";
            string hManufacturer = "Producteur";
            string hYear = "Année";
            string hVolume = "Volume";
            string hColor = "Couleur";
            string hVarietal = "Cépage(s)";
            string hDescription = "Description";
            string hStorage = "Casier";


            // Set The Table like new float [] {15f, 15f, 15f, 15f, 15f }
            Table table = new Table(numCol);
            table.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

            // Printing the header with values
            Cell cellStorage = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                cellStorage.Add(new Paragraph(hStorage));
            table.AddHeaderCell(cellStorage);
            Cell cellName = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellName.Add(new Paragraph(hName));  
            table.AddHeaderCell(cellName);
            Cell cellQuantity = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellQuantity.Add(new Paragraph(hQuantity));
            table.AddHeaderCell(cellQuantity);
            Cell cellManufacturer = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellManufacturer.Add(new Paragraph(hManufacturer));
            table.AddHeaderCell(cellManufacturer);
            Cell cellYear = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellYear.Add(new Paragraph(hYear));
            table.AddHeaderCell(cellYear);
            Cell cellVolume= new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellVolume.Add(new Paragraph(hVolume));
            table.AddHeaderCell(cellVolume);
            Cell cellColor = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellColor.Add(new Paragraph(hColor));
            table.AddHeaderCell(cellColor);
            Cell cellVarietal = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellVarietal.Add(new Paragraph(hVarietal));
            table.AddHeaderCell(cellVarietal);
            Cell cellDescription = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            cellDescription.Add(new Paragraph(hDescription));
            table.AddHeaderCell(cellDescription);

            
            
            // Print The DGV Cells To Table Cells
            foreach (Bottles bot in lst)
            {
                // defining the values to add to the table
                string tName = bot.Name;
                string tQuantity = bot.BottleNumber.ToString();
                string tManufacturer = bot.Manufacturer;
                string tYear = bot.Year.ToString();
                string tVolume = bot.Volume.ToString();
                string tColor = bot.Color;
                string tVarietal = bot.Varietal;
                string tDescription = bot.Description;
                string tStorage = bot.Storage;
                for(int i = 0; i < numCol; i++)
                {
                // adding the values to the corresponding cell
                Cell tcellStorage = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellStorage.Add(new Paragraph(tStorage));
                table.AddCell(cellStorage);
                Cell tcellName= new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellName.Add(new Paragraph(tName));
                table.AddCell(tcellName);
                Cell tcellQuantity = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellQuantity.Add(new Paragraph(tQuantity));
                table.AddCell(tcellQuantity);
                Cell tcellManufacturer = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellManufacturer.Add(new Paragraph(tManufacturer));
                table.AddCell(tcellManufacturer);
                Cell tcellYear = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellYear.Add(new Paragraph(tYear));
                table.AddCell(tcellYear);
                Cell tcellVolume = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellVolume.Add(new Paragraph(tVolume));
                table.AddCell(tcellVolume);
                Cell tcellColor = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellColor.Add(new Paragraph(tColor));
                table.AddCell(tcellColor);
                Cell tcellVarietal = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellVarietal.Add(new Paragraph(tVarietal));
                table.AddCell(tcellVarietal);
                Cell tcellDescription = new Cell()
                              .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                              .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                tcellDescription.Add(new Paragraph(tDescription));
                table.AddCell(tcellDescription);
                }
            }

            return table;
        }
        

        private void btnPDF_Click(object sender, EventArgs e)
        {
            {
                List<Bottles> listBottle = new List<Bottles>();
                //check which order by is selected, select the correct list depending on that
                if (radColor.Checked)
                {
                    listBottle = Bottles.OrderByColor();
                }
                else if (radCountry.Checked)
                {
                    listBottle = Bottles.OrderByCountry();
                }
                else if (radManufacturer.Checked)
                {
                    listBottle = Bottles.OrderByManufacturer();
                }
                else if (radVariety.Checked)
                {
                    listBottle = Bottles.OrderByVarietal();
                }
                else if (txtResearch.Text!= "")
                {
                    listBottle = Bottles.ResearchByKeyword(txtResearch.Text);
                }
                //if no ordering, select all bottles as they are in DB
                else
                {
                    listBottle = Bottles.ShowAllBottles();
                }


                // Must have write permissions to the path folder
                PdfWriter writer = new PdfWriter("C:\\Demo.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                Paragraph header = new Paragraph("HEADER")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);

                document.Add(header);
                Table table = CreateTable(listBottle);
                //document.Add(table);
                document.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}