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
            Console.WriteLine("  1 2 3 4 5 6 7 8");
            for (int i = 0; i < 8; i++)
            {
                string asciichar = (Convert.ToChar(65 + i)).ToString();
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
            Console.WriteLine("  1 2 3 4 5 6 7 8");
            for (int i = 0; i < 8; i++)
            {
                string asciichar = (Convert.ToChar(65 + i)).ToString();
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
            int inputNums = ConvertUserInput(userInput);
            PlaceUserInput(inputNums, ownBoard);

        }
        public string GetUserPlacement(string action)
        {
            Console.WriteLine("Please enter grid location where you would like to " + action);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public int ConvertUserInput(string userInputString)
        {
            string userInputChar1 = (Convert.ToChar(userInputString[0]-49)).ToString();
            string userInputChar2 = (Convert.ToChar(userInputString[1] - 1)).ToString();
            string userInputChar = userInputChar1 + userInputChar2;
            int userInputNum = int.Parse(userInputChar);
            return userInputNum;
        }
        public void PlaceUserInput(int inputNums, List<List<string>> board)
        {
            ownBoard[inputNums/10][inputNums%10] = "0";
        }
        public void ValidateUserInput(string userInput)
        {
            // char[] userInputArray = userInput.ToCharArray();
            if (userInput[0] != "a", && userInput[0] != "b", && userInput[0] != "c", && userInput[0] !="d", && userInput[0] !="e", && userInput[0] !="f", && userInput[0] !="g", && userInput[0] !="h")
        }
    }

}
