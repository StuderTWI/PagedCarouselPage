#region Usings

using CaveBirdLabs.Forms;
using Xamarin.Forms;

#endregion

namespace PagedCarouselPage.Sample
{
	public class App
	{
		#region Public Methods

		public static Page GetMainPage()
		{
			var page = new CxPagedCarouselPage()
			{
				Children =
				{
					new ContentPage {Content = new BoxView {Color = new Color(1, 0, 0)}},
					new ContentPage {Content = new BoxView {Color = new Color(0, 1, 0)}},
					new ContentPage {Content = new BoxView {Color = new Color(0, 1, 1)}}
				},
				PagerYAlign = TextAlignment.End,
				PagerXAlign = TextAlignment.Center,
				PagerPadding = new Thickness(0, 0, 0,20)
			};

			return page;
		}

		#endregion
	}
}