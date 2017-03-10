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

using System.Xml;


namespace HNFQuestEditor
{

	public partial class frmHNFQE : Form
	{
		public static string mTitle;

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
			//Populate quest typtes
			drpQuestType.SelectedIndex = 0;
			//Populate fish types
			drpTarget.SelectedIndex = 0;
			//Populate level list
			drpLevelSelect.SelectedIndex = 0;

			mTitle = this.Text;
			mLoadedQuest = new Quest();

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

			Debug.WriteLine("Done with xml");

		}

		private void saveQuest(string path)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SpawnerEdit editForm = new SpawnerEdit();
			editForm.Show();
		}
	}
}
