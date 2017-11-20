using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        
        public void OpenBoard ()
        {
            List <List<String>> board = new List<List<String>>();
            for (int i = 0; i < 9; i++)
            {
                List<string> row = new List<string>() { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" };
                board.Add(row);
            }
            DisplayBoard(board);
        }
        public void DisplayBoard(List<List<String>>board)
        {

            Console.WriteLine("\n  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                string asciichar = (Convert.ToChar(49 + i)).ToString();
                Console.Write(asciichar + " ");
                for (int j = 0; j < 8; j++)
                {
                    //put a single value
                    Console.Write(board[i][j] + " ");
                }
                //next row
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
