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

	//These are NOT magic numbers, they are specifc info from the visual editor
	public struct spawnerPositionData
	{
		public const int LabelX = 14;
		public const int DropX = 112;

		public const int LabelStartY = 444;
		public const int DropStartY = 441;
		
		public const int DistanceY = 27;

		public const int LabelWidth = 88;
		public const int LabelHeight = 13;
		public const int DropWidth = 260;
		public const int DropHeight = 21;
	}

}
