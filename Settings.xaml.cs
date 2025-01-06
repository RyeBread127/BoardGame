namespace BoardGame;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private async void monopolyLogoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void settingsIcon_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}