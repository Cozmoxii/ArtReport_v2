
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtwork));
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
            this.lblATime = new System.Windows.Forms.Label();
            this.lblACat = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblAMed = new System.Windows.Forms.Label();
            this.lblAddA = new System.Windows.Forms.Label();
            this.cbxAMed = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudATime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAHome
            // 
            this.btnAHome.BackColor = System.Drawing.Color.White;
            this.btnAHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnAHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnAHome.Location = new System.Drawing.Point(644, 48);
            this.btnAHome.Name = "btnAHome";
            this.btnAHome.Size = new System.Drawing.Size(56, 30);
            this.btnAHome.TabIndex = 36;
            this.btnAHome.Text = "Home";
            this.btnAHome.UseVisualStyleBackColor = false;
            this.btnAHome.Click += new System.EventHandler(this.btnAHome_Click);
            // 
            // btnAClear
            // 
            this.btnAClear.BackColor = System.Drawing.Color.White;
            this.btnAClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnAClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnAClear.Location = new System.Drawing.Point(582, 372);
            this.btnAClear.Name = "btnAClear";
            this.btnAClear.Size = new System.Drawing.Size(83, 30);
            this.btnAClear.TabIndex = 35;
            this.btnAClear.Text = "Clear Form";
            this.btnAClear.UseVisualStyleBackColor = false;
            this.btnAClear.Click += new System.EventHandler(this.btnAClear_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.BackColor = System.Drawing.Color.White;
            this.btnCAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnCAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnCAdd.Location = new System.Drawing.Point(252, 372);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(95, 30);
            this.btnCAdd.TabIndex = 34;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = false;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // lblASumm
            // 
            this.lblASumm.AutoSize = true;
            this.lblASumm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblASumm.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblASumm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblASumm.Location = new System.Drawing.Point(491, 97);
            this.lblASumm.Name = "lblASumm";
            this.lblASumm.Size = new System.Drawing.Size(140, 16);
            this.lblASumm.TabIndex = 33;
            this.lblASumm.Text = "Artwork Summary:";
            // 
            // rtxASumm
            // 
            this.rtxASumm.BackColor = System.Drawing.Color.White;
            this.rtxASumm.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.rtxASumm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.rtxASumm.Location = new System.Drawing.Point(451, 116);
            this.rtxASumm.Name = "rtxASumm";
            this.rtxASumm.ReadOnly = true;
            this.rtxASumm.Size = new System.Drawing.Size(214, 232);
            this.rtxASumm.TabIndex = 32;
            this.rtxASumm.Text = "";
            // 
            // rtxANts
            // 
            this.rtxANts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.rtxANts.Location = new System.Drawing.Point(225, 247);
            this.rtxANts.Name = "rtxANts";
            this.rtxANts.Size = new System.Drawing.Size(122, 82);
            this.rtxANts.TabIndex = 31;
            this.rtxANts.Text = "";
            // 
            // nudATime
            // 
            this.nudATime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.nudATime.Location = new System.Drawing.Point(227, 208);
            this.nudATime.Name = "nudATime";
            this.nudATime.Size = new System.Drawing.Size(120, 20);
            this.nudATime.TabIndex = 29;
            // 
            // cbxACat
            // 
            this.cbxACat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxACat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxACat.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.cbxACat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.cbxACat.FormattingEnabled = true;
            this.cbxACat.Location = new System.Drawing.Point(226, 174);
            this.cbxACat.Name = "cbxACat";
            this.cbxACat.Size = new System.Drawing.Size(121, 23);
            this.cbxACat.TabIndex = 28;
            // 
            // txbANme
            // 
            this.txbANme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.txbANme.Location = new System.Drawing.Point(226, 116);
            this.txbANme.Name = "txbANme";
            this.txbANme.Size = new System.Drawing.Size(121, 20);
            this.txbANme.TabIndex = 26;
            // 
            // lblANts
            // 
            this.lblANts.AutoSize = true;
            this.lblANts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblANts.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblANts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblANts.Location = new System.Drawing.Point(119, 247);
            this.lblANts.Name = "lblANts";
            this.lblANts.Size = new System.Drawing.Size(56, 18);
            this.lblANts.TabIndex = 25;
            this.lblANts.Text = "Notes:";
            // 
            // lblATime
            // 
            this.lblATime.AutoSize = true;
            this.lblATime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblATime.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblATime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblATime.Location = new System.Drawing.Point(82, 210);
            this.lblATime.Name = "lblATime";
            this.lblATime.Size = new System.Drawing.Size(124, 18);
            this.lblATime.TabIndex = 23;
            this.lblATime.Text = "Time Spent(hrs)";
            // 
            // lblACat
            // 
            this.lblACat.AutoSize = true;
            this.lblACat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblACat.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblACat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblACat.Location = new System.Drawing.Point(82, 174);
            this.lblACat.Name = "lblACat";
            this.lblACat.Size = new System.Drawing.Size(81, 18);
            this.lblACat.TabIndex = 22;
            this.lblACat.Text = "Category:";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblCName.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblCName.Location = new System.Drawing.Point(82, 116);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(55, 18);
            this.lblCName.TabIndex = 21;
            this.lblCName.Text = "Name:";
            // 
            // lblAMed
            // 
            this.lblAMed.AutoSize = true;
            this.lblAMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblAMed.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.lblAMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblAMed.Location = new System.Drawing.Point(82, 143);
            this.lblAMed.Name = "lblAMed";
            this.lblAMed.Size = new System.Drawing.Size(67, 18);
            this.lblAMed.TabIndex = 20;
            this.lblAMed.Text = "Medium";
            // 
            // lblAddA
            // 
            this.lblAddA.AutoSize = true;
            this.lblAddA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblAddA.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblAddA.Location = new System.Drawing.Point(127, 58);
            this.lblAddA.Name = "lblAddA";
            this.lblAddA.Size = new System.Drawing.Size(195, 23);
            this.lblAddA.TabIndex = 19;
            this.lblAddA.Text = "Add New Artwork:";
            // 
            // cbxAMed
            // 
            this.cbxAMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxAMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pictureBox1.Location = new System.Drawing.Point(68, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 407);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmArtwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 483);
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
            this.Controls.Add(this.lblATime);
            this.Controls.Add(this.lblACat);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblAMed);
            this.Controls.Add(this.lblAddA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmArtwork";
            this.Text = "FrmArtwork";
            ((System.ComponentModel.ISupportInitialize)(this.nudATime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblATime;
        private System.Windows.Forms.Label lblACat;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblAMed;
        private System.Windows.Forms.Label lblAddA;
        private System.Windows.Forms.ComboBox cbxAMed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}