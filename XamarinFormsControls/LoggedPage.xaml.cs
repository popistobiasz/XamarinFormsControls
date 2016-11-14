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
						Text = "działa . . . ",
						Margin = new Thickness(0,50,10,15),
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
