using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Xamarin.Forms.Platform.MonoGame;

namespace FormsSample
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;

		public Game1()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
		}

		protected override void Initialize ()
		{
			base.Initialize ();
			Forms.Init (this);
		}

		protected override void LoadContent ()
		{
		}

		protected override void Update (GameTime gameTime)
		{
			base.Update (gameTime);
		}

		protected override void Draw (GameTime gameTime)
		{
			GraphicsDevice.Clear (Color.CornflowerBlue);
			base.Draw (gameTime);
		}
	}
}
