using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ScrollView), typeof(demo.iOS.ScrollViewHideScrollbarRenderer))]
namespace demo.iOS
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
		private void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			this.ShowsHorizontalScrollIndicator = false;
			this.ShowsVerticalScrollIndicator = false;
		}
	}
}
