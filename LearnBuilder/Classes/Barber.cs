using LearnBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    class Barber : IBarber
    {
        private Service _service = new Service();

        
        public Barber()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._service = new Service();
        }
        
        public void CleanEar()
        {

            this._service.Add("CleanEar");
            
        }

        public void HairCut()
        {
            this._service.Add("HairCut");
            
        }

        public void ShaveBeard()
        {
            this._service.Add("ShaveBeard");
        }
        public Service GetService()
        {
            Service result = this._service;

            this.Reset();

            return result;
        }

        public void Cost()
        {
            Console.WriteLine("Cost: " + this._service.CostFull()+"VND");
            
        }

        public void CostHair()
        {
            Console.WriteLine("Cost: " + this._service.CostHair() + "VND");

        }
        public void CostEarOrBeard()
        {
            Console.WriteLine("Cost: " + this._service.CostEarOrBeard() + "VND");

        }
        public void CostHairEar()
        {
            Console.WriteLine("Cost: " + this._service.CostHairEar() + "VND");

        }
        public void CostHairBeard()
        {
            Console.WriteLine("Cost: " + this._service.CosHairBeard() + "VND");

        }
        public void CostEarBeard()
        {
            Console.WriteLine("Cost: " + this._service.CostEarBeard() + "VND");

        }
    }
}
