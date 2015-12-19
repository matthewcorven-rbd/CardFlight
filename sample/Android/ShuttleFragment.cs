using System;
using Android.Content;
using Android.Widget;
using Android.Views;
using Getcardflight.Views;
using Getcardflight.Models;
using Getcardflight.Interfaces;
using Android.Util;
using Android.OS;
using Android.App;

namespace CardFlight.Sample
{
	public class ShuttleFragment : Fragment, View.IOnClickListener
	{
		private static String TAG = "ShuttleFragment";
		private Context mContext;

		private bool readerIsConnected = true;
		private bool readerFailed;
		private bool swipedCard;

		private Button swipeCardButton;
		private Button processPaymentButton;
		private Button resetFieldsButton;
		private Button displaySerialButton;
		private Button tokenizeCardButton;
		private Button authorizeCardButton;
		private Button captureChargeButton;
		private Button autoConfigButton;
		private Button zipCodeButton;
		private Button voidButton;
		private Button refundButton;
		private TextView readerStatus;
		private TextView cardNumber;
		private TextView cardType;
		private TextView cardLastFour;
		private TextView chargeToken;
		private TextView chargeAmount;
		private TextView chargeCaptured;
		private TextView chargeVoided;
		private TextView chargeRefunded;
		private TextView zipCode;
		private CheckBox zipCodeEnabled;

		private Reader reader = null;
		private Card mCard = null;
		private Charge mCharge = null;
		private OnCardKeyedListener onCardKeyedListener;
		private OnFieldResetListener onFieldResetListener;
		private PaymentView mFieldHolder;

		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			mContext = Activity;
			RetainInstance = true;

			// Instantiate CardFlight Instance
			Getcardflight.Models.CardFlight.Instance.SetApiTokenAndAccountToken (Settings.API_TOKEN, Settings.ACCOUNT_TOKEN);
			Getcardflight.Models.CardFlight.Instance.SetLogging ((Java.Lang.Boolean)true);

			// Create a new Reader object with AutoConfig handler
			CardFlightDeviceHandler cardFlightDeviceHandler = new CardFlightDeviceHandler ();
			cardFlightDeviceHandler.shuttleFragment = this;
			cardFlightDeviceHandler.context = mContext.ApplicationContext;
			cardFlightDeviceHandler.ReaderIsConnecting ();

			CardFlightAutoConfigHandler cardFlightAutoConfigHandler = new CardFlightAutoConfigHandler ();
			cardFlightAutoConfigHandler.shuttleFragment = this;

			reader = new Reader (GetApplicationContext (), cardFlightDeviceHandler);//, cardFlightAutoConfigHandler);

			// Create the listener that listens to when the PaymentView has been filled out manually
			onCardKeyedListener = new OnCardKeyedListener ();
			onCardKeyedListener.shuttleFragment = this;

			// Create the listener that listens to when the PaymentView has been cleared and reset.
			// NOTE: This is not necessary and should be used to simply clear out any variables set.
			onFieldResetListener = new OnFieldResetListener ();
			onFieldResetListener.shuttleFragment = this;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			View rootView = inflater.Inflate (Resource.Layout.shuttle_fragment, container, false);

			mFieldHolder = (PaymentView)rootView.FindViewById (Resource.Id.cardEditText);
			// Set the CardKeyedListener and FieldResetListener here
			mFieldHolder.SetOnCardKeyedListener (onCardKeyedListener);
			mFieldHolder.SetOnFieldResetListener (onFieldResetListener);

			swipeCardButton = (Button)rootView.FindViewById (Resource.Id.swipeCardButton);
			processPaymentButton = (Button)rootView.FindViewById (Resource.Id.processPaymentButton);
			displaySerialButton = (Button)rootView.FindViewById (Resource.Id.serialNumber);
			tokenizeCardButton = (Button)rootView.FindViewById (Resource.Id.tokenizeCard);
			resetFieldsButton = (Button)rootView.FindViewById (Resource.Id.resetFieldsButton);
			authorizeCardButton = (Button)rootView.FindViewById (Resource.Id.authorizeCard);
			captureChargeButton = (Button)rootView.FindViewById (Resource.Id.processCapture);
			autoConfigButton = (Button)rootView.FindViewById (Resource.Id.autoConfigButton);
			zipCodeButton = (Button)rootView.FindViewById (Resource.Id.fetchZipCodeButton);
			voidButton = (Button)rootView.FindViewById (Resource.Id.voidCard);
			refundButton = (Button)rootView.FindViewById (Resource.Id.refundCard);
			readerStatus = (TextView)rootView.FindViewById (Resource.Id.reader_status);

