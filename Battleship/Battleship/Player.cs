using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public List<List<string>> ownBoard;
        public List<List<string>> oppBoard;
        public void OpenOwnBoard()
        {
            ownBoard = new List<List<string>>();
            for (int i = 0; i < 8; i++)
            {
                List<string> row = new List<string>() { "#", "#", "#", "#", "#", "#", "#", "#"};
                ownBoard.Add(row);
            }
        }
        public void DisplayOwnBoard()
        {
            Console.WriteLine("\n   YOUR BOARD   ");
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                string asciichar = (Convert.ToChar(49 + i)).ToString();
                Console.Write(asciichar + " ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(ownBoard[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void OpenOppBoard()
        {
            oppBoard = new List<List<string>>();
            for (int i = 0; i < 8; i++)
            {
                List<string> row = new List<string>() { "#", "#", "#", "#", "#", "#", "#", "#" };
                oppBoard.Add(row);
            }
        }
        public void DisplayOppBoard()
        {
            Console.WriteLine("\n YOUR OPPONENTS BOARD ");
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                string asciichar = (Convert.ToChar(49 + i)).ToString();
                Console.Write(asciichar + " ");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(oppBoard[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void ClearBoard()
        {
            Console.WriteLine("\n please type 'done' to clear the screen");
            string userInput = Console.ReadLine();
            if (userInput == "done")
            {
                Console.Clear();
            }
        }
        public void PlaceShip()
        {
            string userInput = GetUserPlacement("place ship");

        }
        public string GetUserPlacement(string action)
        {
            Console.WriteLine("Please enter grid location where you would like to" + action);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public Array ConvertUserInput(string userInput)
        {

        }
    }

}
