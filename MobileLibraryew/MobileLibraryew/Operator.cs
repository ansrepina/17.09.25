using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibraryew
{
    public class Operator : IEnumerable<Subscriber>
    {
        public OperatorName Name { get; set; }
        public string INN { get; set; }
        private List<Subscriber> subscribers;
        public int Count => subscribers.Count;

        public Operator(OperatorName name, string inn, IEnumerable<Subscriber> initialSubscribers)
        {
            Name = name;
            INN = inn;
            subscribers = new List<Subscriber>();

            foreach (var subscriber in initialSubscribers)
            {
                if (!subscribers.Contains(subscriber))
                    subscribers.Add(subscriber);
            }
        }

        public IEnumerator<Subscriber> GetEnumerator()
        {
            return subscribers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}