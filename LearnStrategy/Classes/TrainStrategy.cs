using LearnStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnStrategy.Classes
{
    public class TrainStrategy : ITravelStrategy
    {
        private int ticketTrain = 60000;

        public void GotoMall()
        {
            Console.WriteLine($"Traveler is going to Mall by Train and will be charged {ticketTrain} VND");

        }

        public int RoundTripTicket()
        {
            return ticketTrain * 2 - ticketTrain *10/100;
        }
    }
}
