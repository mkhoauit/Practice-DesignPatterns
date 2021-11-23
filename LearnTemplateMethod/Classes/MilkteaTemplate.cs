using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTemplateMethod.Classes
{
    public abstract class MilkteaTemplate
    {
        public void PrepareMilktea()
        {
            BoilWater();
            AddTea();
            AddMilk();
            AddSugar();
            Console.WriteLine();
            AddFlavor();
            Console.WriteLine($"Your order <<{this.GetType().Name} with {this.Flavor()}>> is Ready.");
            Console.WriteLine($"Total: {this.Total()} VND.");

        }
        protected abstract void BoilWater();
        protected abstract void AddTea();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddFlavor();
        protected abstract string Flavor();
        protected abstract int Total();
       
    }
}
