
namespace ArtReport_v2
{
    partial class FrmSeeAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeeAll));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.rtxArtworks = new System.Windows.Forms.RichTextBox();
            this.rtxCourses = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 509);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnHome.Location = new System.Drawing.Point(587, 39);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 30);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // rtxArtworks
            // 
            this.rtxArtworks.BackColor = System.Drawing.Color.White;
            this.rtxArtworks.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.rtxArtworks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.rtxArtworks.Location = new System.Drawing.Point(75, 105);
            this.rtxArtworks.Name = "rtxArtworks";
            this.rtxArtworks.ReadOnly = true;
            this.rtxArtworks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxArtworks.Size = new System.Drawing.Size(254, 359);
            this.rtxArtworks.TabIndex = 22;
            this.rtxArtworks.Text = "";
            // 
            // rtxCourses
            // 
            this.rtxCourses.BackColor = System.Drawing.Color.White;
            this.rtxCourses.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F);
            this.rtxCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.rtxCourses.Location = new System.Drawing.Point(362, 105);
            this.rtxCourses.Name = "rtxCourses";
            this.rtxCourses.ReadOnly = true;
            this.rtxCourses.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxCourses.Size = new System.Drawing.Size(256, 359);
            this.rtxCourses.TabIndex = 23;
            this.rtxCourses.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.textBox1.Location = new System.Drawing.Point(102, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "All Artwork Summaries:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.textBox2.Location = new System.Drawing.Point(399, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 24);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "All Course Summaries:";
            // 
            // FrmSeeAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 569);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtxCourses);
            this.Controls.Add(this.rtxArtworks);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSeeAll";
            this.Text = "SeeAll";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RichTextBox rtxArtworks;
        private System.Windows.Forms.RichTextBox rtxCourses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}