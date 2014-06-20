#region Usings

using Xamarin.Forms;

#endregion

namespace PagedCarouselPage.Sample
{
	public class IntroPage : ContentPage
	{
		#region Constructors

		public IntroPage(string imageName, string header, string detail)
		{
			var grid = new Grid()
			{
				ColumnDefinitions = new ColumnDefinitionCollection() { new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) } },
				RowDefinitions = new RowDefinitionCollection()
				{
					new RowDefinition() {Height = new GridLength(1, GridUnitType.Auto)},
					new RowDefinition() {Height = new GridLength(1, GridUnitType.Star)},
				},
				BackgroundColor = Color.White
			};

			var image = new Image()
			{
				Source = ImageSource.FromFile(Device.OnPlatform(iOS: imageName, Android: imageName, WinPhone: "Assets/" + imageName)),
				Aspect = Aspect.AspectFill
			};
			grid.Children.Add(image, 0, 0);

			var textGrid = new Grid()
			{
				ColumnDefinitions = new ColumnDefinitionCollection()
				{
					new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) }
				},
				RowDefinitions = new RowDefinitionCollection()
				{
					new RowDefinition() {Height = new GridLength(1, GridUnitType.Auto)},
					new RowDefinition() {Height = new GridLength(1, GridUnitType.Star)},
					new RowDefinition() {Height = new GridLength(20)},
				},
				BackgroundColor = Color.White,
				Padding = new Thickness(10, 2, 10, 0)
			};
			grid.Children.Add(textGrid, 0, 1);

			//TODO: Determine size of text for Smaller phones (now iPhone5, Nexus5 tested)

			var headerLabel = new Label()
			{
				Text = header,
				TextColor = Color.Black,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				Font = Font.SystemFontOfSize(24),
				LineBreakMode = LineBreakMode.WordWrap
			};
			textGrid.Children.Add(headerLabel, 0, 0);

			var detailLabel = new Label()
			{
				Text = detail,
				TextColor = Color.Black,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				Font = Font.SystemFontOfSize(16),
				LineBreakMode = LineBreakMode.WordWrap
			};
			textGrid.Children.Add(detailLabel, 0, 1);



			Content = grid;
		}

		#endregion
	}
}