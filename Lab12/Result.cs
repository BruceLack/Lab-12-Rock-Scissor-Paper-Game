using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Result
    {
        public void CalculateResult(string playerThrow, string opponentThrow)
        {
            if (playerThrow == opponentThrow)
            {
                Console.WriteLine("Match is a draw.");
            }
            else if ((playerThrow == "rock" && opponentThrow != "paper") || (playerThrow == "paper" && opponentThrow != "scissors") || (playerThrow == "scissors" && opponentThrow != "rock"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose.");
            }
        }
    }
}
