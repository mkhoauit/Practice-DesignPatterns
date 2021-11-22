using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
    class GrabBikeStrategy : ITravelStrategy
    {
        private int ticketBike = 30000;

        public void GotoMall()
        {
            Console.WriteLine($"Traveler is going to Mall by GrabBike and will be charged {ticketBike} VND");

        }

        public int RoundTripTicket()
        {
            return ticketBike * 2 - ticketBike * 10 / 100;
        }
    }
}
