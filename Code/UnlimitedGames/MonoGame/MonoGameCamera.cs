using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UG
{
	public class MonoGameCamera : Camera
	{
		public Color backgroundColor = Color.Black;

		private GraphicsDevice graphicsDevice;
		private SpriteBatch spriteBatch;

		public MonoGameCamera(GraphicsDevice graphicsDevice, SpriteBatch spriteBatch)
			:base()
		{
			this.graphicsDevice = graphicsDevice;
			this.spriteBatch = spriteBatch;
		}

		protected override void ClearAll()
		{
			//RequireSleep();
			graphicsDevice.Clear(backgroundColor);
		}

		public void DrawStart()
		{
			ClearAll();
			spriteBatch.Begin();
			WakeUp();
		}
		public void DrawStop()
		{
			Sleep();
			spriteBatch.End();
		}
	}
}
