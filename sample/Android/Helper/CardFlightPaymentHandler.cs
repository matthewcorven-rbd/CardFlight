using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class CardFlightPaymentHandler : Java.Lang.Object, ICardFlightPaymentHandler
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region ICardFlightPaymentHandler implementation

		public void TransactionFailed (string p0)
		{
			shuttleFragment.TransactionFailed (p0);
		}

		public void TransactionSuccessful (Getcardflight.Models.Charge p0)
		{
			shuttleFragment.TransactionSuccessful (p0);
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

