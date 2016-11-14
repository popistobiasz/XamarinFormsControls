using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsControls
{
	public partial class LoggedPage : ContentPage
	{
		public LoggedPage()
		{
			InitializeComponent();

			Content = new StackLayout()
			{
				Children =
				{
					new Label
					{
						Text = "Adam zaraz Ci pomoge",
						Margin = new Thickness(0,50,0,0),
						HorizontalOptions = LayoutOptions.Center
					},
					button1
				}
			};

			button1.Clicked += (sender, e) =>
			{
				Navigation.PopModalAsync();
			};


		}

		Button button1 = new Button
		{
			BackgroundColor = Color.Red,
			Text = "POWROT"
		};
	}
}
