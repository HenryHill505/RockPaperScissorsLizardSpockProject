using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public int winCount;
        public string chosenGesture;
        public List<string> gestureList;

        public Player()
        {
            winCount = 0;
            gestureList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        public abstract void ChooseGesture();
    } 

}
