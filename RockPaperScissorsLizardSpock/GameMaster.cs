using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameMaster
    {
        Player player1;
        Player player2;
        int gameLength;
        public GameMaster()
        {

        }

        public Player CompareGestures()
        {
            string player2choice = player2.chosenGesture.name;
            switch (player1.chosenGesture.name)
            {
                case "Rock":
                    if (player2choice == "Rock") { return null; } else if (player2choice == "Scissors" || player2choice == "Lizard"){return player1; } else { return player2; }
                    break;
                case "Scissors":
                    if (player2choice == "Scissors") { return null; } else if (player2choice == "Paper" || player2choice == "Lizard") { return player1; } else { return player2; }
                    break;
                case "Paper":
                    if (player2choice == "Paper") { return null; } else if (player2choice == "Rock" || player2choice == "Spock") { return player1; } else { return player2; }
                    break;
                case "Lizard":
                    if (player2choice == "Lizard") { return null; } else if (player2choice == "Paper" || player2choice == "Spock") { return player1; } else { return player2; }
                    break;
                case "Spock":
                    if (player2choice == "Spock") { return null; } else if (player2choice == "Scissors" || player2choice == "Rock") { return player1; } else { return player2; }
                    break;
                default:
                    Console.WriteLine("CompareGestures() is BROKEN");
                    return null;
                    break;
            }
        }
        public void GetGameLength()
        {
            Console.WriteLine("How many round wins to win the game?");
            string gameLengthinput = Console.ReadLine();
            
            while(!int.TryParse(gameLengthinput, out gameLength) || gameLength < 3)
            {
                Console.WriteLine("Error. The number of round wins must be an integer greater than 3");
                gameLengthinput = Console.ReadLine();
            }
        }
        public string GetPlayerCount()
        {
            Console.WriteLine("1 player game or 2 player game?");
            return Console.ReadLine();
        }

        public void CreatePlayers()
        {
            switch(GetPlayerCount()){
                case "1":
                    player1 = new Human();
                    Console.WriteLine("Player 1, please enter your name");
                    player1.name = Console.ReadLine();
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    Console.WriteLine("Player 1, please enter your name");
                    player1.name = Console.ReadLine();
                    Console.WriteLine("Player 2, please enter your name");
                    player2.name = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Error: Entered invalid number of players. Enter 1 or 2");
                    CreatePlayers();
                    break;
            }
        }

        public void DisplayGameResults()
        {
            Console.ReadLine();
            if (player1.winCount >= gameLength)
            {
                Console.WriteLine($"{player1.name} won the game!");
            }
            else if (player2.winCount >= gameLength)
            {
                Console.WriteLine($"{player2.name} won the game!");
            }
            Console.ReadLine();
        }

        public void RunGame()
        {
            CreatePlayers();
            GetGameLength();
            while(player1.winCount < gameLength && player2.winCount < gameLength)
            {
                RunRound();    
            }
            DisplayGameResults();
        }

        public void RunRound()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();

            Console.WriteLine($"{player1.name} chose: {player1.chosenGesture.name}");
            Console.WriteLine($"{player2.name} chose: {player2.chosenGesture.name}");
            Player winningPlayer = CompareGestures();
            if (winningPlayer == null)
            {
                Console.WriteLine("You tied!");
            }
            else
            {
                winningPlayer.winCount++;
                Console.WriteLine($"{winningPlayer.name} Won!");
            }
            Console.ReadLine();
            Console.WriteLine($"{player1.name}: {player1.winCount} {player2.name}: {player2.winCount}");
        }
    }
}