			cardNumber = (TextView)rootView.FindViewById (Resource.Id.card_number);
			cardType = (TextView)rootView.FindViewById (Resource.Id.card_type);
			cardLastFour = (TextView)rootView.FindViewById (Resource.Id.card_last_four);
			chargeToken = (TextView)rootView.FindViewById (Resource.Id.charge_token);
			chargeAmount = (TextView)rootView.FindViewById (Resource.Id.charge_amount);
			chargeCaptured = (TextView)rootView.FindViewById (Resource.Id.charge_captured);
			chargeVoided = (TextView)rootView.FindViewById (Resource.Id.charge_voided);
			chargeRefunded = (TextView)rootView.FindViewById (Resource.Id.charge_refund);
			zipCode = (TextView)rootView.FindViewById (Resource.Id.zip_code_field);

			zipCodeEnabled = (CheckBox)rootView.FindViewById (Resource.Id.zip_code_switch);
			CheckedChangeListener onCheckedChanged = new CheckedChangeListener (Activity);
			onCheckedChanged.shuttleFragment = this;
			zipCodeEnabled.SetOnCheckedChangeListener (onCheckedChanged);

			//zipCodeEnabled.SetOnCheckedChangeListener ( CompoundButton.IOnCheckedChangeListener());
			EnableZipCode (true);

			OnClickListener buttonClickListener = new OnClickListener ();
			buttonClickListener.shuttleFragment = this;
			buttonClickListener.Manager = this.FragmentManager;

			swipeCardButton.SetOnClickListener (this);
			processPaymentButton.SetOnClickListener (buttonClickListener);
			displaySerialButton.SetOnClickListener (buttonClickListener);
			tokenizeCardButton.SetOnClickListener (buttonClickListener);
			resetFieldsButton.SetOnClickListener (buttonClickListener);
			captureChargeButton.SetOnClickListener (buttonClickListener);
			authorizeCardButton.SetOnClickListener (buttonClickListener);
			autoConfigButton.SetOnClickListener (buttonClickListener);
			zipCodeButton.SetOnClickListener (buttonClickListener);
			voidButton.SetOnClickListener (buttonClickListener);
			refundButton.SetOnClickListener (buttonClickListener);

			if (readerIsConnected) {
				ReaderConnected ();
			} else {
				ReaderDisconnected ();
			}

			return rootView;
		}

		public void OnClick(View v)
		{
			LaunchSwipeEvent ();
		}

		public Context GetApplicationContext ()
		{
			return mContext.ApplicationContext;
		}

		private void ReaderConnected ()
		{
			readerIsConnected = true;
			readerStatus.SetText ("Reader connected", TextView.BufferType.Normal);
			swipeCardButton.Enabled = true;
			displaySerialButton.Enabled = true;
			autoConfigButton.Enabled = false;
		}

		private void ReaderDisconnected ()
		{
			readerIsConnected = false;
			readerStatus.SetText ("Reader not connected", TextView.BufferType.Normal);
			swipeCardButton.Enabled = false;
			displaySerialButton.Enabled = false;
			autoConfigButton.Enabled = false;
			FieldsReset ();
		}

		private void FieldsReset ()
		{
			mCard = null;
			cardNumber.SetText ("----", TextView.BufferType.Normal);
			cardLastFour.SetText ("----", TextView.BufferType.Normal);
			cardType.SetText ("----", TextView.BufferType.Normal);

			processPaymentButton.Enabled = false;
			tokenizeCardButton.Enabled = false;
			authorizeCardButton.Enabled = false;
			ChargeCleared ();
		}

