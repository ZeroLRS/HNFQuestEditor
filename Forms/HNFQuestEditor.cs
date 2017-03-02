using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HNFQuestEditor
{
    public partial class frmHNFQE : Form
    {
        public frmHNFQE()
        {
            InitializeComponent();
        }

        private void frmHNFQE_Load(object sender, EventArgs e)
        {
            //drpLevelSelect.SelectedIndex = 0;
        }

        private void drpLevelSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
