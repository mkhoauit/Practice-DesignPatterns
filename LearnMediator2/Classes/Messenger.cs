using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    public class Messenger : Participant
    {
        // Constructor
        public Messenger(string name): base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To Messenger: ");
            base.Receive(from, message);
        }
    }
}
