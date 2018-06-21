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
        public Gesture chosenGesture;
        public List<Gesture> gestureList;

        public Player()
        {
            winCount = 0;
            gestureList = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
        }

        public abstract void ChooseGesture();
    }

    public class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine($"{name}, Select a gesture: ");
            int count = 0;
            foreach (Gesture gesture in gestureList)
            {
                count++;
                Console.Write($"{count}. {gesture.name} ");
            }
            Console.WriteLine("");
            string inputString = Console.ReadLine();
            int gestureChoice;
            
            while (!int.TryParse(inputString, out gestureChoice) || gestureChoice>gestureList.Count || gestureChoice <= 0)
            {
                Console.WriteLine("Invalid input. Enter the number corresponding to your choice");
                inputString = Console.ReadLine();
            }

            chosenGesture = gestureList[gestureChoice - 1];
        }
    }

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
