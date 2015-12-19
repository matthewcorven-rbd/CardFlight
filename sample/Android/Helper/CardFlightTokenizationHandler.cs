using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class CardFlightTokenizationHandler : Java.Lang.Object, ICardFlightTokenizationHandler
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region ICardFlightTokenizationHandler implementation

		public void TokenizationFailed (string p0)
		{
			shuttleFragment.TokenizationFailed (p0);
		}

		public void TokenizationSuccessful (string p0)
		{
			shuttleFragment.TokenizationSuccessful (p0);
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

