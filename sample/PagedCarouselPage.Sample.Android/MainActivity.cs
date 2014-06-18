using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using CaveBirdLabs.Forms.Platform.Android;

namespace PagedCarouselPage.Sample.Android
{
	[Activity (Label = "PagedCarouselPage.Sample.Android", MainLauncher = true)]
	public class MainActivity : AndroidActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate(bundle);

			Xamarin.Forms.Forms.Init(this, bundle);
			Renderers.Init();

			SetPage(App.GetMainPage());
		}
	}
}


