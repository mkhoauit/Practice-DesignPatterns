using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTemplateMethod.Classes
{
    class GreenTea : MilkteaTemplate
    {
        private int greenTea = 24000;
        private int flavor = 0;
        private string checkFlavor;
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddTea()
        {
            Console.WriteLine("Green Tea Added");
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
            Console.WriteLine("3.Cheese");
            Console.WriteLine("4.Pearl.");
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
                    int cheese = 7000;
                    this.flavor = this.flavor + cheese;
                    this.checkFlavor = "Cheese";
                    break;
                case 4:
                    int bubble = 5000;
                    this.flavor = this.flavor + bubble;
                    this.checkFlavor = "Pearl";
                    break;
                default:
                    this.flavor = 0;
                    this.checkFlavor = "No topping";
                    break;

            }
        }

        protected override int Total()
        {
            return this.greenTea + this.flavor;
        }
        protected override string Flavor()
        {
            return this.checkFlavor;
        }
    }
    
}
