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
        public ComputerPlayer playerOne;
        public HumanPlayer playerTwo;
        public string RPSLS;
        public Random rng;

        // constructor
        public Game()
        {

        }

        // member methods (CAN DO)
        public void RunGame() // master method
        {

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
    }
}
