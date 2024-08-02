using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibaryApplication.Orm.Entity;

namespace LibaryApplication.Orm.Context
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=Libary;uid=sa;pwd=1453";
        }
        // Migration steps
        // enable-migrations
        // add-migration 'a'
        // update-database
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Kullanıcı> Kullanıcıs { get; set; }
    }
}
