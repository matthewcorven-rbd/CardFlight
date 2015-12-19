using System;
using Android.App;

namespace CardFlight.Sample
{
	public class DialogFragmentHelper : DialogFragment
	{
		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		public FragmentManager Manager {
			get;
			set;
		}

		public int CaseButton {
			get;
			set;
		}

		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			switch (CaseButton) {
			case Resource.Id.swipeCardButton:
				shuttleFragment.LaunchSwipeEvent ();
				break;
			case Resource.Id.processPaymentButton:
				this.RetainInstance = true;
				this.Cancelable = false;
				this.Show (Manager, "dialogFragment");
				break;
			case Resource.Id.serialNumber:
				shuttleFragment.DisplaySerialNumber ();
				break;
			case Resource.Id.tokenizeCard:
				shuttleFragment.TokenizeCardMethod ();
				break;
			case Resource.Id.resetFieldsButton:
				shuttleFragment.ResetFieldHolder ();
				break;
			case Resource.Id.authorizeCard:
				this.RetainInstance = true;
				this.Cancelable = false;
				this.Show (Manager, "dialogFragment");
				break;
			case Resource.Id.processCapture:
				shuttleFragment.CaptureCharge ();
				break;
			case Resource.Id.autoConfigButton:
				shuttleFragment.StartAutoConfigProcess ();
				break;
			case Resource.Id.refundCard:
				this.RetainInstance = true;
				this.Cancelable = false;
				this.Show (Manager, "dialogFragment");
				break;
			case Resource.Id.voidCard:
				shuttleFragment.voidCharge ();
				break;
			case Resource.Id.fetchZipCodeButton:
				shuttleFragment.FetchZipCodeButton ();
				break;
			default:
				break;
			}
		}
	}
}

