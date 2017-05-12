using App.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Abstract CRUD Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {
        protected AppContext context;
        protected DbSet<T> databaseSet;

        /// <summary>
        /// Constructor used to set the AppContext field and the DbSet
        /// Only called in the repositories that inherit the abstract repository
        /// </summary>
        /// <param name="context"></param>
        public AbstractRepository(AppContext context)
        {
            this.context = context;
            this.databaseSet = context.Set<T>();
        }

        /// <summary>
        /// Persists the entity got as parameter in the database 
        /// </summary>
        /// <param name="entity"></param>
        public void add(T entity) 
        {
            databaseSet.Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes the entity got as parameter from the database 
        /// </summary>
        /// <param name="entity"></param>
        public void delete(T entity)
        {
            databaseSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Returns all the entities from the database 
        /// </summary>
        /// <returns></returns>
        public List<T> findAll()
        {
            return databaseSet.ToList<T>();
        }

        /// <summary>
        /// Returns the entity having the parameter id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T findOne(int id)
        {
            return databaseSet.Find(id);
        }

        /// <summary>
        /// Updates the entity with the same id with the one got as parameter in the database
        /// </summary>
        /// <param name="newEntity"></param>
        public void update(T newEntity)
        {
            databaseSet.Update(newEntity);
            context.SaveChanges();
        }
    }
}
