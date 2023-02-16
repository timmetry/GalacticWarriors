using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using UG;

namespace UG.MonoGame
{
	public class UnlimitedGame : Game
	{
		// TODO: provide optional alternatives
		public const int SCREEN_WIDTH = 1920;
		public const int SCREEN_HEIGHT = 1080;
		public const string CONTENT_FOLDER = "Content";

		private GraphicsDeviceManager graphics;
		private SpriteBatch spriteBatch;

		//TODO: private World _world; 

		protected MonoGameCamera camera;
		protected MonoGameClock clock;

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		public UnlimitedGame()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = CONTENT_FOLDER;

			graphics.PreferredBackBufferWidth = SCREEN_WIDTH;
			graphics.PreferredBackBufferHeight = SCREEN_HEIGHT;

			graphics.HardwareModeSwitch = false;
			graphics.IsFullScreen = true;

			IsFixedTimeStep = true;
			TargetElapsedTime = TimeSpan.FromTicks(166667);

			graphics.SynchronizeWithVerticalRetrace = false;
			graphics.ApplyChanges();

			IsMouseVisible = true;
		}

		sealed protected override void Initialize()
		{
			// SEALED - not used by UG library
			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// TODO: SEAL this and delegate content loading within 
			// the resource container class we'll be using later

			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// initialize the clock and camera for the UG library
			camera = new MonoGameCamera(GraphicsDevice, spriteBatch);
			clock = new MonoGameClock();
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		sealed protected override void UnloadContent()
		{
			// SEALED - not used by UG library
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		sealed protected override void Update(GameTime gameTime)
		{
			// SEALED - all updating is handled here and within world/entities

			// TODO: remove once more stable exit procedure is available
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// make sure the clock is ready to update!
			clock.Update(gameTime);
			clock.Tick();

			// TODO: update world *********************************************

			// make sure no updating can happen outside of here!
			clock.Tock();

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		sealed protected override void Draw(GameTime gameTime)
		{
			// SEALED - all drawing is handled here and within entities/camera

			// make sure the clock and camera are ready to draw!
			clock.Update(gameTime);
			clock.Tick();
			camera.DrawStart();

			// TODO: draw world ***********************************************
			

			// make sure no updating or drawing can happen outside of here!
			camera.DrawStop();
			clock.Tock();

			base.Draw(gameTime);
		}
	}

}