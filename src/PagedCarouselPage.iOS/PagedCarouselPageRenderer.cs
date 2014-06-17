using System;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using Xamarin.Forms;
using CaveBirdLabs.Forms;
using CaveBirdLabs.Forms.Platform.iOS;

[assembly:ExportRendererAttribute(typeof(PagedCarouselPage), typeof(PagedCarouselPageRenderer))]

namespace CaveBirdLabs.Forms.Platform.iOS
{
	public class PagedCarouselPageRenderer : CarouselPageRenderer
	{
		public PagedCarouselPageRenderer ()
		{
		}

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			var page = e.NewElement as PagedCarouselPage;
			var view = NativeView;

//			label = new UILabel (new RectangleF (20, 40, view.Frame.Width - 40, 40));
//			label.AdjustsFontSizeToFitWidth = true;
//			label.TextColor = UIColor.White;
//			view.Add (label);

			page.PropertyChanged += OnPropertyChanged;

		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

	}
}

