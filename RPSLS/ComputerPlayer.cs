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


        // constructor


        // member methods (CAN DO)
        public override void MakeMove()
        {
            Console.WriteLine("Computer player choose a gesture!");
            gesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Please enter a computer player name.");
            name = Console.ReadLine();
        }
    }
}
