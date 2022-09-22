using UnitTestLessonApp;

namespace UnitTestLessonTests
{
    public class Tests
    {

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(12)]
        public void GivenATime_GetGreeting_ReturnsGoodMorning(int time)
        {
            //Arrange
            //int time = 11;
            string output;
            string expectedOutput = "Good morning!";

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        //Partition test for 19-24
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

        //Lower bound test for the 19-24 partition
        [Test]
        public void GivenATimeOf19_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 19;
            string output;
            string expectedOutput = "Good evening!";

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        //upper bound of 0-4am partition
        [Test]
        public void GivenATimeOf4_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 4;
            string output;
            string expectedOutput = "Good evening!";

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

        //Partition test for 0-4 
        [Test]
        public void GivenATimeOf2_GetGreeting_ReturnsGoodEvening()
        {
            //Arrange
            int time = 2;
            string output;
            string expectedOutput = "Good evening!";

            //Act
            output = Program.GetGreeting(time);

            //Assert
            Assert.That(output, Is.EqualTo(expectedOutput));
        }

    }
} 