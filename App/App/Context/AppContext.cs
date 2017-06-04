using App.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Context
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Proposal> Proposals { get; set; }

        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(x => new {x.UserId, x.RoleId});
            modelBuilder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<ConferenceUser>()
                .HasKey(x => new {x.ConferenceId, x.UserId});
            modelBuilder.Entity<ConferenceUser>()
                .HasOne(x => x.Conference)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.ConferenceId);
            modelBuilder.Entity<ConferenceUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.ConferenceUsers)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Topic>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=Ramona;Initial Catalog=iss;Integrated Security=True");
        }
    }
}
