using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArtReport_v2
{
    public partial class FrmStats : Form
    {

        AppManager am;

        public FrmStats(AppManager am)
        {
            this.am = am;

            InitializeComponent();
        }

        private void FrmStats_Load(object sender, EventArgs e)
        {
            //Get the names of Cities.
            string[] x = am.CategoryNames().ToArray();

            //Get the Total of Orders for each City.
            int[] y = am.CatListHours().ToArray();

            chtStats.Series[0].ChartType = SeriesChartType.Bar;
            chtStats.Series[0].IsValueShownAsLabel = true;
            chtStats.Series[0].Points.DataBindXY(x, y);
            chtStats.Legends.Clear();
            chtStats.Titles.Add("Number of Hours Spent in each Category:");
        }

        private void btnSHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome window = new FrmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
