using System;
using Getcardflight.Interfaces;

namespace CardFlight.Sample
{
	public class CardFlightAutoConfigHandler : ICardFlightAutoConfigHandler
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		#region ICardFlightAutoConfigHandler implementation
		public void AutoConfigFailed ()
		{
			shuttleFragment.AutoConfigFailed ();
		}
		public void AutoConfigFinished ()
		{
			shuttleFragment.AutoConfigFinished ();
		}
		public void AutoConfigProgressUpdate (int p0)
		{
			shuttleFragment.AutoConfigProgressUpdate (p0);
		}
		#endregion
		#region IDisposable implementation
		public void Dispose ()
		{

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