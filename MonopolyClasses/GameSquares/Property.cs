using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.MonopolyClasses.GameSquares
{
    abstract internal class Property : Squares
    {
        protected int buyingPrice { get; set; }
        protected int[] rent;
        protected bool mortgaged { get; set; }
    }
}
