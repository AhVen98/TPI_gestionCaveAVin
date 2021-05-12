
namespace WineManager
{
    partial class AlertsManagementfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMainPage = new System.Windows.Forms.Button();
            this.grpAddAlert = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddBottle = new System.Windows.Forms.Button();
            this.grpDel = new System.Windows.Forms.GroupBox();
            this.lblAlertNameOUT = new System.Windows.Forms.Label();
            this.comboWine = new System.Windows.Forms.ComboBox();
            this.lblSelectedBottles = new System.Windows.Forms.Label();
            this.lblWines = new System.Windows.Forms.Label();
            this.comboWineChoice = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAlertName = new System.Windows.Forms.Label();
            this.txtBottleName = new System.Windows.Forms.TextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.radDelAlerts = new System.Windows.Forms.RadioButton();
            this.radAddAlert = new System.Windows.Forms.RadioButton();
            this.dvgBottles = new System.Windows.Forms.DataGridView();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.btnAddAlert = new System.Windows.Forms.Button();
            this.btnDelAlert = new System.Windows.Forms.Button();
            this.grpAddAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDel.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(670, 12);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(118, 52);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "Retourner à la page principale";
            this.btnMainPage.UseVisualStyleBackColor = true;
            // 
            // grpAddAlert
            // 
            this.grpAddAlert.Controls.Add(this.dataGridView1);
            this.grpAddAlert.Controls.Add(this.btnAddBottle);
            this.grpAddAlert.Controls.Add(this.grpDel);
            this.grpAddAlert.Controls.Add(this.lblSelectedBottles);
            this.grpAddAlert.Controls.Add(this.lblWines);
            this.grpAddAlert.Controls.Add(this.comboWineChoice);
            this.grpAddAlert.Controls.Add(this.lblDesc);
            this.grpAddAlert.Controls.Add(this.rtxtDescription);
            this.grpAddAlert.Controls.Add(this.lblAlertName);
            this.grpAddAlert.Controls.Add(this.txtBottleName);
            this.grpAddAlert.Location = new System.Drawing.Point(12, 70);
            this.grpAddAlert.Name = "grpAddAlert";
            this.grpAddAlert.Size = new System.Drawing.Size(776, 124);
            this.grpAddAlert.TabIndex = 1;
            this.grpAddAlert.TabStop = false;
            this.grpAddAlert.Text = "Ajouter une alerte";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(375, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 55);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnAddBottle
            // 
            this.btnAddBottle.Location = new System.Drawing.Point(715, 17);
            this.btnAddBottle.Name = "btnAddBottle";
            this.btnAddBottle.Size = new System.Drawing.Size(55, 23);
            this.btnAddBottle.TabIndex = 18;
            this.btnAddBottle.Text = "Ajouter";
            this.btnAddBottle.UseVisualStyleBackColor = true;
            // 
            // grpDel
            // 
            this.grpDel.Controls.Add(this.lblAlertNameOUT);
            this.grpDel.Controls.Add(this.comboWine);
            this.grpDel.Location = new System.Drawing.Point(0, 1);
            this.grpDel.Name = "grpDel";
            this.grpDel.Size = new System.Drawing.Size(776, 123);
            this.grpDel.TabIndex = 0;
            this.grpDel.TabStop = false;
            this.grpDel.Text = "Supprimer une alerte";
            // 
            // lblAlertNameOUT
            // 
            this.lblAlertNameOUT.AutoSize = true;
            this.lblAlertNameOUT.Location = new System.Drawing.Point(6, 28);
            this.lblAlertNameOUT.Name = "lblAlertNameOUT";
            this.lblAlertNameOUT.Size = new System.Drawing.Size(81, 13);
            this.lblAlertNameOUT.TabIndex = 1;
            this.lblAlertNameOUT.Text = "Nom de l\'alerte*";
            // 
            // comboWine
            // 
            this.comboWine.FormattingEnabled = true;
            this.comboWine.Location = new System.Drawing.Point(110, 25);
            this.comboWine.Name = "comboWine";
            this.comboWine.Size = new System.Drawing.Size(256, 21);
            this.comboWine.TabIndex = 7;
            // 
            // lblSelectedBottles
            // 
            this.lblSelectedBottles.AutoSize = true;
            this.lblSelectedBottles.Location = new System.Drawing.Point(372, 47);
            this.lblSelectedBottles.Name = "lblSelectedBottles";
            this.lblSelectedBottles.Size = new System.Drawing.Size(120, 13);
            this.lblSelectedBottles.TabIndex = 17;
            this.lblSelectedBottles.Text = "Bouteilles sélectionnées";
            // 
            // lblWines
            // 
            this.lblWines.AutoSize = true;
            this.lblWines.Location = new System.Drawing.Point(372, 22);
            this.lblWines.Name = "lblWines";
            this.lblWines.Size = new System.Drawing.Size(122, 13);
            this.lblWines.TabIndex = 17;
            this.lblWines.Text = "Bouteilles liées à l\'alerte*";
            // 
            // comboWineChoice
            // 
            this.comboWineChoice.FormattingEnabled = true;
            this.comboWineChoice.Location = new System.Drawing.Point(500, 18);
            this.comboWineChoice.Name = "comboWineChoice";
            this.comboWineChoice.Size = new System.Drawing.Size(209, 21);
            this.comboWineChoice.TabIndex = 16;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 50);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(98, 13);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Message de l\'alerte";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(110, 47);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(256, 71);
            this.rtxtDescription.TabIndex = 8;
            this.rtxtDescription.Text = "";
            // 
            // lblAlertName
            // 
            this.lblAlertName.AutoSize = true;
            this.lblAlertName.Location = new System.Drawing.Point(6, 22);
            this.lblAlertName.Name = "lblAlertName";
            this.lblAlertName.Size = new System.Drawing.Size(81, 13);
            this.lblAlertName.TabIndex = 1;
            this.lblAlertName.Text = "Nom de l\'alerte*";
            // 
            // txtBottleName
            // 
            this.txtBottleName.Location = new System.Drawing.Point(110, 19);
            this.txtBottleName.Name = "txtBottleName";
            this.txtBottleName.Size = new System.Drawing.Size(256, 20);
            this.txtBottleName.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.radDelAlerts);
            this.grpActions.Controls.Add(this.radAddAlert);
            this.grpActions.Location = new System.Drawing.Point(12, 12);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(652, 52);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Que souhaitez-vous faire ?";
            // 
            // radDelAlerts
            // 
            this.radDelAlerts.AutoSize = true;
            this.radDelAlerts.Location = new System.Drawing.Point(403, 29);
            this.radDelAlerts.Name = "radDelAlerts";
            this.radDelAlerts.Size = new System.Drawing.Size(122, 17);
            this.radDelAlerts.TabIndex = 1;
            this.radDelAlerts.Text = "Supprimer une alerte";
            this.radDelAlerts.UseVisualStyleBackColor = true;
            // 
            // radAddAlert
            // 
            this.radAddAlert.AutoSize = true;
            this.radAddAlert.Checked = true;
            this.radAddAlert.Location = new System.Drawing.Point(158, 29);
            this.radAddAlert.Name = "radAddAlert";
            this.radAddAlert.Size = new System.Drawing.Size(108, 17);
            this.radAddAlert.TabIndex = 0;
            this.radAddAlert.TabStop = true;
            this.radAddAlert.Text = "Ajouter une alerte";
            this.radAddAlert.UseVisualStyleBackColor = true;
            // 
            // dvgBottles
            // 
            this.dvgBottles.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgBottles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBottles.Location = new System.Drawing.Point(12, 235);
            this.dvgBottles.Name = "dvgBottles";
            this.dvgBottles.Size = new System.Drawing.Size(776, 277);
            this.dvgBottles.TabIndex = 5;
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.Location = new System.Drawing.Point(18, 219);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(151, 13);
            this.lblAlerts.TabIndex = 6;
            this.lblAlerts.Text = "Alertes actuellement présentes";
            // 
            // btnAddAlert
            // 
            this.btnAddAlert.Location = new System.Drawing.Point(670, 200);
            this.btnAddAlert.Name = "btnAddAlert";
            this.btnAddAlert.Size = new System.Drawing.Size(118, 23);
            this.btnAddAlert.TabIndex = 7;
            this.btnAddAlert.Text = "Ajouter l\'alerte";
            this.btnAddAlert.UseVisualStyleBackColor = true;
            // 
            // btnDelAlert
            // 
            this.btnDelAlert.Location = new System.Drawing.Point(670, 200);
            this.btnDelAlert.Name = "btnDelAlert";
            this.btnDelAlert.Size = new System.Drawing.Size(118, 23);
            this.btnDelAlert.TabIndex = 7;
            this.btnDelAlert.Text = "Supprimer l\'alerte";
            this.btnDelAlert.UseVisualStyleBackColor = true;
            // 
            // AlertsManagementfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnDelAlert);
            this.Controls.Add(this.btnAddAlert);
            this.Controls.Add(this.lblAlerts);
            this.Controls.Add(this.dvgBottles);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpAddAlert);
            this.Controls.Add(this.btnMainPage);
            this.Name = "AlertsManagementfrm";
            this.Text = "Gestion des alertes";
            this.Load += new System.EventHandler(this.AlertsManagementfrm_Load);
            this.grpAddAlert.ResumeLayout(false);
            this.grpAddAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDel.ResumeLayout(false);
            this.grpDel.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.GroupBox grpAddAlert;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.RadioButton radDelAlerts;
        private System.Windows.Forms.RadioButton radAddAlert;
        private System.Windows.Forms.GroupBox grpDel;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblAlertName;
        private System.Windows.Forms.TextBox txtBottleName;
        private System.Windows.Forms.Label lblAlertNameOUT;
        private System.Windows.Forms.ComboBox comboWine;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridView dvgBottles;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddBottle;
        private System.Windows.Forms.Label lblSelectedBottles;
        private System.Windows.Forms.Label lblWines;
        private System.Windows.Forms.ComboBox comboWineChoice;
        private System.Windows.Forms.Button btnAddAlert;
        private System.Windows.Forms.Button btnDelAlert;
    }
}