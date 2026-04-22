using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MobileLibraryew;

namespace MobileLibraryew.UnitTests
{
    public class SubscriberTests
    {
        [Test]
        public void TestConstructor()
        {

            var sub = new Subscriber("Элла", "Ивановна", "123", "55");
            Assert.AreEqual("Элла", sub.Name);
            Assert.AreEqual("55", sub.ContractNumber);
        }

        [Test]
        public void TestGetInfo()
        {
            var sub = new Subscriber("Элла", "Ивановна", "900", "Ä-1");
            string[] info = sub.GetInfo();

            Assert.AreEqual(2, info.Length);

            Assert.IsTrue(info[0].Contains("Ивановна"));
        }
    }
}
