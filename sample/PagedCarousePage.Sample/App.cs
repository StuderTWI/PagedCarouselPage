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
					new IntroPage("intro1background.png", "Welcome", "Djubble is the easiest and fastest way to get your friends together"),
					new IntroPage("intro2background.png", "Create your activity", ""),
					new IntroPage("intro3background.png", "Invite your friends", "Doing things together is much more fun than alone"),
					new IntroPage("intro4background.png", "Swipe to accept", "Your friends just have to swipe to accept or decline your invitation. The answers pop up in your djubble app and fun can start."),
					new IntroPage("intro5background.png", "Start to djubble", "")
				},
				PagerPadding = new Thickness(0, 0, 0, 0),
				SelectedPagerItemColor = Color.FromRgb(41, 171, 226),
				PagerItemColor = Color.FromRgb(153, 153, 153)
			};

			return page;
		}

		#endregion
	}
}