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
            Assert.That(() => CertificationMethods.GetClassification(age), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("Allowed range 0-150"));
        }

        [TestCase(1, "U, PG, 12A")]
        [TestCase(12, "U, PG, 12")]
        [TestCase(15, "U, PG, 12, 15")]
        [TestCase(18, "U, PG, 12, 15, 18")]
        public void GivenNumberOfPounds_ReturnNumberOfStones(int age, string classification)
        {
            Assert.That(CertificationMethods.GetClassification(age), Is.EqualTo(classification));
        }
    }
}