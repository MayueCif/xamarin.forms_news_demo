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
			//var homePage = new HomePage();
			//var newsPage = new NewsPage();
			//var livePage = new LivePage();
			//var videoPage = new VideoPage();
			//var userPage = new UserPage();
			//this.Children.Add(new NavigationPage(homePage)
			//{
			//	Title = homePage.Title,
			//	Icon = homePage.Icon,
			//	BarBackgroundColor = Color.Red,
			//	BarTextColor = Color.White
			//});
			//this.Children.Add(new NavigationPage(newsPage)
			//{
			//	Title = newsPage.Title,
			//	Icon = newsPage.Icon,
			//	BarBackgroundColor = Color.Red,
			//	BarTextColor = Color.White
			//});
			//this.Children.Add(new NavigationPage(livePage)
			//{
			//	Title = livePage.Title,
			//	Icon = livePage.Icon,
			//	BarBackgroundColor = Color.Red,
			//	BarTextColor = Color.White
			//});
			//this.Children.Add(new NavigationPage(videoPage)
			//{
			//	Title = videoPage.Title,
			//	Icon = videoPage.Icon,
			//	BarBackgroundColor = Color.Red,
			//	BarTextColor = Color.White
			//});
			//this.Children.Add(new NavigationPage(userPage)
			//{
			//	Title = userPage.Title,
			//	Icon = userPage.Icon,
			//	BarBackgroundColor = Color.Red,
			//	BarTextColor = Color.White
			//});
			//NavigationPage.SetHasNavigationBar(livePage, false);
			//NavigationPage.SetHasNavigationBar(userPage, false);
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			if (CurrentPage is HomePage)
			{
				Title = "首页";
			}
			else if (CurrentPage is NewsPage)
			{
				Title = "要闻";
			}
			else if (CurrentPage is LivePage)
			{
				Title = "直播";
			}
			else if (CurrentPage is VideoPage)
			{
				Title = "视频";
			}
			else if (CurrentPage is UserPage)
			{
				Title = "我";
				//NavigationPage.SetHasNavigationBar(this, false);
			}
		}
	}
}
