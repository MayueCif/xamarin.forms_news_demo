using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace demo
{
	public partial class App : Application
	{
		readonly string APP_VERSION = "AppVersion";

		public App()
		{
			InitializeComponent();

			//应用版本相关
			//https://github.com/colbylwilliams/VersionTrackingPlugin
			var appVersion = DependencyService.Get<IAppVersion>();
			if (Properties.ContainsKey(APP_VERSION) && Properties[APP_VERSION].Equals(appVersion.Version))
			{
				MainPage = new NavigationPage(new MainTabbedPage())
				{
					BarBackgroundColor = Color.Red,
					BarTextColor = Color.White
				};
				//MainPage = new MainTabbedPage();
			}
			else
			{
				MainPage = new NavPage();
				Properties[APP_VERSION] = appVersion.Version;
			}

			//国际化
			if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
			{
				var localize = DependencyService.Get<ILocalize>();
				var ci = localize.GetCurrentCultureInfo();
				//Resource.Resources.Culture = ci;// set the RESX for resource localization
				localize.SetLocale(ci); // set the Thread for locale-aware methods
			}

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
