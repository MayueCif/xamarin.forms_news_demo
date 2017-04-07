using System;
using System.Collections.Generic;

namespace demo
{
	public class HomeViewModel
	{
		public HomeViewModel()
		{
			CarouselViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/4d6bdb8778ef4f4284d66f74df0d9b5520170404121443.jpeg_320x200x1x85.jpg",
				Title = "如果现在你是穷人，十年后你可能还会一贫如洗"
			});
			CarouselViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/6f7521996d894108a9319bc6b9aed93720170403123502.jpeg_320x200x1x85.jpg",
				Title = "毁掉孩子未来的，可能就是父母的这句话"
			});
			CarouselViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/a474fbfb13944245be6cbd64d22b9f1b20170404131846.jpeg_320x200x1x85.jpg",
				Title = "清明：有些词，只是叫一叫就让人喉间哽咽"
			});

			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
			ListViewSource.Add(new NewsListItemModel()
			{
				Image = "http://imgsize.ph.126.net/?imgurl=http://cms-bucket.nosdn.127.net/f290a0c0074e4275b7f50a158841f41920170404220135.png_140x88x1x85.jpg",
				Title = "朴槿惠狱中首讯:涉13项指控均否认 19日收押到期",
				Column = "新闻"
			});
		}

		public List<NewsListItemModel> CarouselViewSource
		{
			get;
			set;
		} = new List<NewsListItemModel>();

		public List<NewsListItemModel> ListViewSource
		{
			get;
			set;
		} = new List<NewsListItemModel>();
	}
}
