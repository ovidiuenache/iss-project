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
    public interface IValidator<T>
    {
        /// <summary>
        /// Checks if the entity got as parameter has all the fields valid 
        /// Throws ValdationException if one of the fields is not valid 
        /// </summary>
        /// <param name="entity"></param>
        void validate(T entity);
    }
}
