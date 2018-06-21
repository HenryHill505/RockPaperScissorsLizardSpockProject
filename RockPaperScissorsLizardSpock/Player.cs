using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        //member variables
        public int name;
        public int winCount;

        //constructor
        public Player()
        {
            winCount = 0;
        }
    }

    public class HumanPlayer : Player
    {

    }

    public class ComputerPlayer : Player
    {

    }

}
