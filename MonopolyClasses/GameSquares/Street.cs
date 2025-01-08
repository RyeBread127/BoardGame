using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.MonopolyClasses.GameSquares
{
    internal class Street : Property
    {
        protected string colour { get; set; }
        protected int buildingPrice { get; set; }
        protected int numberOfHouses { get; set; }

        public Street(string name, int buyingPrice, int rent, bool mortgaged, string colour, int buildingPrice, int numberOfHouses, int owner)
        {
            this.name = name;
            this.buyingPrice = buyingPrice;
            this.rent = rent;
            this.mortgaged = mortgaged;
            this.colour = colour;
            this.buildingPrice = buildingPrice;
            this.numberOfHouses = numberOfHouses;
            this.owner = owner;
        }
    }
}
