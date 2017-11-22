using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public void RunGame()
        {
            DisplayRules();
            playerOne = new Player();
            playerOne.OpenOwnBoard();
            playerOne.DisplayOwnBoard();
            playerOne.PlaceShip();
            playerOne.DisplayOwnBoard();
            playerOne.ClearBoard();
            //player one place ships
            //creat player two
            //display player two board
            //player two place ships
        }
        public void DisplayRules()
        {
            Console.WriteLine("It's battleship.  Please look away when it is not your turn.");
        }
    }
}
