using App.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Abstract CRUD Repository
    /// Author : Catalin Radoiu
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {
        protected AppContext Context;
        protected DbSet<T> DatabaseSet;

        /// <summary>
        /// Constructor used to set the AppContext field and the DbSet
        /// </summary>
        /// <param name="context"></param>
        protected AbstractRepository(AppContext context)
        {
            this.Context = context;

            //Get the databaseSet for the entity of type T
            //There has to be a mapping between the entity of type T and the databasse 
            this.DatabaseSet = context.Set<T>();
        }

        /// <summary>
        /// Persists the entity got as parameter in the database 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity) 
        {
            DatabaseSet.Add(entity);
            Context.SaveChanges();
        }

        /// <summary>
        /// Deletes the entity got as parameter from the database 
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            DatabaseSet.Remove(entity);
            Context.SaveChanges();
        }

        /// <summary>
        /// Returns all the entities from the database 
        /// </summary>
        /// <returns></returns>
        public List<T> All()
        {
            return DatabaseSet.ToList<T>();
        }

        /// <summary>
        /// Returns the entity having the parameter id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Find(int id)
        {
            return DatabaseSet.Find(id);
        }

        /// <summary>
        /// Updates the entity with the same id with the one got as parameter in the database
        /// </summary>
        /// <param name="newEntity"></param>
        public void Update(T newEntity)
        {
            DatabaseSet.Update(newEntity);
            Context.SaveChanges();
        }
    }
}
