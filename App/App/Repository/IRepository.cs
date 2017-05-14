using System.Collections.Generic;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Generic CRUD Repository interface
    /// Author : Catalin Radoiu
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Adds the entity
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Deletes the entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Updates the entity 
        /// </summary>
        /// <param name="newEntity"></param>
        void Update(T newEntity);

        /// <summary>
        /// Returns the entity with the id got as parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Find(int id);


        /// <summary>
        /// Returns a list with containing all the entities
        /// </summary>
        /// <returns></returns>
        List<T> All();
    }
}
