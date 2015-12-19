using System;
using UIKit;

namespace CardFlight.Sample
{
	public class MyRCFTReaderDelegate : CFTReaderDelegate
	{
		CFTMainViewController _controller = null;

		public MyRCFTReaderDelegate (CFTMainViewController controller)
		{
			_controller = controller;
		}

		public override void ReaderCardResponse (CFTCard card, Foundation.NSError error)
		{
			if (card != null)
				new UIAlertView ("Card Info", "Name: " + card.Name + " | Number: **** **** **** " + card.Last4, null, "Ok", null).Show ();
		}

		public override void ReaderIsDisconnected ()
		{
			new UIAlertView ("Message", "Reader is Disconnected", null, "Ok", null).Show ();
		}

		public override void ReaderIsConnected (bool isConnected, Foundation.NSError error)
		{
			if (isConnected)
				new UIAlertView ("Message", "Reader is Connected", null, "Ok", null).Show ();
			else
				new UIAlertView ("Message", "Reader is Disconnected", null, "Ok", null).Show ();
		}

		#region implemented abstract members of CFTReaderDelegate

		public override void TransactionResult (CFTCharge charge, Foundation.NSError error)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}

	public class CFTMainViewController : UIViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var reader = new CFTReader (0);
			reader.Delegate = new MyRCFTReaderDelegate (this);
			new UIAlertView ("Message", "Touch the screen for read a card", null, "Ok", null).Show ();

			UITapGestureRecognizer singleTap = new UITapGestureRecognizer (new Action (delegate {	
				reader.BeginSwipe ();
			}));
		}
	}
}