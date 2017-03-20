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
using System.IO;

using System.Xml;


namespace HNFQuestEditor
{

	public partial class frmHNFQE : Form
	{
		public static string mTitle;

		Quest mLoadedQuest;
        List<string> mFish;

        public frmHNFQE()
		{
			InitializeComponent();
		}

		private void frmHNFQE_Load(object sender, EventArgs e)
		{
			//Populate quest typtes
			drpQuestType.SelectedIndex = 0;
			//Populate fish types
			drpTarget.SelectedIndex = 0;
			//Populate level list
			drpLevelSelect.SelectedIndex = 0;

			mTitle = this.Text;
			mLoadedQuest = new Quest();

            mFish = new List<string>();
            loadFish("../../Data/FishList.txt");

            loadLevel("../../Data/Levels/Coral Reef/Level.xml");

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
			//Load up the level's xml file
			XmlDocument levelDoc = new XmlDocument();
			levelDoc.Load(path);

			//Create a new level to store data in
			Level currLevel = new Level();
			currLevel.mSpawners = new List<Spawner>();

			Debug.WriteLine("Going through xml");
			//This is the <Level>, skipping the <?xml ... ?>
			XmlNode levelNode = levelDoc.ChildNodes[1];

			//Loop through each child node creating the needed data from each
			foreach (XmlNode childNode in levelNode.ChildNodes)
			{
				if(childNode.Name == "Name")
				{
					//Set the window's title 
					this.Text = mTitle + "  - " + mLoadedQuest.qName + " - " + childNode.InnerText;
					currLevel.mName = childNode.Name;
				}
				else
				if (childNode.Name == "Thumbnail")
				{
					//Load in the thumbnail and set it to display.
				}
				else
				if (childNode.Name == "Spawner")
				{
					Spawner currSpawner = new Spawner(childNode);
					currLevel.mSpawners.Add(currSpawner);
				}

			}

            int spawnerIndex = 0;
            foreach (Spawner spawner in currLevel.mSpawners)
            {
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

                Label sLbl = new Label();
                sLbl.Text = spawner.mName + ":";
                sLbl.Name = "lblSpawner" + spawnerIndex;
                sLbl.Location = new System.Drawing.Point(spawnerPositionData.LabelX, spawnerPositionData.LabelStartY + spawnerPositionData.DistanceY * spawnerIndex);
                sLbl.Size = new Size(spawnerPositionData.LabelWidth, spawnerPositionData.LabelHeight);

                Button sBtn = new Button();
                sBtn.Text = "Edit Spawner";
                sBtn.Name = "btnSpawner" + spawnerIndex;
                sBtn.Location = new System.Drawing.Point(spawnerPositionData.ButtonX, spawnerPositionData.ButtonStartY + spawnerPositionData.DistanceY * spawnerIndex);
                sBtn.Size = new Size(spawnerPositionData.ButtonWidth, spawnerPositionData.ButtonHeight);

                SpawnerEdit sForm = new SpawnerEdit(mFish);
                for (int i = 0; i < spawner.mSpawns.Count; i++)
                {
                    int fishIndex = mFish.IndexOf(spawner.mSpawns[i].mFish.mName);
                    sForm.mFish[i].SelectedIndex = fishIndex + 1;
                    sForm.mChances[i].Value = spawner.mSpawns[i].mChance;
                }

                sBtn.Click += (s,e) => { sForm.Show(); };

                this.Controls.Add(sLbl);
                this.Controls.Add(sBtn);

                spawnerIndex++;
            }

            Debug.WriteLine("Done with xml");

		}

		private void saveQuest(string path)
		{

		}

        private void loadFish(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                mFish.Add(line);
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			SpawnerEdit editForm = new SpawnerEdit();
			editForm.Show();
		}
	}
}
