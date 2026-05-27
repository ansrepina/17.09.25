using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public abstract class Service
    {
        public Subscriber Subscriber { get; set; }

        public Service(Subscriber subscriber)
        {
            Subscriber = subscriber;
        }

        public abstract decimal Payment();
    }
}
