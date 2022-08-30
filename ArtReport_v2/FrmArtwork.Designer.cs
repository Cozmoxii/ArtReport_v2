
namespace ArtReport_v2
{
    partial class FrmArtwork
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
            this.btnAHome = new System.Windows.Forms.Button();
            this.btnAClear = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.lblASumm = new System.Windows.Forms.Label();
            this.rtxASumm = new System.Windows.Forms.RichTextBox();
            this.rtxANts = new System.Windows.Forms.RichTextBox();
            this.nudATime = new System.Windows.Forms.NumericUpDown();
            this.cbxACat = new System.Windows.Forms.ComboBox();
            this.txbANme = new System.Windows.Forms.TextBox();
            this.lblANts = new System.Windows.Forms.Label();
            this.lblAFile = new System.Windows.Forms.Label();
            this.lblATime = new System.Windows.Forms.Label();
            this.lblACat = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblAMed = new System.Windows.Forms.Label();
            this.lblAddA = new System.Windows.Forms.Label();
            this.cbxAMed = new System.Windows.Forms.ComboBox();
            this.cbxAFile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudATime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAHome
            // 
            this.btnAHome.Location = new System.Drawing.Point(618, 49);
            this.btnAHome.Name = "btnAHome";
            this.btnAHome.Size = new System.Drawing.Size(101, 20);
            this.btnAHome.TabIndex = 36;
            this.btnAHome.Text = "Go Back to Home";
            this.btnAHome.UseVisualStyleBackColor = true;
            this.btnAHome.Click += new System.EventHandler(this.btnAHome_Click);
            // 
            // btnAClear
            // 
            this.btnAClear.Location = new System.Drawing.Point(582, 372);
            this.btnAClear.Name = "btnAClear";
            this.btnAClear.Size = new System.Drawing.Size(83, 30);
            this.btnAClear.TabIndex = 35;
            this.btnAClear.Text = "Clear Form";
            this.btnAClear.UseVisualStyleBackColor = true;
            this.btnAClear.Click += new System.EventHandler(this.btnAClear_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(252, 372);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(95, 30);
            this.btnCAdd.TabIndex = 34;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // lblASumm
            // 
            this.lblASumm.AutoSize = true;
            this.lblASumm.Location = new System.Drawing.Point(534, 100);
            this.lblASumm.Name = "lblASumm";
            this.lblASumm.Size = new System.Drawing.Size(53, 13);
            this.lblASumm.TabIndex = 33;
            this.lblASumm.Text = "Summary:";
            // 
            // rtxASumm
            // 
            this.rtxASumm.Location = new System.Drawing.Point(451, 116);
            this.rtxASumm.Name = "rtxASumm";
            this.rtxASumm.Size = new System.Drawing.Size(214, 232);
            this.rtxASumm.TabIndex = 32;
            this.rtxASumm.Text = "";
            // 
            // rtxANts
            // 
            this.rtxANts.Location = new System.Drawing.Point(227, 266);
            this.rtxANts.Name = "rtxANts";
            this.rtxANts.Size = new System.Drawing.Size(122, 82);
            this.rtxANts.TabIndex = 31;
            this.rtxANts.Text = "";
            // 
            // nudATime
            // 
            this.nudATime.Location = new System.Drawing.Point(227, 208);
            this.nudATime.Name = "nudATime";
            this.nudATime.Size = new System.Drawing.Size(120, 20);
            this.nudATime.TabIndex = 29;
            // 
            // cbxACat
            // 
            this.cbxACat.FormattingEnabled = true;
            this.cbxACat.Location = new System.Drawing.Point(226, 174);
            this.cbxACat.Name = "cbxACat";
            this.cbxACat.Size = new System.Drawing.Size(121, 21);
            this.cbxACat.TabIndex = 28;
            // 
            // txbANme
            // 
            this.txbANme.Location = new System.Drawing.Point(226, 116);
            this.txbANme.Name = "txbANme";
            this.txbANme.Size = new System.Drawing.Size(121, 20);
            this.txbANme.TabIndex = 26;
            // 
            // lblANts
            // 
            this.lblANts.AutoSize = true;
            this.lblANts.Location = new System.Drawing.Point(109, 286);
            this.lblANts.Name = "lblANts";
            this.lblANts.Size = new System.Drawing.Size(38, 13);
            this.lblANts.TabIndex = 25;
            this.lblANts.Text = "Notes:";
            // 
            // lblAFile
            // 
            this.lblAFile.AutoSize = true;
            this.lblAFile.Location = new System.Drawing.Point(82, 240);
            this.lblAFile.Name = "lblAFile";
            this.lblAFile.Size = new System.Drawing.Size(55, 13);
            this.lblAFile.TabIndex = 24;
            this.lblAFile.Text = "Image file:";
            // 
            // lblATime
            // 
            this.lblATime.AutoSize = true;
            this.lblATime.Location = new System.Drawing.Point(82, 210);
            this.lblATime.Name = "lblATime";
            this.lblATime.Size = new System.Drawing.Size(81, 13);
            this.lblATime.TabIndex = 23;
            this.lblATime.Text = "Time Spent(hrs)";
            // 
            // lblACat
            // 
            this.lblACat.AutoSize = true;
            this.lblACat.Location = new System.Drawing.Point(82, 174);
            this.lblACat.Name = "lblACat";
            this.lblACat.Size = new System.Drawing.Size(52, 13);
            this.lblACat.TabIndex = 22;
            this.lblACat.Text = "Category:";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(82, 116);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(38, 13);
            this.lblCName.TabIndex = 21;
            this.lblCName.Text = "Name:";
            // 
            // lblAMed
            // 
            this.lblAMed.AutoSize = true;
            this.lblAMed.Location = new System.Drawing.Point(82, 143);
            this.lblAMed.Name = "lblAMed";
            this.lblAMed.Size = new System.Drawing.Size(44, 13);
            this.lblAMed.TabIndex = 20;
            this.lblAMed.Text = "Medium";
            // 
            // lblAddA
            // 
            this.lblAddA.AutoSize = true;
            this.lblAddA.Location = new System.Drawing.Point(174, 57);
            this.lblAddA.Name = "lblAddA";
            this.lblAddA.Size = new System.Drawing.Size(101, 13);
            this.lblAddA.TabIndex = 19;
            this.lblAddA.Text = "Artwork Information:";
            // 
            // cbxAMed
            // 
            this.cbxAMed.FormattingEnabled = true;
            this.cbxAMed.Items.AddRange(new object[] {
            "Digital",
            "Ink",
            "Acrylic",
            "Oil",
            "Gouache",
            "Pencil",
            "Pen",
            "Mixed"});
            this.cbxAMed.Location = new System.Drawing.Point(226, 142);
            this.cbxAMed.Name = "cbxAMed";
            this.cbxAMed.Size = new System.Drawing.Size(121, 21);
            this.cbxAMed.TabIndex = 37;
            // 
            // cbxAFile
            // 
            this.cbxAFile.FormattingEnabled = true;
            this.cbxAFile.Location = new System.Drawing.Point(227, 234);
            this.cbxAFile.Name = "cbxAFile";
            this.cbxAFile.Size = new System.Drawing.Size(121, 21);
            this.cbxAFile.TabIndex = 38;
            // 
            // FrmArtwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxAFile);
            this.Controls.Add(this.cbxAMed);
            this.Controls.Add(this.btnAHome);
            this.Controls.Add(this.btnAClear);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.lblASumm);
            this.Controls.Add(this.rtxASumm);
            this.Controls.Add(this.rtxANts);
            this.Controls.Add(this.nudATime);
            this.Controls.Add(this.cbxACat);
            this.Controls.Add(this.txbANme);
            this.Controls.Add(this.lblANts);
            this.Controls.Add(this.lblAFile);
            this.Controls.Add(this.lblATime);
            this.Controls.Add(this.lblACat);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblAMed);
            this.Controls.Add(this.lblAddA);
            this.Name = "FrmArtwork";
            this.Text = "FrmArtwork";
            ((System.ComponentModel.ISupportInitialize)(this.nudATime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAHome;
        private System.Windows.Forms.Button btnAClear;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Label lblASumm;
        private System.Windows.Forms.RichTextBox rtxASumm;
        private System.Windows.Forms.RichTextBox rtxANts;
        private System.Windows.Forms.NumericUpDown nudATime;
        private System.Windows.Forms.ComboBox cbxACat;
        private System.Windows.Forms.TextBox txbANme;
        private System.Windows.Forms.Label lblANts;
        private System.Windows.Forms.Label lblAFile;
        private System.Windows.Forms.Label lblATime;
        private System.Windows.Forms.Label lblACat;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblAMed;
        private System.Windows.Forms.Label lblAddA;
        private System.Windows.Forms.ComboBox cbxAMed;
        private System.Windows.Forms.ComboBox cbxAFile;
    }
}