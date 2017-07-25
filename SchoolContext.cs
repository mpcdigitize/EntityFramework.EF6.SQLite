using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntityFramework.EF6.SQLite
{
    public class SchoolContext : DbContext
    {
       

        public SchoolContext() : base("name=LocalDbConnection")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext,
            Migrations.Configuration>("LocalDbConnection"));
        }

      

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolZone> SchoolZones { get; set; }

    }
}
