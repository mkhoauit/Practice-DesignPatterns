using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChainOfResp.Classes
{
    public class TwoHundredThousandHandler : Handler
    {
        public override void checkDispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine($" {numberofNotesToBeDispatched} Two Hundred Thousand VND are drawed ");
                }
                else
                {
                    Console.WriteLine($"Only {numberofNotesToBeDispatched} Two Hundred Thousand VND is drawed");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 200000;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.checkDispatchRs(pendingAmountToBeProcessed);
            }
        }
    }
}
