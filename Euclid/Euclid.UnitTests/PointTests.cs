using Euclid;
namespace Euclid.UnitTests
{
    public class PointTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorTest()
        {
            //arrange and act
            var p = new Point(1, 2);
            //assert - утверждение, что..
            Assert.That(p.X, Is.EqualTo(1));
            Assert.That(p.Y, Is.EqualTo(2));
        }
        [Test]
        public void GetInfo()
        {
            //arrange 
            var p = new Point(1.5, -3.1);
            //act
            var info = p.GetInfo();
            //assert - утверждение, что..
            Assert.That(info, Is.EqualTo("(1,5; -3,1)"));
        }
    }
}