using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace demo
{
	public partial class UTItemView : ContentView
	{
		public UTItemView()
		{
			InitializeComponent();
		}

		public static readonly BindableProperty TitleProperty = BindableProperty.Create(
			propertyName: "Title",
			returnType: typeof(string),
			declaringType: typeof(UTItemView),
			defaultValue: default(string));

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

	}
}
