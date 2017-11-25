using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS
{
    class Player
    {
        //member variables
        public string name;
        public int score;
        public int choice;

        //constructor
        public Player()
        {
            score = 0;
        }

        //member methods
        public virtual void Choice(List<string> choices)
        {
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine(name + " chose " + choices[choice] + ".");
        }
    }
}
