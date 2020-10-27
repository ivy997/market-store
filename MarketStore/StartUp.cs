namespace MarketStore
{
	using System;

	public class StartUp
	{
		public static void Main(string[] args)
		{
			Bronze bronzeCard = new Bronze(0, 150);
			Silver silverCard = new Silver(600, 850);
			Gold goldCard = new Gold(1500, 1300);

			Console.WriteLine($"1. Bronze {Environment.NewLine}{bronzeCard}");
			Console.WriteLine($"2. Silver {Environment.NewLine}{silverCard}");
			Console.WriteLine($"3. Gold {Environment.NewLine}{goldCard}");
		}
	}
}
