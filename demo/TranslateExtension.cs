using System;
using System.Globalization;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace demo
{
	[ContentProperty("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		readonly CultureInfo ci;
		//指定为项目中默认资源文件ID
		const string ResourceId = "demo.Resource.Resources";

		public TranslateExtension()
		{
			if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
			{
				ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
			}
		}

		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{

			if (Text == null)
				return "";

			ResourceManager resmgr = new ResourceManager(ResourceId, GetType().GetTypeInfo().Assembly);

			var translation = resmgr.GetString(Text, ci);

			if (translation == null)
			{
#if DEBUG
				throw new ArgumentException(
					String.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId, ci.Name), "Text");
#else
                translation = Text; // HACK: returns the key, which GETS DISPLAYED TO THE USER
#endif
			}
			return translation;
		}
	}
}
