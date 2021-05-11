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
    public partial class StorageBoxesManagementfrm : Form
    {
        public StorageBoxesManagementfrm()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

        }

        private void StorageBoxesManagementfrm_Load(object sender, EventArgs e)
        {
            List<string> lstTab = new List<string>();

            dvgStorageBoxes.ColumnCount = 2;
            //option for display
            dvgStorageBoxes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgStorageBoxes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgStorageBoxes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgStorageBoxes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dvgStorageBoxes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dvgStorageBoxes.GridColor = Color.Black;

            //columns name
            dvgStorageBoxes.Columns[0].Name = "Nom du casier";
            dvgStorageBoxes.Columns[1].Name = "Emplacement - description";
            dvgStorageBoxes.Columns[0].Width = 130;

            List<StorageBoxes> lstBox = StorageBoxes.ShowAllBoxes();
            foreach (StorageBoxes box in lstBox)
            {
                string[] row = { box.Name, box.Description };
                dvgStorageBoxes.Rows.Add(row);
            }
        }
    }
}
