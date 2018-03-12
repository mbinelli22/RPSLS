using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Computer : Player
    {
        //member variables
        Random random;
   

        //constructor
        public Computer()
        {
            name = "Computer";
            random = new Random();
        }


        //member methods
        public override void Choice(List<string> choices)
        {
            base.Choice(choices);
            choice = random.Next(5);
            Console.WriteLine("The Computer chose" + choices[choice] + ".");
        }
    }
}
