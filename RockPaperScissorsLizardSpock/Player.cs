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
        int name;
        int winCount;

        //constructor
        public Player()
        {
             
        }
    }

    public class HumanPlayer : Player
    {

    }

    public class ComputerPlayer : Player
    {

    }

}
