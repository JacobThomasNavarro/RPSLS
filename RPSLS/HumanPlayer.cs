using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        // member variables (HAS A)


        // constructor


        // member methods (CAN DO)
        public override void MakeMove()
        {
            Console.WriteLine("Please choose your Gesture!");
            Console.WriteLine("Rock, Paper, Scissors, Lizard or Spock.");
            gesture = Console.ReadLine();

            switch (gesture)
            {
                case "Rock":
                    Console.WriteLine("You chose Rock!");
                    break;
                case "Paper":
                    Console.WriteLine("You chose Paper!");
                    break;
                case "Scissors":
                    Console.WriteLine("You chose Scissors!");
                    break;
                case "Lizard":
                    Console.WriteLine("You chose Lizard!");
                    break;
                case "Spock":
                    Console.WriteLine("You chose Spock!");
                    break;
                default:
                    Console.WriteLine("Not a valid gesture option.");
                    break;
            }
        }

    }
}
