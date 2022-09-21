using NUnit.Framework;
using OperatorsAndControlFlowApp;

namespace OperatorsAndControlFlowTest
{
    public class StonesTest
    {

        [TestCase(156, 11)]
        [TestCase(86, 6)]
        [TestCase(1, 0)]
        public void GivenNumberOfPounds_ReturnNumberOfStones(int input, int output)
        {
            Assert.That(StonesMethods.GetStones(input), Is.EqualTo(output));
        }

        [TestCase(329, 7)]
        [TestCase(35, 7)]
        [TestCase(14, 0)]
        public void GivenNumberOfPounds_ReturnRemainderOfPoundsAfterStones(int input, int output)
        {
            Assert.That(StonesMethods.GetPounds(input), Is.EqualTo(output));
        }
    }
}