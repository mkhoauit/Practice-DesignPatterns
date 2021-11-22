using LearnStrategy.Classes;
using System;

namespace LearnStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Travel Type : GrabBike or GrabCar or Bus or Train.");
            string travelType = Console.ReadLine().checkType();
            Console.WriteLine("Travel type is : " + travelType);

            TravelContext travelContext = new TravelContext();
            
            if ("Bus".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                travelContext.SetTravelStrategy(new BusStrategy());
               
            }
            else if ("Train".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                travelContext.SetTravelStrategy(new TrainStrategy());
            }
            else if ("GrabBike".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                travelContext.SetTravelStrategy(new GrabBikeStrategy());
            }
            else if ("GrabCar".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                travelContext.SetTravelStrategy(new GrabCarStrategy());
            }

            travelContext.gotoMall();
            Console.WriteLine();
            Console.WriteLine("Do you want to buy a round-trip ticket?");
            string anwser = Console.ReadLine().checkAnwser();
            if (anwser == "yes")
            {
                Console.WriteLine($"Round-trip ticket: {travelContext.Ticket()} VND");
                Console.WriteLine($"Thank you. Here is your round-trip {travelType} ticket.");
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using our Travel ^^");
        }
    }
    public static class Extensions
    {

        public static string checkType(this string strType)
        {

            if (strType.ToLower() =="bus")
            {

                return "Bus";
            }
            else if(strType.ToLower() == "train")
            {

                return "Train";
            }
            else if (strType.ToLower() == "grabbike")
            {

                return "GrabBike";
            }
            else if (strType.ToLower() == "grabcar")
            {

                return "GrabCar";
            }
            else
            {
                Console.WriteLine( "Please input type of travel correctly!");
                return null;
            }

        }
        public static string checkAnwser(this string strAn)
        {

            if (strAn.ToLower() == "yes" || strAn.ToLower()== "y" )
            {

                return "yes";
            }
            else if (strAn.ToLower() == "no" || strAn.ToLower() == "n")
            {

                return "no";
            }

            else
            {
                Console.WriteLine("Please input your anwser correctly!");
                return null;
            }

        }
    }
}
