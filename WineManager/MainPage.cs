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
    public partial class MainPagefrm : Form
    {
        DBConnection connDB = new DBConnection();

        public MainPagefrm()
        {
            InitializeComponent();
        }

        private void GestionDesBouteillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BottlesManagementfrm frmBottle = new BottlesManagementfrm();
            //HideMainPage();
            frmBottle.Show();
        }

        private void GestionDesCasiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageBoxesManagementfrm frmStorage = new StorageBoxesManagementfrm();
            //HideMainPage();
            frmStorage.Show();
        }

        private void GérerLesAlertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlertsManagementfrm frmAlert = new AlertsManagementfrm();
            //HideMainPage();
            frmAlert.Show();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Researchfrm frmSearch = new Researchfrm();
            //HideMainPage();
            frmSearch.Show();
        }

        private void AfficherLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //HideMainPage();
            Logsfrm frmLog = new Logsfrm();
            frmLog.Show();
        }

        public void HideMainPage()
        {
            this.Hide();
        }

        public void ShowMainPage()
        {
            this.Show();
        }
    }
}
