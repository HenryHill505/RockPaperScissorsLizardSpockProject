using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Gesture
    {
        public string name;

        public Gesture()
        {

        }
    }

    public class Rock : Gesture
    {
        public Rock()
        {
            this.name = "Rock";
        }
    }

    public class Lizard : Gesture
    {
        public Lizard()
        {
            this.name = "Lizard";
        }
    }

    public class Spock : Gesture    
    {
        public Spock()
        {
            this.name = "Spock";
        }
    }

    public class Scissors : Gesture
    {
        public Scissors()
        {
            this.name = "Scissors";
        }
    }

    public class Paper : Gesture
    {
        public Paper()
        {
            this.name = "Paper";
        }
    }
}
