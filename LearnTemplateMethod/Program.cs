using LearnTemplateMethod.Classes;
using System;

namespace LearnTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> Welcome to Khoa's MilkTea <== ");
            Console.WriteLine(" --- Menu --- ");
            Console.WriteLine("-- Bubble Tea --");
            Console.WriteLine("-- Black  Tea --");
            Console.WriteLine("-- Green  Tea --");
            Console.WriteLine("-- Peach  Tea --");
            Console.WriteLine("-->Choose your drink:");
            string drink = Console.ReadLine().checkDrink();
            Console.WriteLine($"-->You choose: {drink} ");
            Console.WriteLine();

            switch (drink) 
            {
                case "Bubble Tea":
                    Console.WriteLine("Bubble Tea Preparation:");
                    MilkteaTemplate bubbletea = new BubbleTea();
                    bubbletea.PrepareMilktea();
                    break;
                case "Black Tea":
                    Console.WriteLine("Black Tea Preparation:");
                    MilkteaTemplate blacktea = new BlackTea();
                    blacktea.PrepareMilktea();
                    break;
                case "Green Tea":
                    Console.WriteLine("Green Tea Preparation:");
                    MilkteaTemplate greentea = new GreenTea();
                    greentea.PrepareMilktea();
                    break;
                case "Peach Tea":
                    Console.WriteLine("Peach Tea Preparation:");
                    MilkteaTemplate peachtea = new PeachTea();
                    peachtea.PrepareMilktea();
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Thank you. See you next time (^.^) Have a nice day.");
        }
    }
    public static class Extensions
    {

        public static string checkDrink(this string strType)
        {

            if (strType.ToLower() == "bubbletea"|| strType.ToLower() == "bubble tea")
            {

                return "Bubble Tea";
            }
            else if (strType.ToLower() == "blacktea" || strType.ToLower() == "black tea")
            {

                return "Black Tea";
            }
            else if (strType.ToLower() == "greentea" || strType.ToLower() == "green tea")
            {

                return "Green Tea";
            }
            else if (strType.ToLower() == "peachtea" || strType.ToLower() == "peach tea")
            {

                return "Peach Tea";
            }
            else
            {
                Console.WriteLine("Please input type of drink correctly!");
                return null;
            }

        }
    }
}
