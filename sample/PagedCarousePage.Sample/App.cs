using System;
using Xamarin.Forms;
using CaveBirdLabs.Forms;

namespace PagedCarouselPage.Sample
{
	public class App
	{
		public static Page GetMainPage()
		{
			var page = new CxPagedCarouselPage () {
				Children = {
					new ContentPage { Content = new BoxView { Color = new Color (1, 0, 0) }, Title = "Page 1" },
					new ContentPage { Content = new BoxView { Color = new Color (0, 1, 0) }, Title = "Page 2" },
				}};

			return page;
		}
	}
}

