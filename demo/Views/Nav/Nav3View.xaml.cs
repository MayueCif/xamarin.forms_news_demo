using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace demo
{
	public partial class Nav3View : ContentView
	{
		void OnClicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new MainTabbedPage())
			{
				BarBackgroundColor = Color.Red,
				BarTextColor = Color.White
			});
			//Navigation.PushModalAsync(new MainTabbedPage());
		}

		public Nav3View()
		{
			InitializeComponent();
		}
	}
}
