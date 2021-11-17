using LearnBuilder.Classes;
using System;

namespace LearnBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var client = new Client();
            var barber = new Barber();
                
            client.Barber = barber;

            Console.WriteLine("---Choose your service [Input a number]---");
            Console.WriteLine("1: Standard service");
            Console.WriteLine("2: Full service");
            Console.WriteLine("3: Custom service");
            uint input = Convert.ToUInt32(Console.ReadLine());

            switch (input) 
            {
                case 1:
                    Console.WriteLine("Standard basic service:");
                    client.NormalService();
                    Console.WriteLine(barber.GetService().ListService()) ;
                    barber.CostHair();
                    break;
                case 2:
                    Console.WriteLine("Standard full service:");
                    client.FullService();
                    Console.WriteLine(barber.GetService().ListService());
                    
                    break;
                case 3:
                    Console.WriteLine("---Choose your service [Input a number]---");
                    Console.WriteLine("1: HairCut + CleanEar");
                    Console.WriteLine("2: HairCut + ShaveBeard");
                    Console.WriteLine("3: CleanEar + ShaveBeard");
                    Console.WriteLine("4: HairCut");
                    Console.WriteLine("5: CleanEar");
                    Console.WriteLine("6: ShaveBeard");
                    uint input2 = Convert.ToUInt32(Console.ReadLine());
                    switch (input2)
                    {
                        case 1:
                            barber.HairCut();
                            barber.CleanEar();                            
                            Console.Write(barber.GetService().ListService());
                            barber.CostHairEar();
                            break;
                        case 2:
                            barber.HairCut();
                            barber.ShaveBeard();                           
                            Console.Write(barber.GetService().ListService()); 
                            barber.CostHairBeard();
                            break;
                        case 3:                            
                            barber.CleanEar();
                            barber.ShaveBeard();                            
                            Console.Write(barber.GetService().ListService());
                            barber.CostEarBeard();
                            break;
                        case 4:
                            barber.HairCut();                            
                            Console.Write(barber.GetService().ListService());
                            barber.CostHair();
                            break;
                        case 5:
                            barber.CleanEar();                           
                            Console.Write(barber.GetService().ListService()); 
                            barber.CostEarOrBeard();
                            break;
                        case 6:
                            barber.ShaveBeard();                            
                            Console.Write(barber.GetService().ListService());
                            barber.CostEarOrBeard();
                            break;

                    }
                    break;

            }


            Console.WriteLine();
            Console.WriteLine("Thank you for using Baber Service.");
            Console.WriteLine("Have a nice day ^^");


        }
    }
    
}
