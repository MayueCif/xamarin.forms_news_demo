using System;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace demo
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}

		async void OnTapped(object sender, EventArgs e)
		{
			await Navigation.PushPopupAsync(new ColumnPage());
		}
	}
}
