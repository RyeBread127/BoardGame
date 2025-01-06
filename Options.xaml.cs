namespace BoardGame;

public partial class Options : ContentPage
{
	public Options()
	{
		InitializeComponent();
	}
    private async void optionsIcon_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void monopolyLogoButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}