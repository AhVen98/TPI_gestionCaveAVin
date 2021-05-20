
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
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.btnAddBottle = new System.Windows.Forms.Button();
            this.lblWines = new System.Windows.Forms.Label();
            this.comboWineChoice = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.lblAlertName = new System.Windows.Forms.Label();
            this.txtAlert = new System.Windows.Forms.TextBox();
            this.grpDel = new System.Windows.Forms.GroupBox();
            this.btnShowBottles = new System.Windows.Forms.Button();
            this.dvgBottlesSelected = new System.Windows.Forms.DataGridView();
            this.lblAlertNameOUT = new System.Windows.Forms.Label();
            this.comboAlertOUT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.radDelAlerts = new System.Windows.Forms.RadioButton();
            this.radAddAlert = new System.Windows.Forms.RadioButton();
            this.dvgAlerts = new System.Windows.Forms.DataGridView();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.btnAddAlert = new System.Windows.Forms.Button();
            this.btnDelAlert = new System.Windows.Forms.Button();
            this.grpAddAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.grpDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottlesSelected)).BeginInit();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlerts)).BeginInit();
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
            this.grpAddAlert.Controls.Add(this.dgvSelected);
            this.grpAddAlert.Controls.Add(this.btnAddBottle);
            this.grpAddAlert.Controls.Add(this.lblWines);
            this.grpAddAlert.Controls.Add(this.comboWineChoice);
            this.grpAddAlert.Controls.Add(this.lblDesc);
            this.grpAddAlert.Controls.Add(this.rtxtMessage);
            this.grpAddAlert.Controls.Add(this.lblAlertName);
            this.grpAddAlert.Controls.Add(this.txtAlert);
            this.grpAddAlert.Location = new System.Drawing.Point(12, 70);
            this.grpAddAlert.Name = "grpAddAlert";
            this.grpAddAlert.Size = new System.Drawing.Size(776, 124);
            this.grpAddAlert.TabIndex = 1;
            this.grpAddAlert.TabStop = false;
            this.grpAddAlert.Text = "Ajouter une alerte";
            // 
            // dgvSelected
            // 
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Enabled = false;
            this.dgvSelected.EnableHeadersVisualStyles = false;
            this.dgvSelected.Location = new System.Drawing.Point(348, 43);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.Size = new System.Drawing.Size(422, 75);
            this.dgvSelected.TabIndex = 19;
            // 
            // btnAddBottle
            // 
            this.btnAddBottle.Location = new System.Drawing.Point(715, 16);
            this.btnAddBottle.Name = "btnAddBottle";
            this.btnAddBottle.Size = new System.Drawing.Size(55, 23);
            this.btnAddBottle.TabIndex = 18;
            this.btnAddBottle.Text = "Ajouter";
            this.btnAddBottle.UseVisualStyleBackColor = true;
            this.btnAddBottle.Click += new System.EventHandler(this.btnAddBottle_Click);
            // 
            // lblWines
            // 
            this.lblWines.AutoSize = true;
            this.lblWines.Location = new System.Drawing.Point(380, 22);
            this.lblWines.Name = "lblWines";
            this.lblWines.Size = new System.Drawing.Size(122, 13);
            this.lblWines.TabIndex = 17;
            this.lblWines.Text = "Bouteilles liées à l\'alerte*";
            // 
            // comboWineChoice
            // 
            this.comboWineChoice.FormattingEnabled = true;
            this.comboWineChoice.Location = new System.Drawing.Point(508, 18);
            this.comboWineChoice.Name = "comboWineChoice";
            this.comboWineChoice.Size = new System.Drawing.Size(201, 21);
            this.comboWineChoice.TabIndex = 16;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 44);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(98, 13);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Message de l\'alerte";
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(9, 60);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(302, 58);
            this.rtxtMessage.TabIndex = 8;
            this.rtxtMessage.Text = "";
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
            // txtAlert
            // 
            this.txtAlert.Location = new System.Drawing.Point(110, 19);
            this.txtAlert.Name = "txtAlert";
            this.txtAlert.Size = new System.Drawing.Size(201, 20);
            this.txtAlert.TabIndex = 0;
            // 
            // grpDel
            // 
            this.grpDel.Controls.Add(this.btnShowBottles);
            this.grpDel.Controls.Add(this.dvgBottlesSelected);
            this.grpDel.Controls.Add(this.lblAlertNameOUT);
            this.grpDel.Controls.Add(this.comboAlertOUT);
            this.grpDel.Controls.Add(this.label1);
            this.grpDel.Location = new System.Drawing.Point(12, 70);
            this.grpDel.Name = "grpDel";
            this.grpDel.Size = new System.Drawing.Size(776, 123);
            this.grpDel.TabIndex = 0;
            this.grpDel.TabStop = false;
            this.grpDel.Text = "Supprimer une alerte";
            // 
            // btnShowBottles
            // 
            this.btnShowBottles.Location = new System.Drawing.Point(158, 52);
            this.btnShowBottles.Name = "btnShowBottles";
            this.btnShowBottles.Size = new System.Drawing.Size(202, 23);
            this.btnShowBottles.TabIndex = 20;
            this.btnShowBottles.Text = "Afficher les bouteilles associées";
            this.btnShowBottles.UseVisualStyleBackColor = true;
            this.btnShowBottles.Click += new System.EventHandler(this.btnShowBottles_Click);
            // 
            // dvgBottlesSelected
            // 
            this.dvgBottlesSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBottlesSelected.Enabled = false;
            this.dvgBottlesSelected.EnableHeadersVisualStyles = false;
            this.dvgBottlesSelected.Location = new System.Drawing.Point(403, 45);
            this.dvgBottlesSelected.Name = "dvgBottlesSelected";
            this.dvgBottlesSelected.Size = new System.Drawing.Size(367, 72);
            this.dvgBottlesSelected.TabIndex = 19;
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
            // comboAlertOUT
            // 
            this.comboAlertOUT.FormattingEnabled = true;
            this.comboAlertOUT.Location = new System.Drawing.Point(110, 25);
            this.comboAlertOUT.Name = "comboAlertOUT";
            this.comboAlertOUT.Size = new System.Drawing.Size(284, 21);
            this.comboAlertOUT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bouteilles sélectionnées";
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
            this.radDelAlerts.Click += new System.EventHandler(this.radDelAlerts_Click);
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
            this.radAddAlert.Click += new System.EventHandler(this.radAddAlert_Click);
            // 
            // dvgAlerts
            // 
            this.dvgAlerts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAlerts.Location = new System.Drawing.Point(12, 235);
            this.dvgAlerts.Name = "dvgAlerts";
            this.dvgAlerts.Size = new System.Drawing.Size(776, 277);
            this.dvgAlerts.TabIndex = 5;
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
            this.btnAddAlert.Click += new System.EventHandler(this.btnAddAlert_Click);
            // 
            // btnDelAlert
            // 
            this.btnDelAlert.Location = new System.Drawing.Point(670, 200);
            this.btnDelAlert.Name = "btnDelAlert";
            this.btnDelAlert.Size = new System.Drawing.Size(118, 23);
            this.btnDelAlert.TabIndex = 7;
            this.btnDelAlert.Text = "Supprimer l\'alerte";
            this.btnDelAlert.UseVisualStyleBackColor = true;
            this.btnDelAlert.Click += new System.EventHandler(this.btnDelAlert_Click);
            // 
            // AlertsManagementfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnDelAlert);
            this.Controls.Add(this.btnAddAlert);
            this.Controls.Add(this.grpDel);
            this.Controls.Add(this.lblAlerts);
            this.Controls.Add(this.dvgAlerts);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpAddAlert);
            this.Controls.Add(this.btnMainPage);
            this.Name = "AlertsManagementfrm";
            this.Text = "Gestion des alertes";
            this.Load += new System.EventHandler(this.AlertsManagementfrm_Load);
            this.grpAddAlert.ResumeLayout(false);
            this.grpAddAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.grpDel.ResumeLayout(false);
            this.grpDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottlesSelected)).EndInit();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlerts)).EndInit();
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
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Label lblAlertName;
        private System.Windows.Forms.TextBox txtAlert;
        private System.Windows.Forms.Label lblAlertNameOUT;
        private System.Windows.Forms.ComboBox comboAlertOUT;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridView dvgAlerts;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.Button btnAddBottle;
        private System.Windows.Forms.Label lblWines;
        private System.Windows.Forms.ComboBox comboWineChoice;
        private System.Windows.Forms.Button btnAddAlert;
        private System.Windows.Forms.Button btnDelAlert;
        private System.Windows.Forms.DataGridView dvgBottlesSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowBottles;
    }
}