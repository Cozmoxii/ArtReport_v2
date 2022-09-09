
namespace ArtReport_v2
{
    partial class FrmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourse));
            this.lblAddC = new System.Windows.Forms.Label();
            this.lblCPlat = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCCat = new System.Windows.Forms.Label();
            this.lblCTime = new System.Windows.Forms.Label();
            this.lblCPercent = new System.Windows.Forms.Label();
            this.lblCNts = new System.Windows.Forms.Label();
            this.txbCNme = new System.Windows.Forms.TextBox();
            this.txbCPlat = new System.Windows.Forms.TextBox();
            this.cbxCCat = new System.Windows.Forms.ComboBox();
            this.nudCTime = new System.Windows.Forms.NumericUpDown();
            this.nudCPercent = new System.Windows.Forms.NumericUpDown();
            this.rtxCNts = new System.Windows.Forms.RichTextBox();
            this.rtxCSumm = new System.Windows.Forms.RichTextBox();
            this.lblCSumm = new System.Windows.Forms.Label();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCClear = new System.Windows.Forms.Button();
            this.btnCHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddC
            // 
            this.lblAddC.AutoSize = true;
            this.lblAddC.Location = new System.Drawing.Point(175, 35);
            this.lblAddC.Name = "lblAddC";
            this.lblAddC.Size = new System.Drawing.Size(90, 13);
            this.lblAddC.TabIndex = 0;
            this.lblAddC.Text = "Add New Course:";
            // 
            // lblCPlat
            // 
            this.lblCPlat.AutoSize = true;
            this.lblCPlat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCPlat.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPlat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(135)))));
            this.lblCPlat.Location = new System.Drawing.Point(83, 121);
            this.lblCPlat.Name = "lblCPlat";
            this.lblCPlat.Size = new System.Drawing.Size(59, 15);
            this.lblCPlat.TabIndex = 1;
            this.lblCPlat.Text = "Platform:";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.BackColor = System.Drawing.Color.White;
            this.lblCName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(135)))));
            this.lblCName.Location = new System.Drawing.Point(83, 94);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(45, 15);
            this.lblCName.TabIndex = 2;
            this.lblCName.Text = "Name:";
            // 
            // lblCCat
            // 
            this.lblCCat.AutoSize = true;
            this.lblCCat.BackColor = System.Drawing.Color.White;
            this.lblCCat.Location = new System.Drawing.Point(83, 152);
            this.lblCCat.Name = "lblCCat";
            this.lblCCat.Size = new System.Drawing.Size(52, 13);
            this.lblCCat.TabIndex = 3;
            this.lblCCat.Text = "Category:";
            // 
            // lblCTime
            // 
            this.lblCTime.AutoSize = true;
            this.lblCTime.BackColor = System.Drawing.Color.White;
            this.lblCTime.Location = new System.Drawing.Point(83, 188);
            this.lblCTime.Name = "lblCTime";
            this.lblCTime.Size = new System.Drawing.Size(81, 13);
            this.lblCTime.TabIndex = 4;
            this.lblCTime.Text = "Time Spent(hrs)";
            // 
            // lblCPercent
            // 
            this.lblCPercent.AutoSize = true;
            this.lblCPercent.BackColor = System.Drawing.Color.White;
            this.lblCPercent.Location = new System.Drawing.Point(83, 218);
            this.lblCPercent.Name = "lblCPercent";
            this.lblCPercent.Size = new System.Drawing.Size(117, 26);
            this.lblCPercent.TabIndex = 5;
            this.lblCPercent.Text = "Percentage completed:\r\n(out of 100)";
            // 
            // lblCNts
            // 
            this.lblCNts.AutoSize = true;
            this.lblCNts.BackColor = System.Drawing.Color.White;
            this.lblCNts.Location = new System.Drawing.Point(110, 264);
            this.lblCNts.Name = "lblCNts";
            this.lblCNts.Size = new System.Drawing.Size(38, 13);
            this.lblCNts.TabIndex = 6;
            this.lblCNts.Text = "Notes:";
            // 
            // txbCNme
            // 
            this.txbCNme.Location = new System.Drawing.Point(225, 94);
            this.txbCNme.Name = "txbCNme";
            this.txbCNme.Size = new System.Drawing.Size(121, 20);
            this.txbCNme.TabIndex = 7;
            // 
            // txbCPlat
            // 
            this.txbCPlat.Location = new System.Drawing.Point(225, 121);
            this.txbCPlat.Name = "txbCPlat";
            this.txbCPlat.Size = new System.Drawing.Size(121, 20);
            this.txbCPlat.TabIndex = 8;
            // 
            // cbxCCat
            // 
            this.cbxCCat.FormattingEnabled = true;
            this.cbxCCat.Location = new System.Drawing.Point(225, 152);
            this.cbxCCat.Name = "cbxCCat";
            this.cbxCCat.Size = new System.Drawing.Size(121, 21);
            this.cbxCCat.TabIndex = 9;
            // 
            // nudCTime
            // 
            this.nudCTime.Location = new System.Drawing.Point(226, 186);
            this.nudCTime.Name = "nudCTime";
            this.nudCTime.Size = new System.Drawing.Size(120, 20);
            this.nudCTime.TabIndex = 10;
            // 
            // nudCPercent
            // 
            this.nudCPercent.Location = new System.Drawing.Point(227, 218);
            this.nudCPercent.Name = "nudCPercent";
            this.nudCPercent.Size = new System.Drawing.Size(120, 20);
            this.nudCPercent.TabIndex = 11;
            // 
            // rtxCNts
            // 
            this.rtxCNts.Location = new System.Drawing.Point(226, 244);
            this.rtxCNts.Name = "rtxCNts";
            this.rtxCNts.Size = new System.Drawing.Size(122, 82);
            this.rtxCNts.TabIndex = 13;
            this.rtxCNts.Text = "";
            // 
            // rtxCSumm
            // 
            this.rtxCSumm.Location = new System.Drawing.Point(452, 94);
            this.rtxCSumm.Name = "rtxCSumm";
            this.rtxCSumm.Size = new System.Drawing.Size(214, 232);
            this.rtxCSumm.TabIndex = 14;
            this.rtxCSumm.Text = "";
            // 
            // lblCSumm
            // 
            this.lblCSumm.AutoSize = true;
            this.lblCSumm.BackColor = System.Drawing.Color.White;
            this.lblCSumm.Location = new System.Drawing.Point(535, 78);
            this.lblCSumm.Name = "lblCSumm";
            this.lblCSumm.Size = new System.Drawing.Size(53, 13);
            this.lblCSumm.TabIndex = 15;
            this.lblCSumm.Text = "Summary:";
            // 
            // btnCAdd
            // 
            this.btnCAdd.BackColor = System.Drawing.Color.White;
            this.btnCAdd.Location = new System.Drawing.Point(253, 350);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(95, 30);
            this.btnCAdd.TabIndex = 16;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = false;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCClear
            // 
            this.btnCClear.BackColor = System.Drawing.Color.White;
            this.btnCClear.Location = new System.Drawing.Point(583, 350);
            this.btnCClear.Name = "btnCClear";
            this.btnCClear.Size = new System.Drawing.Size(83, 30);
            this.btnCClear.TabIndex = 17;
            this.btnCClear.Text = "Clear Form";
            this.btnCClear.UseVisualStyleBackColor = false;
            this.btnCClear.Click += new System.EventHandler(this.btnCClear_Click);
            // 
            // btnCHome
            // 
            this.btnCHome.BackColor = System.Drawing.Color.White;
            this.btnCHome.Location = new System.Drawing.Point(619, 27);
            this.btnCHome.Name = "btnCHome";
            this.btnCHome.Size = new System.Drawing.Size(101, 20);
            this.btnCHome.TabIndex = 18;
            this.btnCHome.Text = "Go Back to Home";
            this.btnCHome.UseVisualStyleBackColor = false;
            this.btnCHome.Click += new System.EventHandler(this.btnCHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 404);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.btnCHome);
            this.Controls.Add(this.btnCClear);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.lblCSumm);
            this.Controls.Add(this.rtxCSumm);
            this.Controls.Add(this.rtxCNts);
            this.Controls.Add(this.nudCPercent);
            this.Controls.Add(this.nudCTime);
            this.Controls.Add(this.cbxCCat);
            this.Controls.Add(this.txbCPlat);
            this.Controls.Add(this.txbCNme);
            this.Controls.Add(this.lblCNts);
            this.Controls.Add(this.lblCPercent);
            this.Controls.Add(this.lblCTime);
            this.Controls.Add(this.lblCCat);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCPlat);
            this.Controls.Add(this.lblAddC);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FrmCourse";
            this.Text = "FrmCourse";
            ((System.ComponentModel.ISupportInitialize)(this.nudCTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddC;
        private System.Windows.Forms.Label lblCPlat;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCCat;
        private System.Windows.Forms.Label lblCTime;
        private System.Windows.Forms.Label lblCPercent;
        private System.Windows.Forms.Label lblCNts;
        private System.Windows.Forms.TextBox txbCNme;
        private System.Windows.Forms.TextBox txbCPlat;
        private System.Windows.Forms.ComboBox cbxCCat;
        private System.Windows.Forms.NumericUpDown nudCTime;
        private System.Windows.Forms.NumericUpDown nudCPercent;
        private System.Windows.Forms.RichTextBox rtxCNts;
        private System.Windows.Forms.RichTextBox rtxCSumm;
        private System.Windows.Forms.Label lblCSumm;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCClear;
        private System.Windows.Forms.Button btnCHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}