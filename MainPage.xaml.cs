namespace BoardGame
{
    public partial class MainPage : ContentPage
    {
        private int boardHeight = 11;
        private int boardLength = 11;
        private int[,] board;

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
