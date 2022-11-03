
namespace ArtReport_v2
{
    public partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnArt = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbxGoal = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.btnSumm = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.rtxSumm = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArt
            // 
            this.btnArt.BackColor = System.Drawing.Color.White;
            this.btnArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArt.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnArt.Location = new System.Drawing.Point(196, 70);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(79, 43);
            this.btnArt.TabIndex = 1;
            this.btnArt.Text = "Add New Artwork";
            this.btnArt.UseVisualStyleBackColor = false;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.White;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnCourse.Location = new System.Drawing.Point(333, 70);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(79, 43);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "Add New Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnAll.Location = new System.Drawing.Point(236, 119);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(134, 27);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "See All Added";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblProgress.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblProgress.Location = new System.Drawing.Point(213, 31);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(188, 20);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Progress Generator:";
            // 
            // tbxGoal
            // 
            this.tbxGoal.Location = new System.Drawing.Point(196, 216);
            this.tbxGoal.Name = "tbxGoal";
            this.tbxGoal.Size = new System.Drawing.Size(216, 20);
            this.tbxGoal.TabIndex = 7;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.lblGoal.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.lblGoal.Location = new System.Drawing.Point(258, 197);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(101, 16);
            this.lblGoal.TabIndex = 8;
            this.lblGoal.Text = "Overall Goal:";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSumm
            // 
            this.btnSumm.BackColor = System.Drawing.SystemColors.Window;
            this.btnSumm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumm.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnSumm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnSumm.Location = new System.Drawing.Point(196, 261);
            this.btnSumm.Name = "btnSumm";
            this.btnSumm.Size = new System.Drawing.Size(79, 43);
            this.btnSumm.TabIndex = 9;
            this.btnSumm.Text = "Progress Summary";
            this.btnSumm.UseVisualStyleBackColor = false;
            this.btnSumm.Click += new System.EventHandler(this.btnSumm_Click);
            // 
            // btnStat
            // 
            this.btnStat.BackColor = System.Drawing.Color.White;
            this.btnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStat.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnStat.Location = new System.Drawing.Point(333, 261);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(79, 43);
            this.btnStat.TabIndex = 10;
            this.btnStat.Text = "Category Statistics";
            this.btnStat.UseVisualStyleBackColor = false;
            // 
            // rtxSumm
            // 
            this.rtxSumm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxSumm.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.rtxSumm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.rtxSumm.Location = new System.Drawing.Point(184, 328);
            this.rtxSumm.Name = "rtxSumm";
            this.rtxSumm.Size = new System.Drawing.Size(261, 225);
            this.rtxSumm.TabIndex = 11;
            this.rtxSumm.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pictureBox2.Location = new System.Drawing.Point(114, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 561);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 603);
            this.Controls.Add(this.rtxSumm);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnSumm);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.tbxGoal);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnArt);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox tbxGoal;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Button btnSumm;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.RichTextBox rtxSumm;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}