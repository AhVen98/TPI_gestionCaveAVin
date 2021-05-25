
namespace WineManager
{
    partial class StorageBoxesManagementfrm
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblStorageNumber = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.grpDel = new System.Windows.Forms.GroupBox();
            this.lblStorageNumberOUT = new System.Windows.Forms.Label();
            this.comboStorage = new System.Windows.Forms.ComboBox();
            this.btnDelStorage = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.radDelStorage = new System.Windows.Forms.RadioButton();
            this.radAddStorage = new System.Windows.Forms.RadioButton();
            this.dvgStorageBoxes = new System.Windows.Forms.DataGridView();
            this.lblStorage = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.grpDel.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStorageBoxes)).BeginInit();
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
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.lblDesc);
            this.grpAdd.Controls.Add(this.rtxtDescription);
            this.grpAdd.Controls.Add(this.lblStorageNumber);
            this.grpAdd.Controls.Add(this.txtStorage);
            this.grpAdd.Controls.Add(this.btnAddStorage);
            this.grpAdd.Location = new System.Drawing.Point(12, 70);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(776, 117);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Ajouter des bouteilles";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 47);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(72, 44);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(694, 40);
            this.rtxtDescription.TabIndex = 8;
            this.rtxtDescription.Text = "";
            // 
            // lblStorageNumber
            // 
            this.lblStorageNumber.AutoSize = true;
            this.lblStorageNumber.Location = new System.Drawing.Point(6, 22);
            this.lblStorageNumber.Name = "lblStorageNumber";
            this.lblStorageNumber.Size = new System.Drawing.Size(94, 13);
            this.lblStorageNumber.TabIndex = 1;
            this.lblStorageNumber.Text = "Numéro de casier*";
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(106, 19);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(277, 20);
            this.txtStorage.TabIndex = 0;
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.Location = new System.Drawing.Point(648, 88);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(118, 23);
            this.btnAddStorage.TabIndex = 3;
            this.btnAddStorage.Text = "Ajouter le casier";
            this.btnAddStorage.UseVisualStyleBackColor = true;
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);
            // 
            // grpDel
            // 
            this.grpDel.Controls.Add(this.lblStorageNumberOUT);
            this.grpDel.Controls.Add(this.comboStorage);
            this.grpDel.Controls.Add(this.btnDelStorage);
            this.grpDel.Location = new System.Drawing.Point(12, 69);
            this.grpDel.Name = "grpDel";
            this.grpDel.Size = new System.Drawing.Size(776, 117);
            this.grpDel.TabIndex = 0;
            this.grpDel.TabStop = false;
            this.grpDel.Text = "Sortir des bouteilles";
            // 
            // lblStorageNumberOUT
            // 
            this.lblStorageNumberOUT.AutoSize = true;
            this.lblStorageNumberOUT.Location = new System.Drawing.Point(6, 28);
            this.lblStorageNumberOUT.Name = "lblStorageNumberOUT";
            this.lblStorageNumberOUT.Size = new System.Drawing.Size(94, 13);
            this.lblStorageNumberOUT.TabIndex = 1;
            this.lblStorageNumberOUT.Text = "Numéro de casier*";
            // 
            // comboStorage
            // 
            this.comboStorage.FormattingEnabled = true;
            this.comboStorage.Location = new System.Drawing.Point(106, 25);
            this.comboStorage.Name = "comboStorage";
            this.comboStorage.Size = new System.Drawing.Size(277, 21);
            this.comboStorage.TabIndex = 7;
            // 
            // btnDelStorage
            // 
            this.btnDelStorage.Location = new System.Drawing.Point(648, 88);
            this.btnDelStorage.Name = "btnDelStorage";
            this.btnDelStorage.Size = new System.Drawing.Size(118, 23);
            this.btnDelStorage.TabIndex = 4;
            this.btnDelStorage.Text = "Supprimer le casier";
            this.btnDelStorage.UseVisualStyleBackColor = true;
            this.btnDelStorage.Click += new System.EventHandler(this.btnDelStorage_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.radDelStorage);
            this.grpActions.Controls.Add(this.radAddStorage);
            this.grpActions.Location = new System.Drawing.Point(12, 12);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(652, 52);
            this.grpActions.TabIndex = 2;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Que souhaitez-vous faire ?";
            // 
            // radDelStorage
            // 
            this.radDelStorage.AutoSize = true;
            this.radDelStorage.Location = new System.Drawing.Point(403, 29);
            this.radDelStorage.Name = "radDelStorage";
            this.radDelStorage.Size = new System.Drawing.Size(118, 17);
            this.radDelStorage.TabIndex = 1;
            this.radDelStorage.Text = "Supprimer un casier";
            this.radDelStorage.UseVisualStyleBackColor = true;
            this.radDelStorage.Click += new System.EventHandler(this.radDelStorage_Click);
            // 
            // radAddStorage
            // 
            this.radAddStorage.AutoSize = true;
            this.radAddStorage.Checked = true;
            this.radAddStorage.Location = new System.Drawing.Point(158, 29);
            this.radAddStorage.Name = "radAddStorage";
            this.radAddStorage.Size = new System.Drawing.Size(104, 17);
            this.radAddStorage.TabIndex = 0;
            this.radAddStorage.TabStop = true;
            this.radAddStorage.Text = "Ajouter un casier";
            this.radAddStorage.UseVisualStyleBackColor = true;
            this.radAddStorage.Click += new System.EventHandler(this.radAddStorage_Click);
            // 
            // dvgStorageBoxes
            // 
            this.dvgStorageBoxes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgStorageBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStorageBoxes.Location = new System.Drawing.Point(12, 225);
            this.dvgStorageBoxes.Name = "dvgStorageBoxes";
            this.dvgStorageBoxes.Size = new System.Drawing.Size(776, 287);
            this.dvgStorageBoxes.TabIndex = 5;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(18, 209);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(147, 13);
            this.lblStorage.TabIndex = 6;
            this.lblStorage.Text = "Casiers actuellement présents";
            // 
            // StorageBoxesManagementfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.grpDel);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.dvgStorageBoxes);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnMainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StorageBoxesManagementfrm";
            this.Text = "Gestion des casiers";
            this.Load += new System.EventHandler(this.StorageBoxesManagementfrm_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpDel.ResumeLayout(false);
            this.grpDel.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStorageBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.RadioButton radDelStorage;
        private System.Windows.Forms.RadioButton radAddStorage;
        private System.Windows.Forms.GroupBox grpDel;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblStorageNumber;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Label lblStorageNumberOUT;
        private System.Windows.Forms.ComboBox comboStorage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAddStorage;
        private System.Windows.Forms.Button btnDelStorage;
        private System.Windows.Forms.DataGridView dvgStorageBoxes;
        private System.Windows.Forms.Label lblStorage;
    }
}