using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiblioFAP.Conf
{
    public class Database: DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options) { }
    }
}
