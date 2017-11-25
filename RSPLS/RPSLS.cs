using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class RPSLS
    {
        //member variables
        public string Rock;
        public string Paper;
        public string Scissors;
        public string Spock;
        public string Lizard;
        int randomThrow;
        int rock = 0;
        int paper = 1;
        int scissors = 2;
        int spock = 3;
        int lizard = 4;

        Player player1;
        Player player2;
        RPSLS_UI UI;


        //constructor
        //public RPSLS(string rock, string paper, string scissors, string spock, string lizard)
        //{

        //}

        public RPSLS()
        {
            UI = new RPSLS_UI();
        }

        //memeber methods




        //- Create a console application for Rock, Paper, Scissors, Lizard, Spock
        //- Your game should have the option of Single player(vs AI) or 2 player(Human vs Human)



        public void SinglePlayerOrMultiPlayer()
        {
            Console.WriteLine("To play agianst the computer type 'ai'. To play human vs human type 'human'.");
            string vsDecision = Console.ReadLine();
            player1 = new Human();
            switch (vsDecision)
            {
                case "ai":
                    player2 = new Computer();
                    break;
                case "human":
                    player2 = new Human();
                    break;
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine("{0} {1} ");
        }

        List<string> throws = new List<string>() {"Rock", "Paper", "Scissors", "Spock", "Lizard"};



        private void GetRandomThrow()
        {
            int randomThrow;
            Random rnd = new Random();
            randomThrow = rnd.Next(0, 5);
            switch (randomThrow)
            {
                case 0:
                    Console.WriteLine("Computer threw Rock.");
                    break;
                case 1:
                    Console.WriteLine("Computer threw Paper.");
                    break;
                case 2:
                    Console.WriteLine("Computer threw Scissors.");
                    break;
                case 3:
                    Console.WriteLine("Computer threw Spock.");
                    break;
                case 4:
                    Console.WriteLine("Computer threw Lizard.");
                    break;
            }
        }


        
        // d = (5 + a - b) % 5
        // d = 1 or d = 3 => a wins
        // d = 2 or d = 4 => b wins
        // d = 0 => tie




        public void PlayGame()
        {
            
            //Console.WriteLine("Type in what you want to play. \n Rock, Paper, Scissors, Lizard, Spock, SHOOT!");
            //string shoot = Console.ReadLine();
            //switch (shoot)
            //{
            //    case "rock":

            //        break;
            //    case "paper":

            //        break;
            //    case "scissors":

            //        break;
            //    case "lizzard":

            //        break;
            //    case "spock":

            //        break;
             }
        }


    }
}
