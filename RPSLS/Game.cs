using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public List<string> gestureOptions;

        // constructor
        public Game()
        {
            playerOne = new ComputerPlayer();
            playerTwo = new HumanPlayer();
            gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        // member methods (CAN DO)
        public void RunGame() // master method
        {
            DisplayRules();

            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);

            playerOne.MakeMove();
            playerTwo.MakeMove();

            //put gesture comparisons here
            DisplayCurrentScore();
            //put gesture comparison here

            DisplayGameWinner();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Two players will throw Rock, Paper, Scissors, Spock or Lizard simultaneously.");
            Console.WriteLine("Best 2 out of 3 will win!");
        }
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current score: " + playerOne.score + " " + playerTwo.score);
        }
        public void DisplayGameWinner()
        {
            if(playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One won the game!");
            }
            else
            {
                Console.WriteLine("Player Two won the game!");
            }
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new HumanPlayer();
                playerTwo = new ComputerPlayer();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new HumanPlayer();
                playerTwo = new HumanPlayer();
            }
        }
}
}
