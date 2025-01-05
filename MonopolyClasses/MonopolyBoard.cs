using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BoardGame.MonopolyClasses.GameSquares;

namespace BoardGame.MonopolyClasses
{
    internal class MonopolyBoard
    {
        protected int numberOfDie;
        protected int numberOfHouses = 32;
        protected int numberOfHotels = 12;
        protected Player[] players { get; set; }
        protected Property[] properties { get; set; }
        protected Squares[] boardSquares { get; set; }

        public MonopolyBoard(int numberOfDie, Player[] players)
        {
            this.numberOfDie = numberOfDie;
            this.players = players;
            this.properties = properties;
            this.boardSquares = boardSquares;

            boardSquares = new Squares[40];


            //assigning each square on the board its object
            boardSquares[0] = new Go("GO");
            boardSquares[1] = new Street("San Diego Drive", 60, 25, false, "Brown", 50, 0); //(name, purchase_price, rent, is_mortgaged, colour, mortgaged_value, amount_of_house)
            //community chest
            boardSquares[3] = new Street("Kansas Drive", 90, 25, false, "Brown", 50, 0);
            //income tax
            //railroad
            boardSquares[6] = new Street("Vermont Drive", 120, 35, false, "Teal", 90, 0);
            //chance
            boardSquares[8] = new Street("Phoenix Drive", 130, 35, false, "Teal", 90, 0);
            boardSquares[9] = new Street("Boston Drive", 150, 35, false, "Teal", 90, 0);
            //in jail/just visiting
            boardSquares[11] = new Street("Olivia Gardens", 140, 50, false, "Pink", 130, 0);
            //car company
            boardSquares[13] = new Street("California Drive", 160, 50, false, "Pink", 130, 0);
            boardSquares[14] = new Street("States Drive", 140, 60, false, "Pink", 150, 0);
            //railroad
            boardSquares[16] = new Street("Bethany Drive", 180, 170, false, "Orange", 170, 0);
            //community chest
            boardSquares[18] = new Street("New York Drive", 200, 170, false, "Orange", 170, 0);
            boardSquares[19] = new Street("Atlanta Drive", 200, 190, false, "Orange", 170, 0);
            //free parking
            boardSquares[21] = new Street("Almond Drive", 200, 190, false, "Red", 170, 0);
            //chance
            boardSquares[23] = new Street("Clement Drive", 200, 190, false, "Red", 170, 0);
            boardSquares[24] = new Street("Pacific Drive", 260, 190, false, "Red", 170, 0);
            //railroad
            boardSquares[26] = new Street("Rodeo Drive", 260, 190, false, "Yellow", 170, 0);
            boardSquares[27] = new Street("Nashville", 260, 190, false, "Yellow", 170, 0);
            //utility
            boardSquares[29] = new Street("Oakville", 230, 190, false, "Yellow", 170, 0);
            //go to jail
            boardSquares[31] = new Street("Atlantic Drive", 300, 190, false, "Green", 170, 0);
            boardSquares[32] = new Street("Clement Drive", 300, 190, false, "Green", 170, 0);
            //community chest
            boardSquares[34] = new Street("Riverside", 250, 190, false, "Green", 170, 0);
            //railroad
            //chance
            boardSquares[37] = new Street("Folklore Heights", 200, 190, false, "Blue", 170, 0);
            //income tax
            boardSquares[39] = new Street("Salt lake", 350, 190, false, "Blue", 170, 0);
        }

        public static int rollDice()
        {
            var rand = new Random();

            int dice1 = rand.Next(6);
            int dice2 = rand.Next(6);

            return dice1 + dice2;
        }
    }
}
