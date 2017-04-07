using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;

namespace demo
{
	public partial class ColumnPage : PopupPage
	{
		public ColumnPage()
		{
			InitializeComponent();
		}

		async void OnClose(object sender, EventArgs e)
		{
			await Navigation.PopPopupAsync();
		}
	}
}
