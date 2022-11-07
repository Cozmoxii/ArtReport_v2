using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtReport_v2
{
    public partial class FrmSeeAll : Form       
    {

        AppManager am;

        public FrmSeeAll(AppManager am)
        {
            this.am = am;

            InitializeComponent();

            rtxCourses.Text = am.FinalCourseSummaries();

            rtxArtworks.Text = am.FinalArtworkSummaries();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome window = new FrmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }


    }


}
