using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibraryew
{
    public class PhoneNumberComparer : IComparer<Subscriber>
    {
        public int Compare(Subscriber x, Subscriber y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            string xNumber = x.PhoneNumber.Replace("+", "").Replace("7", "", (StringComparison)1);
            string yNumber = y.PhoneNumber.Replace("+", "").Replace("7", "", (StringComparison)1);

            return string.Compare(xNumber, yNumber);
        }
    }
}
