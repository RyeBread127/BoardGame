using System.Collections.ObjectModel;
using BoardGame.ViewModel;

namespace BoardGame
{
    public partial class MainPage : ContentPage
    {
        GameBoardViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new GameBoardViewModel();
            BindingContext = viewModel;
        }

        private void initializeTheGame_Clicked(object sender, EventArgs e)
        {
            var picturePaths = new List<string>
            {
               "hatpiece.png",
               "shippiece.png",
               "dogpiece.png",
               "carpiece.png",
            };

            
        }

        private async void settingsIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void optionsIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }

        private void buyHouse_Clicked(object sender, EventArgs e)
        {
            
        }

        private void sellHouse_Clicked(object sender, EventArgs e)
        {

        }

        private void rollDice_Clicked(object sender, EventArgs e)
        {

        }
    }

}
