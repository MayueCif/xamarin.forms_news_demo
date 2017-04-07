using System;
using System.Collections.Generic;
using PropertyChanged;
using Xamarin.Forms;

namespace demo
{
	//https://github.com/Fody/PropertyChanged
	[ImplementPropertyChanged]
	public class NavViewModel
	{
		public NavViewModel()
		{
			Position = 0;
			ItemsSource = new List<int>() { 1, 2, 3 };
			TemplateSelector = new MyTemplateSelector();
		}

		public int Position { get; set; }

		public List<int> ItemsSource { get; set; }

		public MyTemplateSelector TemplateSelector { get; set; }

	}
}

