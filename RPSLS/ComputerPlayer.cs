using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer : Player
    {
        // member variables (HAS A)
        public List<string> gestureOptions;
        public Random rng;

        // constructor
        public ComputerPlayer()
        {
            gestureOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            rng = new Random();
        }

        // member methods (CAN DO)
        public override void MakeMove()
        {
            //Console.WriteLine("Computer player choose a gesture!");
            //gesture = Console.ReadLine();

            int index = rng.Next(gestureOptions.Count);
            Console.WriteLine("Computer chose " + gestureOptions[index]);
            gesture = gestureOptions[index];
        }
        public override void ChooseName()
        {
            name = "Computer";
        }
    }
}
