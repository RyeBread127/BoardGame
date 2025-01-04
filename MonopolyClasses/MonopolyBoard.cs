using System;
using System.Collections.Generic;
using System.Linq;
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
        protected Squares[] squares { get; set; }

        public MonopolyBoard(int numberOfDie, Player[] players)
        {
            this.numberOfDie = numberOfDie;
            this.players = players;
            this.properties = properties;
            this.squares = squares;
        }
    }
}
