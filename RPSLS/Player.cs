using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        // member variables (HAS A)
        public int score;
        public string name;
        public string gesture;

        // constructor
        public Player()
        {
            score = 0;
        }

        // member methods (CAN DO)
        public abstract void MakeMove();
        public abstract void ChooseName();
    }
}