		private void ChargeUpdated ()
		{
			chargeCaptured.SetText (mCharge.IsCaputred.ToString (), TextView.BufferType.Normal);
			chargeVoided.SetText (mCharge.IsVoided.ToString (), TextView.BufferType.Normal);
			chargeRefunded.SetText (String.Format ("%s | $%s", mCharge.IsRefunded, mCharge.IsRefunded ? mCharge.AmountRefunded.ToString () : "-.--"), TextView.BufferType.Normal);

			if (mCharge.IsCaputred && !mCharge.IsVoided && !mCharge.IsRefunded) {
				processPaymentButton.Enabled = false;
				captureChargeButton.Enabled = false;
				authorizeCardButton.Enabled = false;
				voidButton.Enabled = true;
				refundButton.Enabled = true;
			} else if (mCharge.IsRefunded || mCharge.IsVoided) {
				processPaymentButton.Enabled = false;
				captureChargeButton.Enabled = false;
				authorizeCardButton.Enabled = false;
				voidButton.Enabled = false;
				refundButton.Enabled = false;
			} else {
				voidButton.Enabled = false;
				refundButton.Enabled = false;
				processPaymentButton.Enabled = true;
				captureChargeButton.Enabled = true;
				authorizeCardButton.Enabled = true;
			}
		}

		private void ChargeCleared ()
		{
			captureChargeButton.Enabled = false;
			voidButton.Enabled = false;
			refundButton.Enabled = false;

			chargeToken.SetText ("---", TextView.BufferType.Normal);
			chargeAmount.SetText ("$-.--", TextView.BufferType.Normal);

			chargeCaptured.SetText ("---", TextView.BufferType.Normal);
			chargeVoided.SetText ("---", TextView.BufferType.Normal);
			chargeRefunded.SetText ("---", TextView.BufferType.Normal);
		}

		private void FillFieldsWithData (Card cardData)
		{
			mCard = cardData;
			SetCardPresent ();
		}

		private void SetCardPresent ()
		{
			cardNumber.SetText (mCard.CardNumber, TextView.BufferType.Normal);
			cardLastFour.SetText (mCard.Last4, TextView.BufferType.Normal);
			cardType.SetText (mCard.Type, TextView.BufferType.Normal);
			zipCode.SetText (mCard.ZipCode, TextView.BufferType.Normal);

			processPaymentButton.Enabled = true;
			tokenizeCardButton.Enabled = true;
			authorizeCardButton.Enabled = true;
		}

		private void EnableAutoconfigButton ()
		{
			autoConfigButton.Enabled = true;
		}

		public void EnableZipCode (bool enable)
		{
			mFieldHolder.EnableZipCode (enable);
			zipCodeEnabled.Checked = enable;
			if (enable) {
				zipCodeButton.Visibility = ViewStates.Visible;
			} else {
				zipCodeButton.Visibility = ViewStates.Gone;
			}
		}

		public void LaunchSwipeEvent ()
		{
			reader.BeginSwipe ();
			mFieldHolder.ResetFields ();
		}

		public void AutoConfigProgressUpdate (int i)
		{
			Log.Warn (TAG, "AutoConfig progress %" + i);
			readerStatus.SetText ("AutoConfig Progress %" + i, TextView.BufferType.Normal);
		}

		public void AutoConfigFinished ()
		{
			Log.Warn (TAG, "AutoConfig finished");
		}

		public void AutoConfigFailed ()
		{
			Log.Warn (TAG, "AutoConfig failed");
			readerStatus.SetText ("AutoConfig failed -- device is not supported", TextView.BufferType.Normal);
		}

		public void ReaderIsConnecting ()
		{
			Toast.MakeText (GetApplicationContext (), "Device connecting", ToastLength.Short).Show ();
		}

		public void ReaderIsAttached ()
		{
			readerFailed = false;
			Toast.MakeText (GetApplicationContext (), "Device connected", ToastLength.Short).Show ();
			ReaderConnected ();
		}

		public void ReaderIsDisconnected ()
		{
			// TODO Auto-generated method stub
			Toast.MakeText (GetApplicationContext (), "Device disconnected", ToastLength.Short).Show ();
			ReaderDisconnected ();
		}

		public void DeviceBeginSwipe ()
		{
			// TODO Auto-generated method stub
			Toast.MakeText (GetApplicationContext (), "Device begin swipe", ToastLength.Short).Show ();
		}

		public void ReaderCardResponse (Card card)
		{
			// TODO Auto-generated method stub
			Toast.MakeText (GetApplicationContext (), "Device swipe completed", ToastLength.Short).Show ();
			mCard = card;
			FillFieldsWithData (card);
		}

