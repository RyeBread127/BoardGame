using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGame.MonopolyClasses.GameSquares;

namespace BoardGame.MonopolyClasses
{
    internal class Player
    {
        protected String name { get; set; }
        protected int money { get; set; }
        protected int position { get; set; }
        protected int getOutOfJailCards { get; set; }
        protected List<Property> properties = new List<Property>(8);
        protected bool bankrupt { get; set; }

        public Player(string name, int money, int position, int getOutOfJailCards, List<Property> properties, bool bankrupt)
        {
            this.name = name;
            this.money = money;
            this.position = position;
            this.getOutOfJailCards = getOutOfJailCards;
            this.properties = properties;
            this.bankrupt = bankrupt;
        }
    }
}
