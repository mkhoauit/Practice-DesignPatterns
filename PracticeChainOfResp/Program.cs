using PracticeChainOfResp.Classes;
using System;

namespace PracticeChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            //example
            Console.WriteLine("Example");
            Console.WriteLine("\n Requested Amount 4600000");
            atm.withdraw(4600000);
            Console.WriteLine();

            Console.WriteLine("How much do you want to withdraw?");
            uint input = Convert.ToUInt32(Console.ReadLine());

            atm.withdraw(input);
            Console.WriteLine();

            Console.WriteLine("All done. Have a nice day ^^ ");

        }
    }
}
