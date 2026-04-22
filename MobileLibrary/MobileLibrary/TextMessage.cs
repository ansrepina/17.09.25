using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class TextMessage : Service
    {
        public decimal CostPerMessage { get; set; }
        public int FreeMessages { get; set; }
        public int SentMessages { get; set; }

        public TextMessage(Subscriber subscriber, decimal costPerMessage, int freeMessages, int sentMessages)
            : base(subscriber)
        {
            CostPerMessage = costPerMessage;
            FreeMessages = freeMessages;
            SentMessages = sentMessages;
        }

        public override decimal Payment()
        {
            int paidMessages = Math.Max(0, SentMessages - FreeMessages);
            return paidMessages * CostPerMessage;
        }
    }
}
