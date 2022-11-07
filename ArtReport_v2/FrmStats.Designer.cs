namespace ArtReport_v2
{
    partial class FrmStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStats));
            this.chtStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtStats)).BeginInit();
            this.SuspendLayout();
            // 
            // chtStats
            // 
            chartArea1.Name = "ChartArea1";
            this.chtStats.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtStats.Legends.Add(legend1);
            this.chtStats.Location = new System.Drawing.Point(23, 12);
            this.chtStats.Name = "chtStats";
            this.chtStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chtStats.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtStats.Series.Add(series1);
            this.chtStats.Size = new System.Drawing.Size(641, 466);
            this.chtStats.TabIndex = 0;
            // 
            // btnSHome
            // 
            this.btnSHome.BackColor = System.Drawing.Color.White;
            this.btnSHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.btnSHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(115)))), ((int)(((byte)(43)))));
            this.btnSHome.Location = new System.Drawing.Point(688, 12);
            this.btnSHome.Name = "btnSHome";
            this.btnSHome.Size = new System.Drawing.Size(56, 30);
            this.btnSHome.TabIndex = 37;
            this.btnSHome.Text = "Home";
            this.btnSHome.UseVisualStyleBackColor = false;
            this.btnSHome.Click += new System.EventHandler(this.btnSHome_Click);
            // 
            // FrmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.btnSHome);
            this.Controls.Add(this.chtStats);
            this.Name = "FrmStats";
            this.Text = "FrmStats";
            this.Load += new System.EventHandler(this.FrmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtStats;
        private System.Windows.Forms.Button btnSHome;
    }
}