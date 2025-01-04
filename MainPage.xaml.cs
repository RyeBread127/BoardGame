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

        private void InitializeTheGame_Clicked(object sender, EventArgs e)
        {
            board = new int[boardHeight, boardLength];

            //initialises amount of rows and cols
            for (int i = 0; i < boardHeight; i++)
            {
                gameBoard.AddRowDefinition(new RowDefinition());
            }
            for (int i = 0; i < boardLength; i++)
            {
                gameBoard.AddColumnDefinition(new ColumnDefinition());
            }

            //makes the board visible
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardLength; j++)
                {
                    Button square = new Button()
                    {
                        BackgroundColor = Colors.Orange,
                        
                    };
                    gameBoard.Add(square, i, j);

                    Label label = new Label()
                    {
                        Text = board[i, j].ToString(),
                    };
                    gameBoard.Add(label, i, j);
                }

            }

        }

    }

}
