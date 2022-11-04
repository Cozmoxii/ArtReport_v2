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
    public partial class FrmHome : Form
    {
        AppManager am;

        public FrmHome(AppManager am)
        {
            this.am = am;
            InitializeComponent();

            tbxGoal.Text = am.GetGoal();
        }

        

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse window = new FrmCourse(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmArtwork window = new FrmArtwork(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSeeAll window = new FrmSeeAll(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnSumm_Click(object sender, EventArgs e)
        {
            rtxSumm.Text= am.Summary();
        }

        private void tbxGoal_TextChanged(object sender, EventArgs e)
        {
            am.SetGoal(tbxGoal.Text);
        }


        // private void btnSumm_Click(object sender, EventArgs e)
        //{
        //rtxSumm.Text = am.
        //}
    }
}
