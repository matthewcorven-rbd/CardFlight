using System;
using Getcardflight.Interfaces;
using Android.Widget;
using Java.Interop;
using Android.Content;

namespace CardFlight.Sample
{
	public class CardFlightDeviceHandler : Java.Lang.Object, ICardFlightDeviceHandler
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		public Context context {
			get;
			set;
		}

		#region ICardFlightDeviceHandler implementation

		public void DeviceBeginSwipe ()
		{			
			shuttleFragment.DeviceBeginSwipe ();
		}

		public void DeviceNotSupported ()
		{
			shuttleFragment.DeviceNotSupported ();
		}

		public void DeviceSwipeFailed ()
		{
			shuttleFragment.DeviceSwipeFailed ();
		}

		public void DeviceSwipeTimeout ()
		{
			shuttleFragment.DeviceSwipeTimeout ();
		}

		public void ReaderCardResponse (Getcardflight.Models.Card p0)
		{
			shuttleFragment.ReaderCardResponse (p0);
		}

		public void ReaderIsAttached ()
		{
			shuttleFragment.ReaderIsAttached ();
		}

		public void ReaderIsConnecting ()
		{			
			shuttleFragment.ReaderIsConnecting ();
			//Toast.MakeText (GetApplicationContext (), "Device connecting", ToastLength.Short).Show ();
			//Console.WriteLine ("SE ESTA CONECTANDO!!!");
		}

		public Context GetApplicationContext ()
		{
			return context.ApplicationContext;
		}

		public void ReaderIsDisconnected ()
		{
			shuttleFragment.ReaderIsDisconnected ();
		}

		public void ReaderTimeout ()
		{
			shuttleFragment.ReaderTimeout ();
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

