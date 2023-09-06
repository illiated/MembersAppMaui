using MembersApp.Views;

namespace MembersApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomePage())
		{
			BarBackgroundColor = Color.FromRgb(55, 49, 81),
			BarTextColor = Color.FromRgb(255, 255, 255)
		};
	}
}
