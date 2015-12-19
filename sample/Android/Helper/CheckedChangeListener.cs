using System;
using Android.Widget;
using Android.App;

namespace CardFlight.Sample
{
	public class CheckedChangeListener : Java.Lang.Object, CompoundButton.IOnCheckedChangeListener
	{
		private Activity activity;

		public ShuttleFragment shuttleFragment {
			get;
			set;
		}

		public CheckedChangeListener(Activity activity)
		{
			this.activity = activity;
		}

		public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
		{
			shuttleFragment.EnableZipCode (isChecked);
		}
	}
}