		public void DeviceSwipeFailed ()
		{
			readerFailed = true;
			Toast.MakeText (GetApplicationContext (), "Device swipe failed", ToastLength.Short).Show ();
		}

		public void DeviceSwipeTimeout ()
		{
			readerFailed = true;
			Toast.MakeText (GetApplicationContext (), "Device swipe time out", ToastLength.Short).Show ();
		}

		public void DeviceNotSupported ()
		{
			readerFailed = true;
			Toast.MakeText (GetApplicationContext (), "Device not supported", ToastLength.Short).Show ();
			EnableAutoconfigButton ();
		}

		public void ReaderTimeout ()
		{
			readerFailed = true;
			Toast.MakeText (GetApplicationContext (), "Reader has timed out", ToastLength.Short).Show ();
			EnableAutoconfigButton ();
		}

		public void OnCardKeyed (Card card)
		{
			mCard = card;
			FillFieldsWithData (mCard);
		}

		public void OnFieldReset ()
		{
			FieldsReset ();

			// TODO
			// Example of how to listen for swipe after reset:
			// 2 flags need to be maintained to follow the state of the reader
			//                if (readerIsConnected && !readerFailed)
			//      
		}

		public void DisplaySerialNumber ()
		{
			String s = Reader.SerialNumber;
			Toast.MakeText (GetApplicationContext (), s, ToastLength.Short).Show ();
		}

		public void TokenizeCardMethod ()
		{
			ShowToast ("Tokenizing card...");
			if (mCard != null) {
				CardFlightTokenizationHandler cardFlightTokenizationHandler = new  CardFlightTokenizationHandler ();
				cardFlightTokenizationHandler.shuttleFragment = this;
				mCard.Tokenize (cardFlightTokenizationHandler, GetApplicationContext ());
			} else {
				ShowToast ("Unable to tokenize- no card present");
			}
		}

		private void ShowToast (String text)
		{
			Toast t = Toast.MakeText (GetApplicationContext (), text, ToastLength.Long);
			t.SetGravity (GravityFlags.Center, 0, 0);
			t.Show ();
		}

		public void TokenizationFailed (string p0)
		{
			Log.Warn (TAG, "tokenizationSuccessful");
			ShowToast (p0);
		}

		public void TokenizationSuccessful (string p0)
		{
			Log.Warn (TAG, "tokenizationFailed");
			ShowToast (p0);
		}

		public void ResetFieldHolder ()
		{
			mFieldHolder.ResetFields ();
		}

		public void CaptureCharge ()
		{
			ShowToast ("Capturing charge...");
			if (mCharge != null) {
				CardFlightCaptureHandler cardFlightCaptureHandler = new CardFlightCaptureHandler ();
				cardFlightCaptureHandler.shuttleFragment = this;
				Charge.ProcessCapture (mCharge.Token, mCharge.Amount.DoubleValue (), cardFlightCaptureHandler);
			} else {
				ShowToast ("Unable to capture charge");
			}
		}

		public void CaptureFailed (string error)
		{
			ShowToast (error);
		}

		public void CaptureSuccessful (Charge charge)
		{
			ShowToast (String.Format ("Capture of $%s successful", charge.Amount));
			mCharge = charge;
			ChargeUpdated ();
		}

		public void StartAutoConfigProcess ()
		{
			reader.StartAutoConfigProcess ();
		}

		public void voidCharge ()
		{
			ShowToast ("Voiding charge...");
			if (mCharge != null) {
				CardFlightPaymentHandler cardFlightPaymentHandler = new CardFlightPaymentHandler ();
				cardFlightPaymentHandler.shuttleFragment = this;
				Charge.ProcessVoid (mCharge.Token, cardFlightPaymentHandler);
			} else {
				ShowToast ("Unable to void charge");
			}
		}

		public void TransactionFailed (string error)
		{
			ShowToast (error);
		}

		public void TransactionSuccessful (Charge charge)
		{
			ShowToast ("Charge voided");
			mCharge = charge;
			ChargeUpdated ();
		}

		public void FetchZipCodeButton ()
		{
			if (mCard != null) {
				ShowToast (String.Format ("Zip Code: %s", mCard.ZipCode));
			} else {
				ShowToast ("No card is present");
			}
		}
	}
}