using AValidation.Application.Models;
using NUnit.Framework;

namespace AValidation.Tests
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidatePerson_ValidationSuccessful()
        {
            var person = new Person()
            {
                FirstName = "Aleksandar",
                LastName = "ASdasdas"
            };

            var result = person.Validate();

            Assert.IsTrue(result.Valid);
        }
        [Test]
        public void ValidatePerson_ValidationFailed()
        {
            var person = new Person()
            {
                FirstName = "",
                LastName = "ASdasdas"
            };

            var result = person.Validate();

            Assert.IsFalse(result.Valid);
        }
        [Test]
        public void ValidatePersonAllValuesAreNull_ValidationFailed()
        {
            var person = new Person();

            var result = person.Validate();

            Assert.IsFalse(result.Valid);
        }
    }
}