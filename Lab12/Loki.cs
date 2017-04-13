using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Loki : IPlayer
    {
 
        private string name;
        private string roshamboValue;
        public string Name()
        {
            return "Loki";
        }
        public string RoshamboValue()
        {
            return "random";
        }
        public string GenerateRoshambo()
        {
            string result = "";
            {
                Random rnd = new Random();
                int choice = rnd.Next(1, 4); 
                if (choice == 1)
                {
                    result = "rock";
                }
                else if (choice == 2)
                {
                    result = "scissors";
                }
                else if (choice == 3)
                {
                    result = "paper";
                }
            }
            return result;
        }
    }
}
