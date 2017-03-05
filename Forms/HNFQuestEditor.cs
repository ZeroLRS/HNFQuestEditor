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
        Quest mLoadedQuest;
        List<String> mQuestNames;
        List<Fish> mFish;
        List<ComboBox> mSpawnerDropdowns;

        public frmHNFQE()
        {
            InitializeComponent();
        }

        private void frmHNFQE_Load(object sender, EventArgs e)
        {
            drpQuestType.SelectedIndex = 0;
            drpTarget.SelectedIndex = 0;
            drpLevelSelect.SelectedIndex = 0;
            drpSpawner0.SelectedIndex = 0;
            drpSpawner1.SelectedIndex = 0;
            drpSpawner2.SelectedIndex = 0;
            drpSpawner3.SelectedIndex = 0;
            /**********************************
             * //Sample Code for creating a new control in the form
             * 
             * Button testBtn = new Button();
             * testBtn.Text = "Test Button";
             * testBtn.Name = "btnTest";
             * testBtn.Location = new System.Drawing.Point(200, 200);
             * this.Controls.Add(testBtn);
             * 
             **********************************/
             


        }

        public void createSpawner()
        {

        }

        public void confirmForm()
        {
            mLoadedQuest.qName = txtQuestName.Text;
        }

        private void loadLevel(string path)
        {

        }

        private void saveLevel(string path)
        {

        }
    }
}
