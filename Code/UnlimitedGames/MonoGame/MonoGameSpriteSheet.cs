using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UG;
using UG.Physics;
using UG.Graphics;

namespace UG.MonoGame
{
	public class MonoGameSpriteSheet : SpriteSheet
	{
		protected Texture2D texture;

		public MonoGameSpriteSheet(Texture2D texture)
		{
			this.texture = texture;
			size.x = texture.Width;
			size.y = texture.Height;
		}
	}
}