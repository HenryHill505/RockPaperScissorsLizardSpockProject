using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        public Computer()
        {
            this.name = "Computer";
        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            chosenGesture = gestureList[randomNumber];
        }
    }
}
