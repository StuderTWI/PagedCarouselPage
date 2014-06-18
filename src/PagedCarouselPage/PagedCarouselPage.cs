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

	}
}

