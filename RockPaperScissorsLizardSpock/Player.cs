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
        public Gesture chosenGesture;
        public List<Gesture> gestureList;

        //constructor
        public Player()
        {
            winCount = 0;
            gestureList = new List<Gesture>() { new Rock(), new Lizard(), new Spock(), new Scissors(), new Paper() };
        }
    }

    public class HumanPlayer : Player
    {
        public void ChooseGesture()
        {
            Console.WriteLine("Select a gesture: ");
            int count = 0;
            foreach (Gesture gesture in gestureList)
            {
                count++;
                Console.Write(count + ". " + gesture.name + "   ");
            }
            string inputString = Console.ReadLine();
            int gestureChoice;
            
            while (!int.TryParse(inputString, out gestureChoice) || gestureChoice>gestureList.Count || gestureChoice <= 0)
            {
                Console.WriteLine("Invalid input. Enter the number corresponding to your choice");
            }

            chosenGesture = gestureList[gestureChoice - 1];
        }
    }

    public class ComputerPlayer : Player
    {

    }

}
