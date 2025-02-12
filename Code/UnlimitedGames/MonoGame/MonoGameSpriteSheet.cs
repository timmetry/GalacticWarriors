using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UG.Math2d;
using UG.Graphics;

namespace UG.MonoGame
{
	public class MonoGameSpriteSheet : SpriteSheet
	{
		protected Texture2D texture;

		public MonoGameSpriteSheet(Texture2D texture)
		{
			// TODO: not sure if IsDisposed is a good enough check to verify if Texture2D is valid?
			if (texture != null && !texture.IsDisposed)
			{
				this.texture = texture;
				WakeUp();
			}
			size.x = texture.Width;
			size.y = texture.Height;
		}
	}
}