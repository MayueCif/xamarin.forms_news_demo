using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace demo
{
	public partial class MainTabbedPage : TabbedPage
	{
		public MainTabbedPage()
		{
			InitializeComponent();
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			if (CurrentPage is HomePage)
			{
				Title = Resource.Resources.home;
			}
			else if (CurrentPage is NewsPage)
			{
				Title = Resource.Resources.ResourceManager.GetString("news");
			}
			else if (CurrentPage is LivePage)
			{
				Title = Resource.Resources.live;
			}
			else if (CurrentPage is VideoPage)
			{
				Title = Resource.Resources.video;
			}
			else if (CurrentPage is UserPage)
			{
				Title = Resource.Resources.user;
				//NavigationPage.SetHasNavigationBar(this, false);
			}
		}
	}
}
