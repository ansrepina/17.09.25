using Euclid;

namespace Euclid.UnitTests
{
    [TestFixture]
    public class SegmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var a = new Point(1.5, 2.3);
            var b = new Point(-1.7, 4.8);

            var s = new Segment(a, b);

            Assert.That(s.A, Is.SameAs(a));
            Assert.That(s.B, Is.SameAs(b));

            //var word1 = "aaa";
            //var word2 = "aaa";

            //Assert.That(word1, Is.EqualTo(word2));
            //Assert.That(word1, Is.SameAs(word2));
        }

        [Test]
        public void GetInfoTest()
        {
            var s = GetTestSegment(1, 2, 3, 4);
            Assert.That(s.GetInfo(), Is.EqualTo(
                "отрезок с концами в точках {1; 2} и {3; 4}"));
        }

        private Segment GetTestSegment(
            double aX, double aY, double bX, double bY) =>
            new Segment(new Point(aX, aY), new Point(bX, bY));
        
    }
}
