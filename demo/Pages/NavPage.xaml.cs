using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace demo
{
	public partial class NavPage : ContentPage
	{
		public NavPage()
		{
			InitializeComponent();

			BindingContext = new NavViewModel();
		}
	}
}
