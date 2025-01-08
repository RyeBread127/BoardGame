using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGame.MonopolyClasses;

namespace BoardGame.ViewModel
{
    internal class GameBoardViewModel
    {
        MonopolyBoard monopolyBoard;
        int playerMoney;
        public GameBoardViewModel() 
        { 
            monopolyBoard = new MonopolyBoard();
            playerMoney = 1500;
        }
    }
}
