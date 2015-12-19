using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class OnFieldResetListener : Java.Lang.Object, IOnFieldResetListener
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region IOnFieldResetListener implementation

		public void OnFieldReset ()
		{
			shuttleFragment.OnFieldReset ();
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

