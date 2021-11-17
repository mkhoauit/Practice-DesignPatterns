using LearnBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    class Client
    {
        private IBarber _barber;

        public IBarber Barber
        {
            set { _barber = value; }
        }

        // The Client can construct several product variations using the same
        // building steps.
        public void NormalService()
        {
            this._barber.HairCut();
            
        }

        public void FullService()
        {
            this._barber.HairCut();
            this._barber.CleanEar();
            this._barber.ShaveBeard();
            this._barber.Cost();
        }
    }
}
