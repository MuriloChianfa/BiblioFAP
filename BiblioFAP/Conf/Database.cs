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
        public DbSet<User> User { get; set; }
        public DbSet<Loan> Loan { get; set; }

        public Database(DbContextOptions<Database> options) : base(options) { }
    }
}
