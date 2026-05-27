using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibraryew
{
    public class Internet : Service
    {
        public decimal CostPerMb { get; set; }
        public int FreeMb { get; set; }
        public int UsedMb { get; set; }

        public Internet(Subscriber subscriber, decimal costPerMb, int freeMb, int usedMb)
            : base(subscriber)
        {
            CostPerMb = costPerMb;
            FreeMb = freeMb;
            UsedMb = usedMb;
        }

        public override decimal Payment()
        {
            int paidMb = Math.Max(0, UsedMb - FreeMb);
            return paidMb * CostPerMb;
        }
    }
}
