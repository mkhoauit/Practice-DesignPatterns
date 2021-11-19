using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChainOfResp.Classes
{
    public class ATM
    {
        private FiveHundredThousandHandler fiveHundredThousandHandler = new FiveHundredThousandHandler();
        private FiftyThousandHandler       fiftyThousandHandler       = new FiftyThousandHandler();
        private TwoHundredThousandHandler  twoHundredThousandHandler  = new TwoHundredThousandHandler();
        private OneHundredThousandHandler  oneHundredThousandHandler  = new OneHundredThousandHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            fiveHundredThousandHandler.nextHandler(twoHundredThousandHandler);
            twoHundredThousandHandler.nextHandler(oneHundredThousandHandler);
            oneHundredThousandHandler.nextHandler(fiftyThousandHandler);
            
        }
        public void withdraw(long requestedAmount)
        {
            fiveHundredThousandHandler.checkDispatchRs(requestedAmount);
        }
    }
}
