using System;
namespace demo
{
	public class NewsListItemModel
	{
		//本项目为Demo项目，注重界面布局，忽略 INotifyPropertyChanged 接口实现
		public string Image
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string Column
		{
			get;
			set;
		}
	}
}
