using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    /// <summary>
    /// 
    /// Generic validator interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IValidator<T>
    {
        void validate(T entity);
    }
}
