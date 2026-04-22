using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MobileLibraryew;
using NUnit.Framework.Interfaces;

namespace MobileLibraryew.UnitTests
{
    public class ServiceTests
    {
        [Test]
        public void Calls_Payment_CalculatesCorrectly()
        {
            var subscriber = new Subscriber("Иван", "Иванов", "123456789", "CN123");
            var calls = new Calls(subscriber, 2m, 100, 150);
            Assert.AreEqual(100m, calls.Payment()); // (150-100)*2 = 100
        }

        [Test]
        public void Calls_Payment_NoCharge_IfWithinFreeLimit()
        {
            var subscriber = new Subscriber("Иван", "Иванов", "123456789", "CN123");
            var calls = new Calls(subscriber, 2m, 100, 80);
            Assert.AreEqual(0m, calls.Payment()); // 80 < 100, оплата не взимается
        }

        [Test]
        public void TextMessage_Payment_CalculatesCorrectly()
        {
            var subscriber = new Subscriber("Петр", "Петров", "987654321", "CN456");
            var sms = new TextMessage(subscriber, 1m, 50, 70);
            Assert.AreEqual(20m, sms.Payment()); // (70-50)*1 = 20
        }

        [Test]
        public void Internet_Payment_CalculatesCorrectly()
        {
            var subscriber = new Subscriber("Анна", "Смирнова", "555123456", "CN789");
            var internet = new Internet(subscriber, 0.5m, 1024, 2048);
            Assert.AreEqual(512m, internet.Payment()); // (2048-1024)*0.5 = 512
        }
    }
}