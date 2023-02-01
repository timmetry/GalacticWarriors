using Microsoft.Xna.Framework;

namespace UG.MonoGame
{
	public class MonoGameClock : Clock
	{

		private GameTime gameTime;

		public void UpdateStart(GameTime newGameTime)
		{
			Tick();
			gameTime = newGameTime;
			WakeUp();
		}
		public void UpdateStop()
		{
			Sleep();
		}
		public void DrawStart(GameTime newGameTime)
		{
			gameTime = newGameTime;
			//WakeUp();
		}
		public void DrawStop()
		{
			//Sleep();
		}
	}
}
