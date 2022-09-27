using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {

        [Test]
        public void GivenRng_ReturnBetweenOneAndTwelve(Random rng)
        {
            Assert.That(Methods.RollDice(rng), (Is.LessThanOrEqualTo(12) & Is.AtLeast(1)));
        }

    }
}
