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
    public partial class FrmCourse : Form
    {
        AppManager am;

        public FrmCourse(AppManager am)
        {
            this.am = am;

            InitializeComponent();

            for (int categoryIndex = 0; categoryIndex < am.CountCategories(); categoryIndex++)
            {
                cbxCCat.Items.Add(am.GetCategory(categoryIndex));
            }

            cbxCCat.SelectedIndex = 0;

        }



        private void btnCHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome window = new FrmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course(txbCPlat.Text, txbCNme.Text, (int)nudCTime.Value, (int)nudCPercent.Value, rtxCNts.Text);

            am.AddCourse(cbxCCat.Text,newCourse);

            rtxCSumm.Text = am.AddedCourseSummary(cbxCCat.Text);


        }

        private void btnCClear_Click(object sender, EventArgs e)
        {
            txbCNme.Text = "";
            txbCPlat.Text = "";
            cbxCCat.Text = "";
            nudCTime.Value = 0;
            nudCPercent.Value = 0;
            rtxCNts.Text = "";
            rtxCSumm.Text = "";

        }

       
    }
}
