using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    interface IValidator<T>
    {
        void validate(T entity);
    }
}
