using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameMaster
    {
        //member variables
        Player player1;
        Player player2;
        public GameMaster()
        {

        }

        public Player CompareGestures()
        {
            string player2choice = player2.chosenGesture.name;
            switch (player1.chosenGesture.name)
            {
                case "Rock":
                    if (player2choice == "Scissors" || player2choice == "Lizard"){return player1; } else { return player2; }
                    break;
                case "Scissors":
                    if (player2choice == "Paper" || player2choice == "Lizard") { return player1; } else { return player2; }
                    break;
                case "Paper":
                    if (player2choice == "Rock" || player2choice == "Spock") { return player1; } else { return player2; }
                    break;
                case "Lizard":
                    if (player2choice == "Paper" || player2choice == "Spock") { return player1; } else { return player2; }
                    break;
                case "Spock":
                    if (player2choice == "Scissors" || player2choice == "Rock") { return player1; } else { return player2; }
                    break;
                default:
                    Console.WriteLine("CompareGestures() is BROKEN");
                    return null;
                    break;
            }
        }
        public string GetPlayerCount()
        {
            Console.WriteLine("1 player game or 2 player game?");
            return Console.ReadLine();
        }

        public void CreatePlayers()
        {
            player1 = new HumanPlayer();
            switch(GetPlayerCount()){
                case "1":
                    player2 = new ComputerPlayer();
                    break;
                case "2":
                    player2 = new HumanPlayer();
                    break;
                default:
                    Console.WriteLine("Error: Entered invalid number of players");
                    break;
            }
        }

        public void DisplayGameResults()
        {
            if (player1.winCount >= 3)
            {
                Console.WriteLine("Player 1 won the game!");
            }
            else if (player2.winCount >= 3)
            {
                Console.WriteLine("Player 2 won the game!");
            }
            Console.ReadLine();
        }

        public void RunGame()
        {
            CreatePlayers();
            while(player1.winCount < 3 && player2.winCount < 3)
            {
                RunRound();    
            }
            DisplayGameResults();
        }

        public void RunRound()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();

            Console.WriteLine("Player 1 chose: " + player1.chosenGesture.name);
            Console.WriteLine("Player 2 chose: " + player2.chosenGesture.name);
            Player winningPlayer = CompareGestures();
            winningPlayer.winCount++;
            Console.WriteLine("Player 1: " + player1.winCount + " Player 2: " + player2.winCount);
        }
    }
}
