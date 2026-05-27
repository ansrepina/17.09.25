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

        [Test]
        public void CompareTo_SortByLastNameThenFirstName_Test()
        {
            var sub1 = new Subscriber("Иванов", "Алексей", "+79123456789");
            var sub2 = new Subscriber("Петров", "Сергей", "+79234567890");
            var sub3 = new Subscriber("Иванов", "Дмитрий", "+79345678901");

            var subscribers = new List<Subscriber> { sub1, sub2, sub3 };
            subscribers.Sort();

            Assert.That(subscribers[0], Is.SameAs(sub1)); 
            Assert.That(subscribers[1], Is.SameAs(sub3)); 
            Assert.That(subscribers[2], Is.SameAs(sub2)); 
        }

        [Test]
        public void PhoneNumberComparer_SortByPhoneNumber_Test()
        {
            var sub1 = new Subscriber("Иванов", "Алексей", "+79123456789");
            var sub2 = new Subscriber("Петров", "Сергей", "+79234567890");
            var sub3 = new Subscriber("Сидоров", "Андрей", "+79012345678");

            var subscribers = new List<Subscriber> { sub1, sub2, sub3 };
            subscribers.Sort(new PhoneNumberComparer());

            Assert.That(subscribers[0], Is.SameAs(sub3)); 
            Assert.That(subscribers[1], Is.SameAs(sub1)); 
            Assert.That(subscribers[2], Is.SameAs(sub2)); 
        }
    }

    [TestFixture]
    public class OperatorTests
    {
        private Operator operatorInstance;
        private Subscriber[] testSubscribers;

        [SetUp]
        public void Setup()
        {
            var sub1 = new Subscriber("Иванов", "Алексей", "+79123456789");
            var sub2 = new Subscriber("Петров", "Сергей", "+79234567890");
            var sub3 = new Subscriber("Сидоров", "Андрей", "+79012345678");
            var sub4 = new Subscriber("Кузнецов", "Михаил", "+79456789012");
            var duplicate = new Subscriber("Иванов", "Алексей", "+79123456789");

            testSubscribers = new Subscriber[] { sub1, sub2, sub3, sub4, duplicate };
            operatorInstance = new Operator(OperatorName.MTS, "1234567890", testSubscribers);
        }


        [Test]
        public void Constructor_PropertiesInitializedCorrectly_Test()
        {
            Assert.That(operatorInstance.Name, Is.EqualTo(OperatorName.MTS));
            Assert.That(operatorInstance.INN, Is.EqualTo("1234567890"));
        }

        [Test]
        public void IEnumerable_IterationWorksCorrectly_Test()
        {
            int count = 0;
            foreach (var subscriber in operatorInstance)
            {
                count++;
            }
            Assert.That(count, Is.EqualTo(operatorInstance.Count));
        }

    }
}
