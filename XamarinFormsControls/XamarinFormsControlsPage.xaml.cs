using Xamarin.Forms;

namespace XamarinFormsControls
{
	public partial class XamarinFormsControlsPage : ContentPage
	{
		public XamarinFormsControlsPage()
		{
			InitializeComponent();

			BackgroundColor = Color.Gray;
			Content = new StackLayout()
			{
				Children = 
				{
					label1,
					loginEditor,
					label2,
					passwordEditor,
					button1
				}
			};

			button1.Clicked += (sender, e) =>
			{
				if (loginEditor.Text.Equals("Admin"))
				{
					if (passwordEditor.Text.Equals("Admin"))
					{
						Navigation.PushModalAsync(new LoggedPage());
					}

				}
			};
		}

		Button button1 = new Button()
		{
			BackgroundColor = Color.Olive,
			Text = "Zaloguj sie",
			TextColor = Color.White
		};

		Editor loginEditor = new Editor()
		{
		};

		Editor passwordEditor = new Editor()
		{
		};

		Label label1 = new Label()
		{
			Text = "Login",
			Margin = new Thickness(0,50,0,0),
			HorizontalOptions = LayoutOptions.Center
		};

		Label label2 = new Label()
		{
			Text = "Haslo",
			HorizontalOptions = LayoutOptions.Center
		};



	}
}
