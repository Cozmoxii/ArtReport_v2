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
    public partial class FrmArtwork : Form
    {
        AppManager am;

        public FrmArtwork(AppManager am)
        {
            this.am = am;

            InitializeComponent();

            

            for (int categoryIndex = 0; categoryIndex < am.CountCategories(); categoryIndex++)
            {
                cbxACat.Items.Add(am.GetCategory(categoryIndex));
            }

            cbxACat.SelectedIndex = 0;

            cbxAMed.SelectedIndex = 0;
        }

        private void btnAHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome window = new FrmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            Artwork newArtwork = new Artwork(txbANme.Text, cbxAMed.Text, (int)nudATime.Value, rtxANts.Text);

            am.AddArtwork(cbxACat.Text, newArtwork);

            rtxASumm.Text = am.AddedArtworkSummary(cbxACat.Text);


        }

        private void btnAClear_Click(object sender, EventArgs e)
        {
            txbANme.Text = "";
            cbxAMed.Text = "";
            nudATime.Value = 0;
            rtxANts.Text = "";
            rtxASumm.Text = "";
        }

        
    }
}
