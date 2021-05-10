
namespace WineManager
{
    partial class BottlesManagementfrm
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.grpDel = new System.Windows.Forms.GroupBox();
            this.lblBottleNameOUT = new System.Windows.Forms.Label();
            this.comboWine = new System.Windows.Forms.ComboBox();
            this.lblManufacturerOUT = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.lblYearOUT = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.lblVolumeOUT = new System.Windows.Forms.Label();
            this.txtVolumeOUT = new System.Windows.Forms.TextBox();
            this.lblNumberOUT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblVariety3 = new System.Windows.Forms.Label();
            this.lblVariety2 = new System.Windows.Forms.Label();
            this.lblVariety1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.comboManufacturer = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTxtBottle = new System.Windows.Forms.Label();
            this.txtBottleName = new System.Windows.Forms.TextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.radDelBottles = new System.Windows.Forms.RadioButton();
            this.radAddBottle = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dvgBottles = new System.Windows.Forms.DataGridView();
            this.lblStock = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
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
            this.btnMainPage.Click += new System.EventHandler(this.BtnMainPage_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.grpDel);
            this.grpAdd.Controls.Add(this.comboBox7);
            this.grpAdd.Controls.Add(this.comboBox4);
            this.grpAdd.Controls.Add(this.lblDesc);
            this.grpAdd.Controls.Add(this.lblVariety3);
            this.grpAdd.Controls.Add(this.lblVariety2);
            this.grpAdd.Controls.Add(this.lblVariety1);
            this.grpAdd.Controls.Add(this.comboBox3);
            this.grpAdd.Controls.Add(this.comboBox2);
            this.grpAdd.Controls.Add(this.comboBox1);
            this.grpAdd.Controls.Add(this.lblStorage);
            this.grpAdd.Controls.Add(this.lblVolume);
            this.grpAdd.Controls.Add(this.lblColor);
            this.grpAdd.Controls.Add(this.comboColor);
            this.grpAdd.Controls.Add(this.rtxtDescription);
            this.grpAdd.Controls.Add(this.comboManufacturer);
            this.grpAdd.Controls.Add(this.lblManufacturer);
            this.grpAdd.Controls.Add(this.lblYear);
            this.grpAdd.Controls.Add(this.txtYear);
            this.grpAdd.Controls.Add(this.txtNumber);
            this.grpAdd.Controls.Add(this.lblNumber);
            this.grpAdd.Controls.Add(this.lblTxtBottle);
            this.grpAdd.Controls.Add(this.txtBottleName);
            this.grpAdd.Location = new System.Drawing.Point(12, 70);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(776, 151);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Ajouter des bouteilles";
            // 
            // grpDel
            // 
            this.grpDel.Controls.Add(this.lblBottleNameOUT);
            this.grpDel.Controls.Add(this.comboWine);
            this.grpDel.Controls.Add(this.lblManufacturerOUT);
            this.grpDel.Controls.Add(this.comboBox5);
            this.grpDel.Controls.Add(this.lblYearOUT);
            this.grpDel.Controls.Add(this.comboBox6);
            this.grpDel.Controls.Add(this.lblVolumeOUT);
            this.grpDel.Controls.Add(this.txtVolumeOUT);
            this.grpDel.Controls.Add(this.lblNumberOUT);
            this.grpDel.Controls.Add(this.textBox2);
            this.grpDel.Location = new System.Drawing.Point(0, 1);
            this.grpDel.Name = "grpDel";
            this.grpDel.Size = new System.Drawing.Size(776, 150);
            this.grpDel.TabIndex = 0;
            this.grpDel.TabStop = false;
            this.grpDel.Text = "Sortir des bouteilles";
            // 
            // lblBottleNameOUT
            // 
            this.lblBottleNameOUT.AutoSize = true;
            this.lblBottleNameOUT.Location = new System.Drawing.Point(6, 28);
            this.lblBottleNameOUT.Name = "lblBottleNameOUT";
            this.lblBottleNameOUT.Size = new System.Drawing.Size(65, 13);
            this.lblBottleNameOUT.TabIndex = 1;
            this.lblBottleNameOUT.Text = "Nom du vin*";
            // 
            // comboWine
            // 
            this.comboWine.FormattingEnabled = true;
            this.comboWine.Location = new System.Drawing.Point(73, 25);
            this.comboWine.Name = "comboWine";
            this.comboWine.Size = new System.Drawing.Size(277, 21);
            this.comboWine.TabIndex = 7;
            // 
            // lblManufacturerOUT
            // 
            this.lblManufacturerOUT.AutoSize = true;
            this.lblManufacturerOUT.Location = new System.Drawing.Point(8, 55);
            this.lblManufacturerOUT.Name = "lblManufacturerOUT";
            this.lblManufacturerOUT.Size = new System.Drawing.Size(63, 13);
            this.lblManufacturerOUT.TabIndex = 6;
            this.lblManufacturerOUT.Text = "Producteur*";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(73, 52);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(277, 21);
            this.comboBox5.TabIndex = 7;
            // 
            // lblYearOUT
            // 
            this.lblYearOUT.AutoSize = true;
            this.lblYearOUT.Location = new System.Drawing.Point(409, 28);
            this.lblYearOUT.Name = "lblYearOUT";
            this.lblYearOUT.Size = new System.Drawing.Size(110, 13);
            this.lblYearOUT.TabIndex = 5;
            this.lblYearOUT.Text = "Année de production*";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(525, 25);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(245, 21);
            this.comboBox6.TabIndex = 13;
            // 
            // lblVolumeOUT
            // 
            this.lblVolumeOUT.AutoSize = true;
            this.lblVolumeOUT.Location = new System.Drawing.Point(409, 55);
            this.lblVolumeOUT.Name = "lblVolumeOUT";
            this.lblVolumeOUT.Size = new System.Drawing.Size(80, 13);
            this.lblVolumeOUT.TabIndex = 11;
            this.lblVolumeOUT.Text = "Volume en litre*";
            // 
            // txtVolumeOUT
            // 
            this.txtVolumeOUT.Location = new System.Drawing.Point(525, 52);
            this.txtVolumeOUT.Name = "txtVolumeOUT";
            this.txtVolumeOUT.Size = new System.Drawing.Size(245, 20);
            this.txtVolumeOUT.TabIndex = 12;
            // 
            // lblNumberOUT
            // 
            this.lblNumberOUT.AutoSize = true;
            this.lblNumberOUT.Location = new System.Drawing.Point(8, 82);
            this.lblNumberOUT.Name = "lblNumberOUT";
            this.lblNumberOUT.Size = new System.Drawing.Size(110, 13);
            this.lblNumberOUT.TabIndex = 2;
            this.lblNumberOUT.Text = "Nombre de bouteilles*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 0;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(490, 45);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(90, 21);
            this.comboBox7.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(490, 72);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(90, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 102);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Description";
            // 
            // lblVariety3
            // 
            this.lblVariety3.AutoSize = true;
            this.lblVariety3.Location = new System.Drawing.Point(603, 75);
            this.lblVariety3.Name = "lblVariety3";
            this.lblVariety3.Size = new System.Drawing.Size(44, 13);
            this.lblVariety3.TabIndex = 14;
            this.lblVariety3.Text = "Cépage";
            // 
            // lblVariety2
            // 
            this.lblVariety2.AutoSize = true;
            this.lblVariety2.Location = new System.Drawing.Point(603, 48);
            this.lblVariety2.Name = "lblVariety2";
            this.lblVariety2.Size = new System.Drawing.Size(44, 13);
            this.lblVariety2.TabIndex = 14;
            this.lblVariety2.Text = "Cépage";
            // 
            // lblVariety1
            // 
            this.lblVariety1.AutoSize = true;
            this.lblVariety1.Location = new System.Drawing.Point(603, 22);
            this.lblVariety1.Name = "lblVariety1";
            this.lblVariety1.Size = new System.Drawing.Size(48, 13);
            this.lblVariety1.TabIndex = 14;
            this.lblVariety1.Text = "Cépage*";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(657, 72);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(112, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(657, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(657, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(374, 75);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(40, 13);
            this.lblStorage.TabIndex = 11;
            this.lblStorage.Text = "Casier*";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(374, 48);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(80, 13);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume en litre*";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(183, 75);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(79, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Couleur du vin*";
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(268, 72);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(82, 21);
            this.comboColor.TabIndex = 9;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(76, 99);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(694, 43);
            this.rtxtDescription.TabIndex = 8;
            this.rtxtDescription.Text = "";
            // 
            // comboManufacturer
            // 
            this.comboManufacturer.FormattingEnabled = true;
            this.comboManufacturer.Location = new System.Drawing.Point(73, 45);
            this.comboManufacturer.Name = "comboManufacturer";
            this.comboManufacturer.Size = new System.Drawing.Size(277, 21);
            this.comboManufacturer.TabIndex = 7;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(6, 48);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(63, 13);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Producteur*";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(110, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Année de production*";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(122, 72);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(55, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(490, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(90, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(374, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(110, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Nombre de bouteilles*";
            // 
            // lblTxtBottle
            // 
            this.lblTxtBottle.AutoSize = true;
            this.lblTxtBottle.Location = new System.Drawing.Point(6, 22);
            this.lblTxtBottle.Name = "lblTxtBottle";
            this.lblTxtBottle.Size = new System.Drawing.Size(65, 13);
            this.lblTxtBottle.TabIndex = 1;
            this.lblTxtBottle.Text = "Nom du vin*";
            // 
            // txtBottleName
            // 
            this.txtBottleName.Location = new System.Drawing.Point(73, 19);
            this.txtBottleName.Name = "txtBottleName";
            this.txtBottleName.Size = new System.Drawing.Size(277, 20);
            this.txtBottleName.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.radDelBottles);
            this.grpActions.Controls.Add(this.radAddBottle);
            this.grpActions.Location = new System.Drawing.Point(12, 12);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(652, 52);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Que souhaitez-vous faire ?";
            // 
            // radDelBottles
            // 
            this.radDelBottles.AutoSize = true;
            this.radDelBottles.Location = new System.Drawing.Point(403, 29);
            this.radDelBottles.Name = "radDelBottles";
            this.radDelBottles.Size = new System.Drawing.Size(116, 17);
            this.radDelBottles.TabIndex = 1;
            this.radDelBottles.Text = "Sortir des bouteilles";
            this.radDelBottles.UseVisualStyleBackColor = true;
            // 
            // radAddBottle
            // 
            this.radAddBottle.AutoSize = true;
            this.radAddBottle.Checked = true;
            this.radAddBottle.Location = new System.Drawing.Point(158, 29);
            this.radAddBottle.Name = "radAddBottle";
            this.radAddBottle.Size = new System.Drawing.Size(125, 17);
            this.radAddBottle.TabIndex = 0;
            this.radAddBottle.TabStop = true;
            this.radAddBottle.Text = "Ajouter des bouteilles";
            this.radAddBottle.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(670, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ajouter les bouteilles";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(670, 227);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(118, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Sortir les bouteilles";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // dvgBottles
            // 
            this.dvgBottles.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgBottles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBottles.Location = new System.Drawing.Point(12, 256);
            this.dvgBottles.Name = "dvgBottles";
            this.dvgBottles.Size = new System.Drawing.Size(776, 256);
            this.dvgBottles.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 240);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(161, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Bouteilles actuellement stockées";
            // 
            // BottlesManagementfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dvgBottles);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnMainPage);
            this.Name = "BottlesManagementfrm";
            this.Text = "Gestion des bouteilles";
            this.Load += new System.EventHandler(this.BottlesManagementfrm_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.RadioButton radDelBottles;
        private System.Windows.Forms.RadioButton radAddBottle;
        private System.Windows.Forms.GroupBox grpDel;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.ComboBox comboManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTxtBottle;
        private System.Windows.Forms.TextBox txtBottleName;
        private System.Windows.Forms.Label lblBottleNameOUT;
        private System.Windows.Forms.ComboBox comboWine;
        private System.Windows.Forms.Label lblManufacturerOUT;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label lblYearOUT;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label lblVolumeOUT;
        private System.Windows.Forms.TextBox txtVolumeOUT;
        private System.Windows.Forms.Label lblNumberOUT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblVariety3;
        private System.Windows.Forms.Label lblVariety2;
        private System.Windows.Forms.Label lblVariety1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dvgBottles;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}