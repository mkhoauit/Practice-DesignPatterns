using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChainOfResp.Classes
{
    public class FiftyThousandHandler : Handler
    {
        public override void checkDispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 50000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine($" {numberofNotesToBeDispatched} Fifty Thousand VND are drawed ");
                }
                else
                {
                    Console.WriteLine($"Only {numberofNotesToBeDispatched} Fifty Thousand VND is drawed");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 50000;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.checkDispatchRs(pendingAmountToBeProcessed);
            }
        }
    }
}
