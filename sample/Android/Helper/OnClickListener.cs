using System;
using Android.Views;
using Android.App;

namespace CardFlight.Sample
{
	public class OnClickListener : Java.Lang.Object, View.IOnClickListener
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		public FragmentManager Manager {
			get;
			set;
		}

		#region IOnClickListener implementation

		public void OnClick (View v)
		{			
			int i = 1;
			DialogFragmentHelper dialogFragment = new DialogFragmentHelper ();
			dialogFragment.Manager = this.Manager;
			dialogFragment.shuttleFragment = this.shuttleFragment;
			shuttleFragment.LaunchSwipeEvent ();
			/*switch (i) {
			case Resource.Id.swipeCardButton:
				dialogFragment.CaseButton = Resource.Id.swipeCardButton;
				break;
			case Resource.Id.processPaymentButton:
				dialogFragment.CaseButton = Resource.Id.processPaymentButton;
				break;
			case Resource.Id.serialNumber:
				dialogFragment.CaseButton = Resource.Id.serialNumber;
				break;
			case Resource.Id.tokenizeCard:
				dialogFragment.CaseButton = Resource.Id.tokenizeCard;
				break;
			case Resource.Id.resetFieldsButton:
				dialogFragment.CaseButton = Resource.Id.resetFieldsButton;
				break;
			case Resource.Id.authorizeCard:
				dialogFragment.CaseButton = Resource.Id.authorizeCard;
				break;
			case Resource.Id.processCapture:
				dialogFragment.CaseButton = Resource.Id.processCapture;
				break;
			case Resource.Id.autoConfigButton:
				dialogFragment.CaseButton = Resource.Id.autoConfigButton;
				break;
			case Resource.Id.refundCard:
				dialogFragment.CaseButton = Resource.Id.refundCard;
				break;
			case Resource.Id.voidCard:
				dialogFragment.CaseButton = Resource.Id.voidCard;
				break;
			case Resource.Id.fetchZipCodeButton:
				dialogFragment.CaseButton = Resource.Id.fetchZipCodeButton;
				break;
			}*/
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

