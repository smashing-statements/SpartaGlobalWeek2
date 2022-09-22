using Microsoft.VisualStudio.TestPlatform.TestHost;
using ExceptionsApp;

namespace ExceptionsDataTypesTests
{
    public class ExceptionsTests
    {
        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenTheMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exceptions.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Allowed range 0-100"));
        }

        [TestCase(101)]
        [TestCase(30000)]
        public void WhenTheMarkIsMoreThanOneHundred_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exceptions.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Allowed range 0-100"));
        }

    }
}