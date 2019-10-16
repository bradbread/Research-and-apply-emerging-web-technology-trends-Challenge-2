using NUnit.Framework;
using Shapes;
using System;

namespace Tests
{
    //seperate these into seperate files and one test per method
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
        Equilateral eq1 { get; set; }
        RightAngle ra1 { get; set; }
        Circle cir1 { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTests(double sideLength, double expectedA, double expectedP)
        {
            sq1 = new Square(sideLength);

            Assert.AreEqual(expectedA, sq1.GetArea());
            Assert.AreEqual(expectedP, sq1.GetPerimeter());

        }

        [Test]
        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTests(double sideLength1, double sideLength2, double expectedA, double expectedP)
        {
            rec1 = new Rectangle(sideLength1, sideLength2);

            Assert.AreEqual(expectedA, rec1.GetArea());
            Assert.AreEqual(expectedP, rec1.GetPerimeter());

        }

        [Test]
        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTests(double sideLength1, double expectedA, double expectedP)
        {
            eq1 = new Equilateral(sideLength1);

            Assert.AreEqual(expectedA, Math.Round(eq1.GetArea(), 2));
            Assert.AreEqual(expectedP, Math.Round(eq1.GetPerimeter(), 2));

        }

        [Test]
        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTests(double sideLength1, double sideLength2, double expectedA, double expectedP)
        {
            ra1 = new RightAngle(sideLength1, sideLength2);

            Assert.AreEqual(expectedA, Math.Round(ra1.GetArea(), 2));
            Assert.AreEqual(expectedP, Math.Round(ra1.GetPerimeter(), 2));

        }

        [Test]
        [TestCase(5, 78.55, 31.42)]
        [TestCase(15, 706.95, 94.26)]
        [TestCase(7, 153.96, 43.99)]
        public void CircleTests(double sideLength1, double expectedA, double expectedP)
        {
            cir1 = new Circle();
            cir1.Radius = sideLength1;

            Assert.AreEqual((decimal)expectedA, (decimal)Math.Round(cir1.GetArea(), 2));
            Assert.AreEqual((decimal)expectedP, (decimal)Math.Round(cir1.GetPerimeter(), 2));

        }
    }
}