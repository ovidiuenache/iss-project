using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Context
{
    /// <summary>
    /// Class ConferenceContext
    /// 
    /// Author: Claudiu Nicola
    /// </summary>
    public class ConferenceContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-MB4097H\SQLEXPRESS;Initial Catalog=iss;Integrated Security=True");
        }
    }
}
