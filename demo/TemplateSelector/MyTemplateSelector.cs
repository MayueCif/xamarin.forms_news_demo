using System;
using Xamarin.Forms;

namespace demo
{
	public class MyTemplateSelector : DataTemplateSelector
	{
		private readonly DataTemplate templateOne;
		private readonly DataTemplate templateTwo;
		private readonly DataTemplate templateThree;

		public MyTemplateSelector()
		{
			this.templateOne = new DataTemplate(typeof(Nav1View));
			this.templateTwo = new DataTemplate(typeof(Nav2View));
			this.templateThree = new DataTemplate(typeof(Nav3View));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var index = (int)item;
			DataTemplate template;
			switch (index)
			{
				case 1:
					template = templateOne;
					break;
				case 2:
					template = templateTwo;
					break;
				case 3:
					template = templateThree;
					break;
				default:
					throw new Exception("error template item");
			}
			return template;
		}
	}
}
