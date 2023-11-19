using AValidation.Application.Interfaces;
using AValidation.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AValidation.Application.BusinessLogic.Validation
{
    public class PersonValidation : IValidatable<Person>
    {
        public AResult Validate(Person entity)
        {
            var result = new AResult();

            if (string.IsNullOrEmpty(entity.FirstName))
                result.ValidationFailed("First name must not be null or empty.");

            if(string.IsNullOrEmpty(entity.LastName))
                result.ValidationFailed("Last name must not be null or empty.");

            result.ValidationSuccessfull();
            return result;
        }
    }
}
