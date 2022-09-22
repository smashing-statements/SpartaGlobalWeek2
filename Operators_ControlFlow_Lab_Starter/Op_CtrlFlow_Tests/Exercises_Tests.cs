using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(2, 2, false)]
        [TestCase(2, 1, true)]
        [TestCase(13, 7, false)]
        public void Does_Num1FitIntoNum2Neatly(int num1, int num2, bool expectedOutcome)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [Test]
        public void WhenListIsEmpty_ExceptionThrown()
        {
            Assert.That(() => Exercises.Average(new List<int>()), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Please submit a non-empty array"));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(-20)]
        public void GivenInvalidAge_ThrowException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Age must be at least 0"));
        }

        [TestCase(100, "Pass with Distinction")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(59, "Pass")]
        [TestCase(40, "Pass")]
        [TestCase(39, "Fail")]
        [TestCase(0, "Fail")]
        public void GivenScore_ReturnGrade(int score, string expectedGrade)
        {
            var result = Exercises.Grade(score);
            Assert.That(result, Is.EqualTo(expectedGrade));
        }

        [TestCase(-101)]
        [TestCase(30000)]
        public void WhenTheScoreIsInvalid_Grade_ThrowsAnArgumentOutOfRangeException(int score)
        {
            Assert.That(() => Exercises.Grade(score), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Allowed range 0-100"));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void GivenAlertLevel_ReturnMaxAttendees(int covidLevel, int expectedMaxAttendees)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(result, Is.EqualTo(expectedMaxAttendees));
        }

        [TestCase(-1)]
        [TestCase(5)]
        public void GivenInvalidAlertLevel_ThrowsAnArgumentOutOfRangeException(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Allowed range 0-4"));
        }

    }
}
