﻿using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Platform.MonoGame
{
	internal class MonoGamePlatformServices : IPlatformServices
	{
		public bool IsInvokeRequired => throw new NotImplementedException ();

		public string RuntimePlatform => throw new NotImplementedException ();

		public void BeginInvokeOnMainThread (Action action)
		{
			throw new NotImplementedException ();
		}

		public Ticker CreateTicker ()
		{
			throw new NotImplementedException ();
		}

		public Assembly [] GetAssemblies ()
		{
			throw new NotImplementedException ();
		}

		public string GetMD5Hash (string input)
		{
			throw new NotImplementedException ();
		}

		public double GetNamedSize (NamedSize size, Type targetElementType, bool useOldSizes)
		{
			throw new NotImplementedException ();
		}

		public Task<Stream> GetStreamAsync (Uri uri, CancellationToken cancellationToken)
		{
			throw new NotImplementedException ();
		}

		public IIsolatedStorageFile GetUserStoreForApplication ()
		{
			throw new NotImplementedException ();
		}

		public void OpenUriAction (Uri uri)
		{
			throw new NotImplementedException ();
		}

		public void QuitApplication ()
		{
			throw new NotImplementedException ();
		}

		public void StartTimer (TimeSpan interval, Func<bool> callback)
		{
			throw new NotImplementedException ();
		}
	}
}