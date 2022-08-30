
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
            this.btnArt = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbxGoal = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.btnSumm = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(250, 51);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(84, 43);
            this.btnArt.TabIndex = 1;
            this.btnArt.Text = "Add New Artwork";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(387, 51);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(79, 43);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "Add New Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(292, 100);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(134, 27);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "See All Added";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(336, 21);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Progress:";
            // 
            // tbxGoal
            // 
            this.tbxGoal.Location = new System.Drawing.Point(250, 190);
            this.tbxGoal.Name = "tbxGoal";
            this.tbxGoal.Size = new System.Drawing.Size(216, 20);
            this.tbxGoal.TabIndex = 7;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(319, 156);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(68, 13);
            this.lblGoal.TabIndex = 8;
            this.lblGoal.Text = "Overall Goal:";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSumm
            // 
            this.btnSumm.Location = new System.Drawing.Point(255, 248);
            this.btnSumm.Name = "btnSumm";
            this.btnSumm.Size = new System.Drawing.Size(84, 34);
            this.btnSumm.TabIndex = 9;
            this.btnSumm.Text = "Progress Summary";
            this.btnSumm.UseVisualStyleBackColor = true;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(387, 248);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(84, 34);
            this.btnStat.TabIndex = 10;
            this.btnStat.Text = "Category Statistics";
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 244);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 544);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnSumm);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.tbxGoal);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnArt);
            this.Name = "FrmHome";
            this.Text = "Home";
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}