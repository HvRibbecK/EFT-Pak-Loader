
namespace EFT_Pak_Loader
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblInstallStatus = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.findEFTexe = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPlayerESP = new System.Windows.Forms.CheckBox();
            this.checkBoxItemESP = new System.Windows.Forms.CheckBox();
            this.checkBoxNoSound = new System.Windows.Forms.CheckBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.groupBoxGameFolder = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGameFolder = new System.Windows.Forms.TextBox();
            this.groupBoxFeatures = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDownload.SuspendLayout();
            this.groupBoxGameFolder.SuspendLayout();
            this.groupBoxFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.ForeColor = System.Drawing.Color.White;
            this.lblProgressBar.Location = new System.Drawing.Point(3, 74);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(139, 13);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = "Waiting for download...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Black;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.Transparent;
            this.btnDownload.Location = new System.Drawing.Point(6, 19);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(271, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.Black;
            this.btnInstall.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.ForeColor = System.Drawing.Color.Transparent;
            this.btnInstall.Location = new System.Drawing.Point(6, 90);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblInstallStatus
            // 
            this.lblInstallStatus.AutoSize = true;
            this.lblInstallStatus.ForeColor = System.Drawing.Color.White;
            this.lblInstallStatus.Location = new System.Drawing.Point(87, 95);
            this.lblInstallStatus.Name = "lblInstallStatus";
            this.lblInstallStatus.Size = new System.Drawing.Size(95, 13);
            this.lblInstallStatus.TabIndex = 5;
            this.lblInstallStatus.Text = "Cheat installed!";
            this.lblInstallStatus.Visible = false;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.ForeColor = System.Drawing.Color.Red;
            this.lblGameStatus.Location = new System.Drawing.Point(46, 333);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(129, 29);
            this.lblGameStatus.TabIndex = 6;
            this.lblGameStatus.Text = "             :-)";
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findEFTexe
            // 
            this.findEFTexe.Interval = 10;
            this.findEFTexe.Tick += new System.EventHandler(this.findEFTexe_Tick);
            // 
            // checkBoxPlayerESP
            // 
            this.checkBoxPlayerESP.AutoSize = true;
            this.checkBoxPlayerESP.ForeColor = System.Drawing.Color.White;
            this.checkBoxPlayerESP.Location = new System.Drawing.Point(6, 19);
            this.checkBoxPlayerESP.Name = "checkBoxPlayerESP";
            this.checkBoxPlayerESP.Size = new System.Drawing.Size(89, 17);
            this.checkBoxPlayerESP.TabIndex = 7;
            this.checkBoxPlayerESP.Text = "Player ESP";
            this.checkBoxPlayerESP.UseVisualStyleBackColor = true;
            // 
            // checkBoxItemESP
            // 
            this.checkBoxItemESP.AutoSize = true;
            this.checkBoxItemESP.ForeColor = System.Drawing.Color.White;
            this.checkBoxItemESP.Location = new System.Drawing.Point(6, 43);
            this.checkBoxItemESP.Name = "checkBoxItemESP";
            this.checkBoxItemESP.Size = new System.Drawing.Size(78, 17);
            this.checkBoxItemESP.TabIndex = 8;
            this.checkBoxItemESP.Text = "Item ESP";
            this.checkBoxItemESP.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoSound
            // 
            this.checkBoxNoSound.AutoSize = true;
            this.checkBoxNoSound.ForeColor = System.Drawing.Color.White;
            this.checkBoxNoSound.Location = new System.Drawing.Point(6, 67);
            this.checkBoxNoSound.Name = "checkBoxNoSound";
            this.checkBoxNoSound.Size = new System.Drawing.Size(131, 17);
            this.checkBoxNoSound.TabIndex = 9;
            this.checkBoxNoSound.Text = "No Ambient Sound";
            this.checkBoxNoSound.UseVisualStyleBackColor = true;
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDownload.Controls.Add(this.btnDownload);
            this.groupBoxDownload.Controls.Add(this.progressBar1);
            this.groupBoxDownload.Controls.Add(this.lblProgressBar);
            this.groupBoxDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDownload.ForeColor = System.Drawing.Color.Aqua;
            this.groupBoxDownload.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(287, 100);
            this.groupBoxDownload.TabIndex = 11;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Download";
            // 
            // groupBoxGameFolder
            // 
            this.groupBoxGameFolder.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGameFolder.Controls.Add(this.label4);
            this.groupBoxGameFolder.Controls.Add(this.textBoxGameFolder);
            this.groupBoxGameFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGameFolder.ForeColor = System.Drawing.Color.Aqua;
            this.groupBoxGameFolder.Location = new System.Drawing.Point(12, 118);
            this.groupBoxGameFolder.Name = "groupBoxGameFolder";
            this.groupBoxGameFolder.Size = new System.Drawing.Size(287, 61);
            this.groupBoxGameFolder.TabIndex = 12;
            this.groupBoxGameFolder.TabStop = false;
            this.groupBoxGameFolder.Text = "Game folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Click to change";
            // 
            // textBoxGameFolder
            // 
            this.textBoxGameFolder.Location = new System.Drawing.Point(9, 32);
            this.textBoxGameFolder.Name = "textBoxGameFolder";
            this.textBoxGameFolder.Size = new System.Drawing.Size(271, 20);
            this.textBoxGameFolder.TabIndex = 0;
            this.textBoxGameFolder.Text = "C:\\Battlestate Games";
            this.textBoxGameFolder.Click += new System.EventHandler(this.textBoxGameFolder_Click);
            // 
            // groupBoxFeatures
            // 
            this.groupBoxFeatures.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFeatures.Controls.Add(this.checkBoxPlayerESP);
            this.groupBoxFeatures.Controls.Add(this.checkBoxItemESP);
            this.groupBoxFeatures.Controls.Add(this.checkBoxNoSound);
            this.groupBoxFeatures.Controls.Add(this.btnInstall);
            this.groupBoxFeatures.Controls.Add(this.lblInstallStatus);
            this.groupBoxFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFeatures.ForeColor = System.Drawing.Color.Aqua;
            this.groupBoxFeatures.Location = new System.Drawing.Point(12, 185);
            this.groupBoxFeatures.Name = "groupBoxFeatures";
            this.groupBoxFeatures.Size = new System.Drawing.Size(287, 122);
            this.groupBoxFeatures.TabIndex = 13;
            this.groupBoxFeatures.TabStop = false;
            this.groupBoxFeatures.Text = "Choose features";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(0, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "V1.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(184, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Discord: 8i#1274";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(312, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFeatures);
            this.Controls.Add(this.groupBoxGameFolder);
            this.Controls.Add(this.groupBoxDownload);
            this.Controls.Add(this.lblGameStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "HvRibbecK\'s PAK Loader";
            this.groupBoxDownload.ResumeLayout(false);
            this.groupBoxDownload.PerformLayout();
            this.groupBoxGameFolder.ResumeLayout(false);
            this.groupBoxGameFolder.PerformLayout();
            this.groupBoxFeatures.ResumeLayout(false);
            this.groupBoxFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label lblInstallStatus;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Timer findEFTexe;
        private System.Windows.Forms.CheckBox checkBoxPlayerESP;
        private System.Windows.Forms.CheckBox checkBoxItemESP;
        private System.Windows.Forms.CheckBox checkBoxNoSound;
        private System.Windows.Forms.GroupBox groupBoxDownload;
        private System.Windows.Forms.GroupBox groupBoxGameFolder;
        private System.Windows.Forms.GroupBox groupBoxFeatures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGameFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

