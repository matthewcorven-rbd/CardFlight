using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.Widget;

namespace CardFlight.Sample
{
	[Activity (Label = "CardFlight.Sample", MainLauncher = true, Icon = "@drawable/ic_launcher")]
	public class MainActivity : Activity
	{
		private ActionBarDrawerToggleHelper mDrawerToggle;
		private System.String[] mDrawerOptions;
		private DrawerLayout mDrawerLayout;
		private ListView mDrawerList;
		private Java.Lang.ICharSequence mTitle;

		private SplashFragment splashFragment;
		private ShuttleFragment shuttleFragment;
		private Android.App.Fragment fragment;
		private int drawerPosition = 0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.main_activity);

			mDrawerOptions = new System.String[]{ "Home", "Shuttle Reader" };
			mDrawerLayout = (DrawerLayout)FindViewById (Resource.Id.drawer_layout).JavaCast<DrawerLayout> ();
			mDrawerList = (ListView)FindViewById (Resource.Id.left_drawer);

			// Set the adapter for the list view
			mDrawerList.Adapter = new ArrayAdapter<System.String> (this, Resource.Layout.drawer_list_item, Resource.Id.drawer_list_text, mDrawerOptions);
			// Set the list's click listener

			mDrawerList.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) => {
				SelectItem (e.Position);
			};

			mDrawerToggle = new ActionBarDrawerToggleHelper (this, mDrawerLayout, Resource.Drawable.ic_drawer, Resource.String.drawer_open, Resource.String.drawer_close);
			mDrawerToggle._MainActivity = this;

			// Set the drawer toggle as the DrawerListener
			mDrawerLayout.SetDrawerListener (mDrawerToggle);

			Activity activity = this;

			activity.ActionBar.SetDisplayHomeAsUpEnabled (true);
			activity.ActionBar.SetHomeButtonEnabled (true);
		}

		public void OnDrawerClosed (View view)
		{
			this.ActionBar.Title = mTitle.ToString ();
			InvalidateOptionsMenu (); // creates call to onPrepareOptionsMenu()
		}

		public void OnDrawerOpened (View drawerView)
		{
			this.ActionBar.Title = "Select a Reader option";
			InvalidateOptionsMenu (); // creates call to onPrepareOptionsMenu()
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			SelectItem (drawerPosition);
		}

		protected override void OnSaveInstanceState (Bundle outState)
		{
			base.OnSaveInstanceState (outState);
			outState.PutInt ("position", drawerPosition);
		}

		protected override void OnRestoreInstanceState (Bundle savedInstanceState)
		{
			base.OnRestoreInstanceState (savedInstanceState);
			drawerPosition = savedInstanceState.GetInt ("position");
			SelectItem (drawerPosition);
		}

		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			// Sync the toggle state after onRestoreInstanceState has occurred.
			mDrawerToggle.SyncState ();
		}

		public override void OnConfigurationChanged (Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);
			mDrawerToggle.OnConfigurationChanged (newConfig);
		}

		public override bool OnPrepareOptionsMenu (IMenu menu)
		{
			// If the nav drawer is open, hide action items related to the content view
			bool drawerOpen = mDrawerLayout.IsDrawerOpen (mDrawerList);

			return base.OnPrepareOptionsMenu (menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			// Pass the event to ActionBarDrawerToggle, if it returns
			// true, then it has handled the app icon touch event
			if (mDrawerToggle.OnOptionsItemSelected (item)) {
				return true;
			}

			return base.OnOptionsItemSelected (item);
		}

		/** Swaps fragments in the main content view */
		private void SelectItem (int position)
		{
			bool commitChange = position != drawerPosition;

			switch (position) {
			case 0:
				if (splashFragment == null)
					splashFragment = new CardFlight.Sample.SplashFragment ();
				fragment = splashFragment;
				drawerPosition = 0;
				commitChange = true;
				break;

			case 1:
				if (shuttleFragment == null)
					shuttleFragment = new CardFlight.Sample.ShuttleFragment ();
				fragment = shuttleFragment;
				drawerPosition = 1;
				break;

			default:
				if (splashFragment == null)
					splashFragment = new CardFlight.Sample.SplashFragment ();
				fragment = splashFragment;
				drawerPosition = 0;
				break;
			}

			if (commitChange) {
				// Insert the fragment by replacing any existing fragment
				Activity activity = this;
				Android.App.FragmentManager fragmentManager = activity.FragmentManager;
				fragmentManager.BeginTransaction ()
					.Replace (Resource.Id.content_frame, fragment)
					.Commit ();
			}

			// Highlight the selected item, update the title, and close the drawer
			mDrawerList.SetItemChecked (position, true);
			SetTitle (position);
			mDrawerLayout.CloseDrawer (mDrawerList);
		}

		public override void SetTitle (int titleId)
		{
			mTitle = CharSequence.ArrayFromStringArray (mDrawerOptions) [titleId];
			Activity activity = this;
			activity.ActionBar.Title = mTitle.ToString ();
		}
	}
}


