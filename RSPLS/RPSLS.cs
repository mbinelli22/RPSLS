using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSPLS;

namespace RSPLS
{
    class RPSLS
    {
        //member variables

        List<string> choices;

        Player player1;
        Player player2;
        RPSLS_UI UI;
        List<string> throws = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };

        //constuctor
        public RPSLS()
        {
            UI = new RPSLS_UI();
            choices = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        //memeber methods

        public void PlayGame()
        {
            player1 = new Player();
            UI.DisplayRules();
            GetPlayer1Name();
            SinglePlayerOrMultiPlayer();
            GetChoice();
        }

        public void GetPlayer1Name()
        {
            Console.WriteLine("Enter your name:");
            player1.name = Console.ReadLine();
        }
        
        public string DisplayOptions()
        {
            Console.WriteLine("Enter the number that corresponds to the choice you want:");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissors");
            Console.WriteLine("4: Lizard");
            Console.WriteLine("5: Spock");
            return Console.ReadLine();
        }

        public void SinglePlayerOrMultiPlayer()
        {
            Console.WriteLine("Lets get started!");
            Console.WriteLine("To play agianst the computer type 'ai'. To play human vs human type 'human'.");
            string vsDecision = Console.ReadLine();
            player1 = new Player ();
            switch (vsDecision)
            {
                case "ai":
                    player2 = new Computer();
                    break;
                case "human":
                    player2 = new Player();
                    GetPlayer2Name();
                    break;
            }
        }

        public void GetPlayer2Name()
        {
            Console.WriteLine("Player 2 enter your name: ");
            player2.name = Console.ReadLine();
        }

        //- Create a console application for Rock, Paper, Scissors, Lizard, Spock
        //- Your game should have the option of Single player(vs AI) or 2 player(Human vs Human)

        public void DisplayScore()
        {
            Console.WriteLine("{0} {1} ");
        }




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
                    Console.WriteLine("Computer threw Lizard.");
                    break;
                case 4:
                    Console.WriteLine("Computer threw Spock.");
                    break;
            }
        }


        
        // d = (5 + a - b) % 5
        // d = 1 or d = 3 => a wins
        // d = 2 or d = 4 => b wins
        // d = 0 => tie

        public void GetMatchWinner()
        {
            int d = ((5 + player1.choice - player2.choice) % 5); 
            
                if (d == 1 || d == 3)
                {
                    Console.WriteLine(player1.name + "won that game");
                    player1.score++;
                }
                else if (d == 2 || d == 4)
                {
                    Console.WriteLine(player2.name + "won that game");
                    player2.score++;
                }
                else if (d == 0)
                {
                    Console.WriteLine("tie! hit any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("please select a number representing your choice");
                }
        }



        public void CheckScore()
        {
            if(player1.score == 2)
            {
                Console.WriteLine(player1.name + " Wins!");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine(player2.name + " Wins!");
            }
        }





        public void GetChoice()
        {
            Console.WriteLine("Type in what you want to play. \n Rock, Paper, Scissors, Lizard, Spock, SHOOT!");
            string shoot = Console.ReadLine();
            switch (shoot)
            {
                case "rock":

                    break;
                case "paper":

                    break;
                case "scissors":

                    break;
                case "lizzard":

                    break;
                case "spock":

                    break;
            }
        }


    }
}
