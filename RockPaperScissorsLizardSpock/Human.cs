using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine($"{name}, Select a gesture: ");
            int count = 0;
            foreach (string gesture in gestureList)
            {
                count++;
                Console.Write($"{count}.{gesture} ");
            }
            Console.WriteLine("");
            string inputString = Console.ReadLine();
            int gestureChoice;

            while (!int.TryParse(inputString, out gestureChoice) || gestureChoice > gestureList.Count || gestureChoice <= 0)
            {
                Console.WriteLine("Invalid input. Enter the number corresponding to your choice");
                inputString = Console.ReadLine();
            }

            chosenGesture = gestureList[gestureChoice - 1];
        }
    }
}
