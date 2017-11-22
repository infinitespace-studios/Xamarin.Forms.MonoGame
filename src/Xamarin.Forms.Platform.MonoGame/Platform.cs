using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Platform.MonoGame
{
	public class Platform : BindableObject, IPlatform, INavigation, IDisposable
	{
		public IReadOnlyList<Page> ModalStack => throw new NotImplementedException ();

		public IReadOnlyList<Page> NavigationStack => throw new NotImplementedException ();

		internal Platform (Game game)
		{

		}

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		public SizeRequest GetNativeSize (VisualElement view, double widthConstraint, double heightConstraint)
		{
			throw new NotImplementedException ();
		}

		public void InsertPageBefore (Page page, Page before)
		{
			throw new NotImplementedException ();
		}

		public Task<Page> PopAsync ()
		{
			throw new NotImplementedException ();
		}

		public Task<Page> PopAsync (bool animated)
		{
			throw new NotImplementedException ();
		}

		public Task<Page> PopModalAsync ()
		{
			throw new NotImplementedException ();
		}

		public Task<Page> PopModalAsync (bool animated)
		{
			throw new NotImplementedException ();
		}

		public Task PopToRootAsync ()
		{
			throw new NotImplementedException ();
		}

		public Task PopToRootAsync (bool animated)
		{
			throw new NotImplementedException ();
		}

		public Task PushAsync (Page page)
		{
			throw new NotImplementedException ();
		}

		public Task PushAsync (Page page, bool animated)
		{
			throw new NotImplementedException ();
		}

		public Task PushModalAsync (Page page)
		{
			throw new NotImplementedException ();
		}

		public Task PushModalAsync (Page page, bool animated)
		{
			throw new NotImplementedException ();
		}

		public void RemovePage (Page page)
		{
			throw new NotImplementedException ();
		}
	}
}
