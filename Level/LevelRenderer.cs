using System;

namespace Level
{
	public class LevelRenderer
	{
		public Level CurrentLevel{ get; set;}
		public LevelRenderer (Level level)
		{
			CurrentLevel = level;
		}
	}
}

