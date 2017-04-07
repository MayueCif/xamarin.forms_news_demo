using CarouselView.FormsPlugin.iOS;
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using SegmentedControl.FormsPlugin.iOS;
using UIKit;

namespace demo.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			CarouselViewRenderer.Init();
			SegmentedControlRenderer.Init();
			ImageCircleRenderer.Init();

			LoadApplication(new App());

			//UIViewControllerBasedStatusBarAppearance set false 设置系统栏内容颜色
			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);

			//修改TabBar选中颜色
			//http://motzcod.es/post/138225183932/tintcolor-selectedimage-xamarin-forms-ios
			UITabBar.Appearance.SelectedImageTintColor = UIColor.Red;

			return base.FinishedLaunching(app, options);
		}
	}
}
