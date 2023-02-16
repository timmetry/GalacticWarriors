using System;

namespace GalacticWarriors
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			using (var game = new TestGame())
				game.Run();
		}
	}
}
