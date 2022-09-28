using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {

        [Test]
        public void GivenRng_ReturnBetweenOneAndTwelve()
        {
            /*
            //ARRANGE
            Random rng = new Random();

            //ACT

            //ASSERT
            Assert.That(Methods.RollDice(rng), Is.LessThanOrEqualTo(12) & Is.AtLeast(1));
            */

            //this is the overload
            var rand = new Random(6);
            var answer = Methods.RollDice(rand);
            Assert.That(answer, Is.InRange(1, 12));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void GivenSeed_DiceReturns_ConsistentSeededValues(int seed)
        {
            Random seededRand = new Random(seed);
            int randomValue1 = seededRand.Next(1, 7);
            int randomValue2 = seededRand.Next(1, 7);
            int expected = randomValue1 + randomValue2;

            //must create new rand because we have used Next
            //on the first already
            Random s2 = new Random(seed);
            int result = Methods.RollDice(s2);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
