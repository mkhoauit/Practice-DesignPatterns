using PracticeCommand.Classes;
using System;

namespace PracticeCommand
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("--Example--");
            client.Compute('+',0);
            client.Compute('+', 100);
            client.Compute('-', 50);
            client.Compute('*', 10);
            client.Compute('/', 2);
            // Undo 4 commands
            client.Undo(4);
            // Redo 3 commands
            client.Redo(3);

            Console.WriteLine("It is a tiny calculator ^^");
            Client client1 = new Client();

            Console.WriteLine("How many calculations do you want?");
            int calculation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your number:");
            int input = Convert.ToInt32(Console.ReadLine());
            client1.Compute('+',input);

            for (int i = 0; i < calculation; i++)
            {
                Console.WriteLine("Choose your calculation [ + - * / ] ");
                char ca = Convert.ToChar(Console.ReadLine());
                if (ca == '+') 
                {
                    Console.WriteLine("Input your next number of formla:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    client1.Compute('+',input1);
                }
                if (ca == '-')
                {
                    Console.WriteLine("Input your next number of formla:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    client1.Compute('-', input1);
                }
                if (ca == '*')
                {
                    Console.WriteLine("Input your next number of formla:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    client1.Compute('*', input1);
                }
                if (ca == '/')
                {
                    Console.WriteLine("Input your next number of formla:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    client1.Compute('/', input1);
                }

                if(ca !='+' && ca != '-'&& ca != '*'&& ca != '/') 
                {
                    Console.WriteLine("Error Input!!");
                    i = calculation;
                }
            }
            //undo 
            Console.WriteLine("Do you want to Undo?[y/n]");
            string undoAnswer = Convert.ToString(Console.ReadLine());
            if(undoAnswer.Contains("y"))
            {
                Console.WriteLine("How many calculations you want to Undo?");
                int undoLevel = Convert.ToInt32(Console.ReadLine());
                client1.Undo(undoLevel);

                //redo
                Console.WriteLine("Do you want to Redo?[y/n]");
                string redoAnswer = Convert.ToString(Console.ReadLine());
                if (redoAnswer.Contains("y")) 
                {
                    Console.WriteLine($"How many calculations you want to redo?--You have Undo {undoLevel} calculations!");
                    int redoLevel = Convert.ToInt32(Console.ReadLine());
                    client1.Undo(undoLevel);
                }
            }

            Console.WriteLine();
            Console.WriteLine("All Done. Thank you for using Khoa's calculator");



        }
    }
}
