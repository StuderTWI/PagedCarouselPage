#region Usings

using System;
using System.ComponentModel;
using System.Drawing;
using CaveBirdLabs.Forms;
using CaveBirdLabs.Forms.Platform.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Support.V4.View;

#endregion

[assembly: ExportRenderer (typeof(CxPagedCarouselPage), typeof(CxPagedCarouselPageRenderer))]

namespace CaveBirdLabs.Forms.Platform.Android
{
	public class CxPagedCarouselPageRenderer : CarouselPageRenderer
	{
		#region Declarations

		private bool _currentPageSetByUser = false;
		private CxPagedCarouselPage _pagedCarouselPage;


		private ViewPager _viewPager;
		CirclePageIndicator _circlePageIndicator;

		#endregion

		#region Constructors

		public CxPagedCarouselPageRenderer ()
		{
		}

		#endregion

		#region Event Handlers

		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			switch (e.PropertyName) {
			case "IsPagerVisible":
				//_uiPageControl.Hidden = !_pagedCarouselPage.IsPagerVisible;
				break;
			case "PagerItemColor":
				SetPageIndicatorTintColor ();
				break;
			case "SelectedPagerItemColor":
				SetCurrentPageIndicatorTintColor ();
				break;
			case "PagerPadding":
			case "PagerXAlign":
			case "PagerYAlign":
				LayoutPageControl ();
				break;
			case "CurrentPage":
				//if (!_currentPageSetByUser)
				//_uiPageControl.CurrentPage = SelectedIndex;
				break;
			}

		}

		protected override void OnLayout (bool changed, int l, int t, int r, int b)
		{
			base.OnLayout (changed, l, t, r, b);
			LayoutPageControl ();
		}

		private void OnPagedCarouselPagePropertyChanged (object sender, PropertyChangedEventArgs e)
		{

		}

		private void OnUIPageControlValueChanged (object sender, EventArgs eventArgs)
		{
			_currentPageSetByUser = true;
			//_pagedCarouselPage.CurrentPage = _pagedCarouselPage.Children[_uiPageControl.CurrentPage];
			_currentPageSetByUser = false;
		}

		#endregion

		#region Public Methods

		//		public override void ViewDidLayoutSubviews()
		//		{
		//			base.ViewDidLayoutSubviews();
		//			_uiPageControl.Pages = _pagedCarouselPage.Children.Count;
		//			_pagedCarouselPage.PagerMinimumWidth = _uiPageControl.SizeForNumberOfPages(_uiPageControl.Pages).Width;
		//			LayoutPageControl();
		//		}

		#endregion

		#region Private Methods

		private void LayoutPageControl ()
		{
			var density = Resources.DisplayMetrics.Density;

			float width = this.ViewGroup.MeasuredWidth - (float)_pagedCarouselPage.PagerPadding.Left - (float)_pagedCarouselPage.PagerPadding.Right;
			
			float height = 30 * density; // default height of the UIPageControl

			float x = 0;
			switch (_pagedCarouselPage.PagerXAlign) {
			case TextAlignment.Center:
				if (this.ViewGroup.MeasuredWidth != width)
					x = (float)_pagedCarouselPage.PagerPadding.Left + (width / 2);

				break;
			case TextAlignment.End:
				x = this.ViewGroup.MeasuredWidth - width - (float)_pagedCarouselPage.PagerPadding.Right;
				break;
			case TextAlignment.Start:
				x = (float)_pagedCarouselPage.PagerPadding.Left;
				break;
			}

			float y = 0;
			switch (_pagedCarouselPage.PagerYAlign) {
			case TextAlignment.Center:
					// ignore top and bottom padding
				y = (this.ViewGroup.MeasuredHeight - height) / 2;
				_circlePageIndicator.Centered = true;
				break;
			case TextAlignment.End:
				y = this.ViewGroup.MeasuredHeight - (float)_pagedCarouselPage.PagerPadding.Bottom - height;
				_circlePageIndicator.Centered = false;
				break;
			case TextAlignment.Start:
				y = (float)_pagedCarouselPage.PagerPadding.Top;
				_circlePageIndicator.Centered = false;
				break;
			}

			_circlePageIndicator.Layout ((int)x, (int)y, (int)(width + x), (int)(height + y));


		}

		private void SetCurrentPageIndicatorTintColor ()
		{
			//_uiPageControl.CurrentPageIndicatorTintColor = _pagedCarouselPage.SelectedPagerItemColor != Color.Default ? _pagedCarouselPage.SelectedPagerItemColor.ToUIColor() : UIColor.White;
		}

		private void SetPageIndicatorTintColor ()
		{
			//_uiPageControl.PageIndicatorTintColor = _pagedCarouselPage.PagerItemColor != Color.Default ? _pagedCarouselPage.PagerItemColor.ToUIColor() : UIColor.Gray;
		}

		#endregion

		#region Protected Methods

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (disposing) {
				_pagedCarouselPage.PropertyChanged -= OnPagedCarouselPagePropertyChanged;
				//_uiPageControl.ValueChanged -= OnUIPageControlValueChanged;
			}
		}

		protected override void OnElementChanged (ElementChangedEventArgs<CarouselPage> e)
		{
			base.OnElementChanged (e);

			_pagedCarouselPage = (CxPagedCarouselPage)this.Element;

			_viewPager = null;

			for (int i = 0; i < this.ViewGroup.ChildCount; i++) {
				_viewPager = this.ViewGroup.GetChildAt (i) as ViewPager;
				if (_viewPager != null)
					break;
			}
			if (_viewPager == null)
				return;

			var density = Resources.DisplayMetrics.Density;

			_circlePageIndicator = new CirclePageIndicator (base.Context);
			_circlePageIndicator.SetPadding (5,5,5,5);
			_circlePageIndicator.Radius = 5 * density;
			AddView (_circlePageIndicator);
			_circlePageIndicator.BringToFront ();


		}

		protected override void OnAttachedToWindow ()
		{
			base.OnAttachedToWindow ();

			_circlePageIndicator.SetViewPager (_viewPager);


		}

		//		protected override void xxOnElementChanged(VisualElementChangedEventArgs e)
		//		{
		//			base.OnElementChanged(e);
		//
		//			_pagedCarouselPage = (CxPagedCarouselPage)e.NewElement;
		//			//_view = NativeView;
		//
		//			//_uiPageControl = new UIPageControl();
		//			SetPageIndicatorTintColor();
		//			SetCurrentPageIndicatorTintColor();
		//
		//			//_view.Add(_uiPageControl);
		//
		//			_pagedCarouselPage.PropertyChanged += OnPagedCarouselPagePropertyChanged;
		//			//_uiPageControl.ValueChanged += OnUIPageControlValueChanged;
		//		}

		#endregion

	}
}