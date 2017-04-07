
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(demo.Droid.AppVersion))]
namespace demo.Droid
{
	public class AppVersion : IAppVersion
	{
		public string Version
		{
			get
			{
				return Forms.Context.PackageManager.GetPackageInfo(Forms.Context.PackageName, 0).VersionName;
			}
		}
	}
}
