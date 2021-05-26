
namespace WineManager
{
    partial class Logsfrm
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
            this.dvgLogs = new System.Windows.Forms.DataGridView();
            this.lblLogs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgLogs
            // 
            this.dvgLogs.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLogs.Location = new System.Drawing.Point(12, 34);
            this.dvgLogs.Name = "dvgLogs";
            this.dvgLogs.Size = new System.Drawing.Size(776, 478);
            this.dvgLogs.TabIndex = 5;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(12, 18);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(111, 13);
            this.lblLogs.TabIndex = 6;
            this.lblLogs.Text = "Historique des actions";
            // 
            // Logsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.dvgLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Logsfrm";
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Logsfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgLogs;
        private System.Windows.Forms.Label lblLogs;
    }
}