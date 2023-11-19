using AValidation.Application.BusinessLogic.Validation;
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
            var validator = new PersonValidation();
            var person = new Person()
            {
                FirstName = "Aleksandar",
                LastName = "ASdasdas"
            };

            var result = validator.Validate(person);

            Assert.IsTrue(result.Valid);
        }
        [Test]
        public void ValidatePerson_ValidationFailed()
        {
            var validator = new PersonValidation();
            var person = new Person()
            {
                FirstName = "",
                LastName = "ASdasdas"
            };

            var result = validator.Validate(person);

            Assert.IsFalse(result.Valid);
        }
        [Test]
        public void ValidatePersonAllValuesAreNull_ValidationFailed()
        {
            var validator = new PersonValidation();
            var person = new Person();

            var result = validator.Validate(person);

            Assert.IsFalse(result.Valid);
        }
    }
}