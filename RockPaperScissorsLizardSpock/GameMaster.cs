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
    }
}
