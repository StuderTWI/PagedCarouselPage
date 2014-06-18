using System;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using Xamarin.Forms;
using CaveBirdLabs.Forms;
using CaveBirdLabs.Forms.Platform.iOS;
using MonoTouch.UIKit;
using System.Drawing;


[assembly:ExportRendererAttribute (typeof(CxPagedCarouselPage), typeof(CxPagedCarouselPageRenderer))]

namespace CaveBirdLabs.Forms.Platform.iOS
{
	public class CxPagedCarouselPageRenderer : CarouselPageRenderer
	{
		UIPageControl _pageControl;
		UILabel _label;

		public CxPagedCarouselPageRenderer ()
		{
		}

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			var page = e.NewElement as CxPagedCarouselPage;
			var view = NativeView;

			//TODO: remove this label once Xamarin has checked the app for support
			_label = new UILabel (new RectangleF (20, 40, view.Frame.Width - 40, 40));
			_label.AdjustsFontSizeToFitWidth = true;
			_label.TextColor = UIColor.White;
			_label.Text = "My Rendered Is Used";
			view.Add (_label);



			page.PropertyChanged += OnPropertyChanged;

		}

		private void OnPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			switch (e.PropertyName) {
			case CxPagedCarouselPage.IsPagerVisibleProperty.PropertyName:
				break;
			case CxPagedCarouselPage.PagerItemColorProperty.PropertyName:
				break;
			case CxPagedCarouselPage.SelectedPagerItemColorProperty.PropertyName:
				break;	
			case CxPagedCarouselPage.PagerPaddingProperty.PropertyName:
				break;
			case CxPagedCarouselPage.PagerXAlignProperty.PropertyName:
				break;
			case CxPagedCarouselPage.PagerYAlignProperty.PropertyName:
				break;
			}
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

	}
}