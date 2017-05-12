using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Generic CRUD Repository interface
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRepository<T>
    {
        /// <summary>
        /// Adds the entity
        /// </summary>
        /// <param name="entity"></param>
        void add(T entity);

        /// <summary>
        /// Deletes the entity
        /// </summary>
        /// <param name="entity"></param>
        void delete(T entity);

        /// <summary>
        /// Updates the entity 
        /// </summary>
        /// <param name="newEntity"></param>
        void update(T newEntity);

        /// <summary>
        /// Returns the entity with the id got as parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T findOne(int id);

        /// <summary>
        /// Returns a list with containing all the entities
        /// </summary>
        /// <returns></returns>
        List<T> findAll();
    }
}
