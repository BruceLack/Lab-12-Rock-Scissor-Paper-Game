using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rocky : IPlayer
    {
        private string name;
        private string roshamboValue;

        string IPlayer.Name()
        {
            return "Rocky";
        }
        public string RoshamboValue()
        {
            return "rock";
        }
        public string GenerateRoshambo()
        {
            return "rock";
        }
    }
}