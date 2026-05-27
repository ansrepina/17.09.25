using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class Calls : Service
    {
        public decimal CostPerMinute { get; set; }
        public int FreeMinutes { get; set; }
        public int UsedMinutes { get; set; }

        public Calls(Subscriber subscriber, decimal costPerMinute, int freeMinutes, int usedMinutes)
            : base(subscriber)
        {
            CostPerMinute = costPerMinute;
            FreeMinutes = freeMinutes;
            UsedMinutes = usedMinutes;
        }

        public override decimal Payment()
        {
            int paidMinutes = Math.Max(0, UsedMinutes - FreeMinutes);
            return paidMinutes * CostPerMinute;
        }
    }
}
