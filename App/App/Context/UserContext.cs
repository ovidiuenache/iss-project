using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using App.Entity;

namespace App.Context
{
    /// <summary>
    /// 
    /// Class UserContext
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-MB4097H\SQLEXPRESS;Initial Catalog=iss;Integrated Security=True");
        }
    }
}
