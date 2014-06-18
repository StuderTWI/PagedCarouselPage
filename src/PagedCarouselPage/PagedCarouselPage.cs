using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CaveBirdLabs.Forms
{
	public class CxPagedCarouselPage : CarouselPage
	{

		public static readonly BindableProperty IsPagerVisibleProperty =
			BindableProperty.Create<CxPagedCarouselPage,bool> (
				p => p.IsPagerVisible, true);

		public bool IsPagerVisible {
			get { return (bool)GetValue (IsPagerVisibleProperty); }
			set { SetValue (IsPagerVisibleProperty, value); }
		}

		public static readonly BindableProperty PagerItemColorProperty =
			BindableProperty.Create<CxPagedCarouselPage,Color> (
				p => p.PagerItemColor, Color.Default);

		public Color PagerItemColor {
			get { return (Color)GetValue (PagerItemColorProperty); }
			set { SetValue (PagerItemColorProperty, value); }
		}

		public static readonly BindableProperty SelectedPagerItemColorProperty =
			BindableProperty.Create<CxPagedCarouselPage,Color> (
				p => p.SelectedPagerItemColor, Color.Default);

		public Color SelectedPagerItemColor {
			get { return (Color)GetValue (SelectedPagerItemColorProperty); }
			set { SetValue (SelectedPagerItemColorProperty, value); }
		}

		public static readonly BindableProperty PagerPaddingProperty =
			BindableProperty.Create<CxPagedCarouselPage,Thickness> (
				p => p.PagerPadding, new Thickness (0, 0, 0, 60));

		public Thickness PagerPadding {
			get { return (Thickness)base.GetValue (PagerPaddingProperty); }
			set { base.SetValue (PagerPaddingProperty, value); }
		}

		public static readonly BindableProperty PagerXAlignProperty =
			BindableProperty.Create<CxPagedCarouselPage,TextAlignment> (
				p => p.PagerXAlign, TextAlignment.Center);

		public TextAlignment PagerXAlign {
			get {
				return (TextAlignment)base.GetValue (PagerXAlignProperty);
			}
			set {
				base.SetValue (PagerXAlignProperty, value);
			}
		}

		public static readonly BindableProperty PagerYAlignProperty =
			BindableProperty.Create<CxPagedCarouselPage,TextAlignment> (
				p => p.PagerYAlign, TextAlignment.End);

		public TextAlignment PagerYAlign {
			get {
				return (TextAlignment)base.GetValue (PagerYAlignProperty);
			}
			set {
				base.SetValue (PagerYAlignProperty, value);
			}
		}

	}
}

