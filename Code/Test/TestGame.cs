using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using UG;
using UG.MonoGame;

namespace GalacticWarriors
{
	public class TestGame : UnlimitedGame
	{
		protected SpriteFont basicFont;

		protected Texture2D grassTexture;
		protected Texture2D waterTexture;
		protected Texture2D healthCircleTexture;

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			base.LoadContent();

			// load fonts
			basicFont = Content.Load<SpriteFont>("BasicFont");

			// TODO: load sprites
			grassTexture = Content.Load<Texture2D>("terrain grass");
			waterTexture = Content.Load<Texture2D>("terrain water");
			healthCircleTexture = Content.Load<Texture2D>("HealthCircle");

			// TODO: load music

			// TODO: load sounds

			// TODO: load the first world
		}
	}
}
