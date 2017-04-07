
using Android.App;
using Android.Content.PM;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using ImageCircle.Forms.Plugin.Droid;
using SegmentedControl.FormsPlugin.Android;

namespace demo.Droid
{
	[Activity(Label = "demo.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			CarouselViewRenderer.Init();
			SegmentedControlRenderer.Init();
			ImageCircleRenderer.Init();

			LoadApplication(new App());
		}
	}
}
