namespace BoardGame
{
    public partial class MainPage : ContentPage
    {
        private int boardHeight = 8;
        private int boardLength = 8;
        private int[,] chessBoard;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeTheGame_Clicked(object sender, EventArgs e)
        {
            chessBoard = new int[boardHeight, boardLength];

            //initialises amount of rows and cols
            for (int i = 0; i < boardHeight; i++)
            {
                visibleChessBoard.AddRowDefinition(new RowDefinition());
            }
            for (int i = 0; i < boardLength; i++)
            {
                visibleChessBoard.AddColumnDefinition(new ColumnDefinition());
            }

            //makes the board visible
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardLength; j++)
                {
                    Border squareStyle = new Border()
                    {
                        BackgroundColor = Colors.Orange,

                    };
                    visibleChessBoard.Add(squareStyle, i, j);

                    Label label = new Label()
                    {
                        //Text = chessBoard[i, j].ToString(),
                    };
                    visibleChessBoard.Add(label, i, j);

                    Button square = new Button()
                    {
                        BackgroundColor = Colors.Orange,
                        //Text = chessBoard[i, j].ToString(),
                    };

                    visibleChessBoard.Add(square, i, j);
                }
            }
        }

    }

}
