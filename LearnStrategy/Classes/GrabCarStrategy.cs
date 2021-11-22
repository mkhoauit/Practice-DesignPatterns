using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
    class GrabCarStrategy: ITravelStrategy
    {
        private int ticketCar = 40000;

        public void GotoMall()
        {
            Console.WriteLine($"Traveler is going to Mall by GrabCar and will be charged {ticketCar} VND");

        }

        public int RoundTripTicket()
        {
            return ticketCar * 2 - ticketCar * 10 / 100;
        }
    }
}
