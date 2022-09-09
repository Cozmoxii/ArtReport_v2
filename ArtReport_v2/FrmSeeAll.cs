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
        }
    }
}
