using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Platform.MonoGame
{
	internal class MonoGameDeviceInfo : DeviceInfo
	{
		public override Size PixelScreenSize {
			get {
				throw new System.NotImplementedException ();
			}
		}

		public override Size ScaledScreenSize {
			get {
				throw new System.NotImplementedException ();
			}
		}

		public override double ScalingFactor {
			get {
				throw new System.NotImplementedException ();
			}
		}
	}
}