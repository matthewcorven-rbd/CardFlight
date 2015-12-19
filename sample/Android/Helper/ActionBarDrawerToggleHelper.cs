using System;
using Android.Support.V4.App;
using Android.App;
using Android.Support.V4.Widget;

namespace CardFlight.Sample
{
	public class ActionBarDrawerToggleHelper : ActionBarDrawerToggle
	{
		public MainActivity _MainActivity {
			get;
			set;
		}

		public ActionBarDrawerToggleHelper (Activity activity, DrawerLayout drawerLayout, int drawerImageRes, int openDrawerContentDescRes, int closeDrawerContentDescRes)
			: base (activity, drawerLayout, drawerImageRes, openDrawerContentDescRes, closeDrawerContentDescRes)
		{
		}		

		public override void OnDrawerClosed (Android.Views.View drawerView)
		{
			base.OnDrawerClosed (drawerView);
			_MainActivity.OnDrawerClosed (drawerView);
		}

		public override void OnDrawerOpened (Android.Views.View drawerView)
		{
			base.OnDrawerOpened (drawerView);
			_MainActivity.OnDrawerOpened (drawerView);
		}
	}
}

