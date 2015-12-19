using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class CardFlightCaptureHandler : Java.Lang.Object, ICardFlightCaptureHandler
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region ICardFlightCaptureHandler implementation

		public void CaptureFailed (string p0)
		{
			shuttleFragment.CaptureFailed (p0);
		}

		public void CaptureSuccessful (Getcardflight.Models.Charge p0)
		{
			shuttleFragment.CaptureSuccessful (p0);
		}

		#endregion

		#region IDisposable implementation

		public void Dispose ()
		{
			throw new NotImplementedException ();
		}

		#endregion

		#region IJavaObject implementation

		public IntPtr Handle {
			get {
				return new System.IntPtr ();
			}
		}

		#endregion
	}
}

