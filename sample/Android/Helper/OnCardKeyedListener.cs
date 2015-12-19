using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class OnCardKeyedListener : Java.Lang.Object, IOnCardKeyedListener
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region IOnCardKeyedListener implementation

		public void OnCardKeyed (Getcardflight.Models.Card p0)
		{
			shuttleFragment.OnCardKeyed (p0);
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

