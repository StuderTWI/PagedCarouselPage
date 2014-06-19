#region Usings

using CaveBirdLabs.Forms.Platform.WindowsPhone;

using Microsoft.Phone.Controls;

using Xamarin.Forms;

#endregion

namespace PagedCarousePage.Sample.WindowsPhone
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor

		#region Constructors

		public MainPage()
		{
			InitializeComponent();

			Forms.Init();
			Renderers.Init();

			Content = PagedCarouselPage.Sample.App.GetMainPage().ConvertPageToUIElement(this);
		}

		#endregion
	}
}