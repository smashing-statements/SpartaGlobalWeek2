using UnitTestLessonApp;

namespace UnitTestLessonTests
{
    public class Tests
    {
        [Test]
        public void GivenATimeOf21_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 21;
            string output;
            string expectedOutput = "Good evening!";

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }
} 