using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    class Zalo : Participant
    {
        // Constructor
        public Zalo(string name) : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To Zalo: ");
            base.Receive(from, message);
        }
    }
}
