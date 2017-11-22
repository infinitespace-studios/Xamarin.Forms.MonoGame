using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Platform.MonoGame
{
	public class Forms
	{
		static bool _isInitialized = false;
		static Thread _mainThread;
		static Game _game;

		static public Game Game => _game;
		static public Thread MainThread => _mainThread;

		static public void Init (Game game)
		{
			if (_isInitialized) {
				return;
			}
			_game = game;
			_mainThread = Thread.CurrentThread;

			Device.PlatformServices = new MonoGamePlatformServices ();
			Device.SetIdiom (TargetIdiom.Desktop);
			Device.Info = new MonoGameDeviceInfo ();

			//Registrar.RegisterAll (new []
			//	{ typeof(ExportRendererAttribute), typeof(ExportCellAttribute), typeof(ExportImageSourceHandlerAttribute) });
			//ExpressionSearch.Default = new MonoGameExpressionSearch ();

			_isInitialized = true;
		}

		static public void Uninit ()
		{
			Device.PlatformServices = null;
			Device.SetIdiom (TargetIdiom.Unsupported);
			Device.Info = null;

			_mainThread = null;
			_game = null;
			_isInitialized = false;
		}
	}
}
