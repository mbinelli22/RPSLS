using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class RPSLS_UI
    {
        //member variables

        //constructor
        public RPSLS_UI()
        {

        }

        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine(" ");
            Console.WriteLine("Rules for Rock, Paper, Scissors, Lizard, Spock:");
            Console.WriteLine(" ");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("(and as it always has) Rock crushes Scissors");
            Console.WriteLine(" ");
            Console.WriteLine("Best of three decides the winner. Have fun!!");
            Console.WriteLine("(Press any key to continue.)");
            Console.ReadLine();
        }







    }
}
