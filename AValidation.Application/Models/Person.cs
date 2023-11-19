using AValidation.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AValidation.Application.Models
{
    public class Person : IValidatable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AResult Validate()
        {
            var result = new AResult();

            if (string.IsNullOrEmpty(FirstName))
            {
                result.ValidationFailed("First name must not be null or empty.");
            }

            if (string.IsNullOrEmpty(LastName))
            {
                result.ValidationFailed("Last name must not be null or empty.");
            }

            result.ValidationSuccessful();

            return result;
        }
    }
}
