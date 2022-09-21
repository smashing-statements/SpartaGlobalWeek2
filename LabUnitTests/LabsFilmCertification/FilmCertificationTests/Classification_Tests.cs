using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using FilmCertificationApp;

namespace FilmCertificationTests
{
    public class Classification_Tests

    {

        [TestCase(-34)]
        [TestCase(-1)]
        public void GivenInvalidAge_ThrowOutOfBoundsException(int age)
        {
            Assert.That(() => CertificationMethods.AvailableClassifications(age), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Age: " + age + " Allowed age 0-150"));
        }

        [TestCase(0, "U, PG & 12A films are available.")]
        [TestCase(5, "U, PG & 12A films are available.")]
        [TestCase(11, "U, PG & 12A films are available.")]

        [TestCase(12, "U, PG, 12A & 12 films are available.")]
        [TestCase(13, "U, PG, 12A & 12 films are available.")]
        [TestCase(14, "U, PG, 12A & 12 films are available.")]

        [TestCase(15, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(16, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12A, 12 & 15 films are available.")]

        [TestCase(18, "All films are available.")]
        public void GivenNumberOfPounds_ReturnNumberOfStones(int age, string classification)
        {
            Assert.That(CertificationMethods.AvailableClassifications(age), Is.EqualTo(classification));
        }
    }
}