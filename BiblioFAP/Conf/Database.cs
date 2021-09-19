using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiblioFAP.Models;

namespace BiblioFAP.Conf
{
    public class Database: DbContext
    {
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Loan> Loan { get; set; }

        public Database(DbContextOptions<Database> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessLevel>().HasData(
                new AccessLevel
                {
                    Id = 1,
                    Name = "Admin"
                },
                new AccessLevel
                {
                    Id = 2,
                    Name = "Official"
                },
                new AccessLevel
                {
                    Id = 3,
                    Name = "User"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Master-Admin",
                    Email = "admin@hotmail.com",
                    Password = "adminadmin",
                    AccessLevelId = 1
                }
            );
        }
    }
}
