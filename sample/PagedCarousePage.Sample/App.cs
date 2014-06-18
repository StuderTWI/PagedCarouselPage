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
				},
				PagerYAlign = TextAlignment.End,
				PagerXAlign = TextAlignment.Start,
				PagerPadding = new Thickness(50, 0, 120, 0)

			};

			return page;
		}

		#endregion
	}
}