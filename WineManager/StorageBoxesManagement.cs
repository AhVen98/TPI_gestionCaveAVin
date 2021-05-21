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
        DBRequest req = new DBRequest();
        public StorageBoxesManagementfrm()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {

        }

        private void StorageBoxesManagementfrm_Load(object sender, EventArgs e)
        {
            grpDel.Hide();
            grpAdd.Show();

            LoadData();
        }

        private void LoadData()
        {
            //initializing the list for the storage to delete
            List<string> lstStorages = new List<string>();

            //list for all manufacturer in "add a bottle" and "remove a bottle"
            lstStorages = req.GetListStorages();
            for (int i = 0; i < lstStorages.Count; i++)
            {
                comboStorage.Items.Add(lstStorages[i].ToString());
            }

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

        private void radAddStorage_Click(object sender, EventArgs e)
        {
            grpAdd.Show();
            grpDel.Hide();
        }

        private void radDelStorage_Click(object sender, EventArgs e)
        {
            grpDel.Show();
            grpAdd.Hide();
        }

        private void btnDelStorage_Click(object sender, EventArgs e)
        {
            bool res = false;

            //check if a storage is selected
            if (comboStorage.SelectedIndex != -1)
            {
                string storage = comboStorage.SelectedItem.ToString();
                List<int> lst = req.CheckStorageEmpty(storage);
                if(lst.Count != 0)
                {
                    MessageBox.Show("Ce casier n'est actuellement pas vide, il n'est pas possible de le supprimer");
                }
                else
                {
                    res = req.RemoveStorage(storage);
                }
            }
            else
            {
                MessageBox.Show("Aucun casier n'a été sélectionné");
            }
            LoadData();
            if (res)
            {
                MessageBox.Show("Le casier a été supprimé avec succès");
            }
        }

        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            bool res = false;
            bool successPresence = req.CheckStoragePresence(txtStorage.Text);

            if (txtStorage.Text == "")
            {
                
                MessageBox.Show("Veuillez spécifier un nom de casier");
            }
            // storage already existing
            else if (successPresence) 
            {
                MessageBox.Show("Un casier portant ce nom est déjà présent.");
            }
            else
            {
                if (rtxtDescription.Text != "")
                {
                    res = req.AddStorage(txtStorage.Text);
                }
                else
                {
                    res = req.AddStorageWDesc(txtStorage.Text, rtxtDescription.Text);
                }

            }
            if (res)
            {
                MessageBox.Show("Le casier a été ajouté avec succès.");
            }
            LoadData();
        }
    }
}
