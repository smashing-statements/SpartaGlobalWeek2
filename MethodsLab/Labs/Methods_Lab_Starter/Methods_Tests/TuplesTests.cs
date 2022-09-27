using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(0, 0, 0, 0.0)]
        [TestCase(2, 4, 8, 1.41)]
        [TestCase(20, 400, 8000, 4.47)]
        public void GivenParams_Integers_ReturnsCorrectTuple(int input, int square, int cube, double root)
        {
            var output = Methods.PowersRoot(input);
            Assert.That(output.Item1, Is.EqualTo(square));
            Assert.That(output.Item2, Is.EqualTo(cube));
            Assert.That(output.Item3, Is.EqualTo(root));
        }

        [Test]
        public void GivenNegativeInteger_ThrowsOutOfBoundsException()
        {
            Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("integer must not be negative"));
        }
    }
}