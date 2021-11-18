using LearnSingleton.Classes;
using System;

namespace LearnSingleton
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
             
            if (s1 == s2)
            {
                
                Console.WriteLine($"Singleton works, both variables contain the same instance:  ");
                
            }

            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine("How many requests do you want?");
            uint numberRequest = Convert.ToUInt32(Console.ReadLine());

            for (int i = 1; i <= numberRequest; i++)
            {
                string server = singleton.Server;
                Console.WriteLine("Request " + i + " connect to : " + server);
            }

        }
    }
}
