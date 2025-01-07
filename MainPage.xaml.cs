namespace BoardGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void initializeTheGame_Clicked(object sender, EventArgs e)
        {


        }

        private async void monopolyLogoButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void settingsIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void optionsIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }

    }

}
