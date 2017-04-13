using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors! \nEnter your name: ");
            string playerName = Console.ReadLine();
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Would you like to play against Rocky, or Loki?");
                string newOpponent = Console.ReadLine().ToLower();
                if (Validator.ValidateOpponent(newOpponent) == true)
                {
                    Console.WriteLine("What is your play? (Rock, Paper, Scissors)?");
                    string playerThrow = Console.ReadLine().ToLower();
                    string opponentThrow = "";
                    if (newOpponent == "rocky")
                    {
                        Rocky rocky = new Rocky();
                        opponentThrow = rocky.GenerateRoshambo();
                    }
                    else if (newOpponent == "loki")
                    {
                        Loki loki = new Loki();
                        opponentThrow = loki.GenerateRoshambo();
                    }
                    Result outcome = new Result();
                    Console.WriteLine(playerName + " threw " + playerThrow + "\n" + newOpponent + " threw " + opponentThrow);
                    outcome.CalculateResult(playerThrow, opponentThrow);
                }
                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Play again? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
