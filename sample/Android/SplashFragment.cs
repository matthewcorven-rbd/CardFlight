using System;
using Android.App;
using Android.Widget;
using Android.Views;
using Android.Content.PM;
using Android.OS;

namespace CardFlight.Sample
{
	public class SplashFragment : Fragment
	{
		private TextView sdkVersionText;
		private TextView androidOsText;

		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			RetainInstance = true;
		}

		public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			View rootView = inflater.Inflate (Resource.Layout.splash_fragmant, container, false);

			sdkVersionText = (TextView)rootView.FindViewById (Resource.Id.sdk_version_text);
			androidOsText = (TextView)rootView.FindViewById (Resource.Id.android_version_text);

			SetSplashContent ();

			return rootView;
		}

		private void SetSplashContent ()
		{
			string sdkVersion;
			string androidVersion;

			try {
				PackageInfo pInfo = Activity.PackageManager.GetPackageInfo (Activity.PackageName, 0);
				sdkVersion = "SDK " + pInfo.VersionName;
			} catch (PackageManager.NameNotFoundException e) {
				e.PrintStackTrace ();
				sdkVersion = "UNKNOWN";
			}
			androidVersion = "Android " + Build.VERSION.Release;

			sdkVersionText.Text = sdkVersion;
			androidOsText.Text = androidVersion;
		}
	}
}

