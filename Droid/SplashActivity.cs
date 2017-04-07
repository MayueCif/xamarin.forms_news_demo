
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace demo.Droid
{
	[Activity(MainLauncher = true, NoHistory = true, Theme = "@style/SplashTheme")]
	public class SplashActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			StartActivity(typeof(MainActivity));
		}
	}
}
