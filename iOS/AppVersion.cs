using System;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(demo.iOS.AppVersion))]
namespace demo.iOS
{
	public class AppVersion : IAppVersion
	{
		public string Version
		{
			get
			{
				return NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
			}
		}
	}
}
