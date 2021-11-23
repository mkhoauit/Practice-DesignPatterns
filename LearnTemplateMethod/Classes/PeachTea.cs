using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTemplateMethod.Classes
{
    class PeachTea : MilkteaTemplate
    {
        private int peachTea = 25000;
        private int flavor = 0;
        private string checkFlavor;
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddTea()
        {
            Console.WriteLine("Peach Tea Added");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }

        protected override void AddFlavor()
        {
            Console.WriteLine("--Choose your flavor(topping)[input number]--");
            Console.WriteLine("1.Flan");
            Console.WriteLine("2.Jelly");
            Console.WriteLine("3.Quarter of Orange");
            Console.WriteLine("4.Quarter of Peach");
            Console.WriteLine("5.No topping.");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    int flan = 5000;
                    this.flavor = this.flavor + flan;
                    this.checkFlavor = "Flan";
                    break;
                case 2:
                    int jelly = 6000;
                    this.flavor = this.flavor + jelly;
                    this.checkFlavor = "Jelly";
                    break;
                case 3:
                    int orange = 4000;
                    this.flavor = this.flavor + orange;
                    this.checkFlavor = "Quarter of Orange";
                    break;
                case 4:
                    int peach = 8000;
                    this.flavor = this.flavor + peach;
                    this.checkFlavor = "Quarter of Peach";
                    break;
                default:
                    this.flavor = 0;
                    this.checkFlavor = "No topping";
                    break;

            }
        }

        protected override int Total()
        {
            return this.peachTea + this.flavor;
        }
        protected override string Flavor()
        {
            return this.checkFlavor;
        }
    }
   
}
