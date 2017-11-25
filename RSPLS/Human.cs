using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Human : Player
    {
        //member variables

        //constructor
        public void Human()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        //member methods
    }
}
