using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ScrollView), typeof(demo.Droid.ScrollViewHideScrollbarRenderer))]
namespace demo.Droid
{
	public class ScrollViewHideScrollbarRenderer : ScrollViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || this.Element == null)
				return;

			if (e.OldElement != null)
				e.OldElement.PropertyChanged -= OnElementPropertyChanged;

			e.NewElement.PropertyChanged += OnElementPropertyChanged;

		}

		protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			GetChildAt(0).HorizontalScrollBarEnabled = false;
			GetChildAt(0).VerticalScrollBarEnabled = false;
		}
	}
}
