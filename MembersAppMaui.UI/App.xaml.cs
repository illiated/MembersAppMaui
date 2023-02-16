using MembersAppMaui.UI.Views;

namespace MembersAppMaui.UI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomePage());
	}
}
