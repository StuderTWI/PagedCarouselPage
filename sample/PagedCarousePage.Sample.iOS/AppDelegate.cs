#region Usings

using CaveBirdLabs.Forms.Platform.iOS;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

#endregion

namespace PagedCarouselPage.Sample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		#region Declarations

		private UIWindow _window;

		#endregion

		#region Public Methods

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Forms.Init();
			Renderers.Init();

			// create a new window instance based on the screen size
			_window = new UIWindow(UIScreen.MainScreen.Bounds);
			_window.RootViewController = App.GetMainPage().CreateViewController();
			_window.MakeKeyAndVisible();

			return true;
		}

		#endregion
	}
}