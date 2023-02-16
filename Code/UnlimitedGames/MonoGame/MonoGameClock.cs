using Microsoft.Xna.Framework;

namespace UG.MonoGame
{
	public class MonoGameClock : Clock
	{

		private GameTime gameTime;

		public void Update(GameTime newGameTime)
		{
			gameTime = newGameTime;
		}
	}
}
