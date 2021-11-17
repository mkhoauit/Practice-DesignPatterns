using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    class Service
    {
        private List<object> _service = new List<object>();
        private int hairCutCost = 25000;
        private int cleanEarCost = 15000;
        private int shaveBeardCost = 15000;
        public void Add(string service)
        {
            this._service.Add(service);
           
        }
        public int CostFull() 
        {
            int sum = 0;
            sum = sum + hairCutCost + shaveBeardCost + cleanEarCost;
            return sum;      
        }
        public int CostHairEar() 
        {
            int sum = 0;
            sum = sum + hairCutCost + cleanEarCost;
            return sum;
        }
        public int CosHairBeard()
        {
            int sum = 0;
            sum = sum + hairCutCost + shaveBeardCost;
            return sum;
        }
        public int CostEarBeard()
        {
            int sum = 0;
            sum = sum +cleanEarCost + shaveBeardCost;
            return sum;
        }
        public int CostHair()
        {
            int sum = 0;
            sum = sum + hairCutCost;
            return sum;
        }
        public int CostEarOrBeard()
        {
            int sum = 0;
            sum = sum + shaveBeardCost;
            return sum;
        }
        public string ListService()
        {
            string str = string.Empty;

            for (int i = 0; i < this._service.Count; i++)
            {        
                
                    str += this._service[i] + " \n ";
              
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Service: \n " + str + "\n";
        }
    }
}
