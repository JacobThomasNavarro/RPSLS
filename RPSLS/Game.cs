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

        // constructor
        public Game()
        {
       
        }

        // member methods (CAN DO)
        public void RunGame() // master method
        {
            DisplayRules();

            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);

            playerOne.ChooseName();
            playerTwo.ChooseName();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.MakeMove();
                playerTwo.MakeMove();

                if ((playerOne.gesture == "rock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "rock" && playerTwo.gesture == "lizard"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "scissors" && playerTwo.gesture == "paper") || (playerOne.gesture == "scissor" && playerTwo.gesture == "lizard"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "paper" && playerTwo.gesture == "rock") || (playerOne.gesture == "paper" && playerTwo.gesture == "spock"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "lizard" && playerTwo.gesture == "spock") || (playerOne.gesture == "lizard" && playerTwo.gesture == "paper"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "spock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "spock" && playerTwo.gesture == "rock"))
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
                DisplayCurrentScore();
            }

            DisplayGameWinner();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Two players will throw Rock, Paper, Scissors, Spock or Lizard simultaneously.");
            Console.WriteLine("Best 2 out of 3 will win!");
        }
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current score: " + playerOne.name + ":" + playerOne.score + " " + playerTwo.name + ":" + playerTwo.score);
        }
        public void DisplayGameWinner()
        {
            if(playerOne.score > playerTwo.score)
            {
                Console.WriteLine(playerOne.name +  " won the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won the game!");
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
