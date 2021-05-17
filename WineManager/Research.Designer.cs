
namespace WineManager
{
    partial class Researchfrm
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
            this.btnResearch = new System.Windows.Forms.Button();
            this.dvgBottles = new System.Windows.Forms.DataGridView();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.radVariety = new System.Windows.Forms.RadioButton();
            this.radManufacturer = new System.Windows.Forms.RadioButton();
            this.radCountry = new System.Windows.Forms.RadioButton();
            this.radColor = new System.Windows.Forms.RadioButton();
            this.txtResearch = new System.Windows.Forms.TextBox();
            this.lblKeyWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottles)).BeginInit();
            this.grpSort.SuspendLayout();
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
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(670, 70);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(118, 23);
            this.btnResearch.TabIndex = 3;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // dvgBottles
            // 
            this.dvgBottles.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgBottles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBottles.Location = new System.Drawing.Point(12, 99);
            this.dvgBottles.Name = "dvgBottles";
            this.dvgBottles.Size = new System.Drawing.Size(776, 413);
            this.dvgBottles.TabIndex = 5;
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radVariety);
            this.grpSort.Controls.Add(this.radManufacturer);
            this.grpSort.Controls.Add(this.radCountry);
            this.grpSort.Controls.Add(this.radColor);
            this.grpSort.Location = new System.Drawing.Point(12, 54);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(353, 39);
            this.grpSort.TabIndex = 6;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Trier par :";
            // 
            // radVariety
            // 
            this.radVariety.AutoSize = true;
            this.radVariety.Location = new System.Drawing.Point(283, 19);
            this.radVariety.Name = "radVariety";
            this.radVariety.Size = new System.Drawing.Size(62, 17);
            this.radVariety.TabIndex = 0;
            this.radVariety.Text = "Cépage";
            this.radVariety.UseVisualStyleBackColor = true;
            // 
            // radManufacturer
            // 
            this.radManufacturer.AutoSize = true;
            this.radManufacturer.Location = new System.Drawing.Point(115, 19);
            this.radManufacturer.Name = "radManufacturer";
            this.radManufacturer.Size = new System.Drawing.Size(77, 17);
            this.radManufacturer.TabIndex = 0;
            this.radManufacturer.Text = "Producteur";
            this.radManufacturer.UseVisualStyleBackColor = true;
            // 
            // radCountry
            // 
            this.radCountry.AutoSize = true;
            this.radCountry.Location = new System.Drawing.Point(215, 19);
            this.radCountry.Name = "radCountry";
            this.radCountry.Size = new System.Drawing.Size(48, 17);
            this.radCountry.TabIndex = 0;
            this.radCountry.Text = "Pays";
            this.radCountry.UseVisualStyleBackColor = true;
            // 
            // radColor
            // 
            this.radColor.AutoSize = true;
            this.radColor.Checked = true;
            this.radColor.Location = new System.Drawing.Point(6, 19);
            this.radColor.Name = "radColor";
            this.radColor.Size = new System.Drawing.Size(93, 17);
            this.radColor.TabIndex = 0;
            this.radColor.TabStop = true;
            this.radColor.Text = "Couleur du vin";
            this.radColor.UseVisualStyleBackColor = true;
            // 
            // txtResearch
            // 
            this.txtResearch.Location = new System.Drawing.Point(503, 72);
            this.txtResearch.Name = "txtResearch";
            this.txtResearch.Size = new System.Drawing.Size(161, 20);
            this.txtResearch.TabIndex = 7;
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKeyWord.Location = new System.Drawing.Point(455, 75);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(42, 13);
            this.lblKeyWord.TabIndex = 8;
            this.lblKeyWord.Text = "Mot-clé";
            // 
            // Researchfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.txtResearch);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.dvgBottles);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnMainPage);
            this.Name = "Researchfrm";
            this.Text = "Rechercher";
            this.Load += new System.EventHandler(this.Researchfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBottles)).EndInit();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.DataGridView dvgBottles;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton radVariety;
        private System.Windows.Forms.RadioButton radManufacturer;
        private System.Windows.Forms.RadioButton radCountry;
        private System.Windows.Forms.RadioButton radColor;
        private System.Windows.Forms.TextBox txtResearch;
        private System.Windows.Forms.Label lblKeyWord;
    }
}