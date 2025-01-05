namespace BoardGame;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private async void optionsIcon_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Options());
    }

    private async void monopolyLogoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void settingsIcon_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}