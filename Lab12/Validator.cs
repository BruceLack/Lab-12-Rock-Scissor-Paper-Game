using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class Validator
    {
        public static Boolean ValidateOpponent(string newOpponent)
        {
            if (newOpponent == "rocky" || newOpponent == "loki")
            {
                return true;
            }
            else
            {
                Console.WriteLine("I'm sorry, that was not a valid input");
                return false;
            }
        }
    }
}
