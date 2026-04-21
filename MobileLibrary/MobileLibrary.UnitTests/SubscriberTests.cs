using NUnit.Framework;
using MobileLibrary;

namespace MobileLibrary.UnitTests
{
    public class SubscriberTests
    {
        [Test]
        public void TestConstructor()
        {

            var sub = new Subscriber("Иван", "Иванов", "123", "55");
            Assert.AreEqual("Иван", sub.Name);
            Assert.AreEqual("55", sub.ContractNumber);
        }

        [Test]
        public void TestGetInfo()
        {
            var sub = new Subscriber("Петр", "Петров", "900", "Д-1");
            string[] info = sub.GetInfo();

            Assert.AreEqual(2, info.Length);

            Assert.IsTrue(info[0].Contains("Петров"));
        }
    }
}