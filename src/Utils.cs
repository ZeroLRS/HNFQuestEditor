using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace HNFQuestEditor
{

    public class Quest
	{
		public Quest()
		{
			qName = "Untitled Quest";
		}

		public string qName;
		public string qDescription;

		public Level qLevel;

		public Fish qTarget;
		public int qCount;

		public int qCurrencyReward;
	}

	public struct Level
	{
		public string mName;

		public List<Spawner> mSpawners;
	}

	public struct Fish
	{
		public string mName;
	}

	//These are NOT magic numbers, they are specifc info from the form editor
	public struct spawnerPositionData
	{
		public const int LabelX = 14;
		public const int ButtonX = 112;

		public const int LabelStartY = 485;
		public const int ButtonStartY = 480;
		
		public const int DistanceY = 27;

		public const int LabelWidth = 92;
		public const int LabelHeight = 13;
		public const int ButtonWidth = 260;
		public const int ButtonHeight = 21;
	}

}
