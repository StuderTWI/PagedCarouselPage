using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using CaveBirdLabs.Forms.Platform.iOS;

namespace PagedCarouselPage.Sample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init();

			// HACK: this is needed for the Renderers in the library to load (remove this and the renderer is not loaded)
			CaveBirdLabs.Forms.Platform.iOS.Renderers.Init ();

			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			window.RootViewController =  App.GetMainPage().CreateViewController();
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}