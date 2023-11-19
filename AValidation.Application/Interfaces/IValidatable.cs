using AValidation.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AValidation.Application.Interfaces
{
    public interface IValidatable<TEntity>
    {
        public AResult Validate(TEntity entity);

    }
}
