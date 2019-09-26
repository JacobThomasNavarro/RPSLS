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
            Console.WriteLine("Human player choose a gesture!");
            gesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Human choose a name!");
            name = Console.ReadLine();
        }
    }
}
