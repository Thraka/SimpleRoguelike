using System;

namespace BaseClasses
{
	public class DiceRoll
	{
		public int DiceSize{ get; }
		public int DiceCount{ get; }
		public DiceRoll(int diceSize, int diceCount)
		{
			DiceSize=diceSize;
			DiceCount=diceCount;
		}
		public int Roll ()
		{
			int total;
			Random rand = new Random ();
			for (int i=0; i< this.DiceCount; i++) {
				total += 1 + rand.Next(DiceSize);
			}
			return total;
		}
	}
}

