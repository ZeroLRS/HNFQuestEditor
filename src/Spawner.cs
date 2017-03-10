using System.Collections.Generic;
using System.Xml;

namespace HNFQuestEditor
{
	public class Spawner
	{

		public Spawner(XmlNode spawnerNode)
		{
			mSpawns = new List<SpawnChance>();
			foreach (XmlNode childNode in spawnerNode.ChildNodes)
			{
				if (childNode.Name == "Name")
				{
					mName = childNode.InnerText;
				}
				else
				if (childNode.Name == "Default")
				{
					SpawnChance newChance;
					newChance.mFish.mName = childNode.InnerText;
					newChance.mChance = 100;
				}
				else
				if (childNode.Name == "Fish")
				{
					SpawnChance newChance;
					newChance.mFish.mName = childNode.ChildNodes[0].InnerText;
					newChance.mChance = int.Parse(childNode.ChildNodes[1].InnerText);
					mSpawns.Add(newChance);
				}
			}
		}

		public struct SpawnChance
		{
			public Fish mFish;
			public int mChance;
		}

		public string mName;
		public List<SpawnChance> mSpawns;

	}
}
