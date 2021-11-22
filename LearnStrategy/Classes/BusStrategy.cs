using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
    class BusStrategy : ITravelStrategy
    {
        private int ticketBus = 5000;

        public void GotoMall()
        {
            Console.WriteLine($"Traveler is going to Mall by Bus and will be charged {ticketBus} VND");

        }

        public int RoundTripTicket()
        {
            int ticketbus = ticketBus * 2 - ticketBus * 10 / 100;
            return ticketbus;
        }
    }
}
