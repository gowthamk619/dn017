using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DemoWebApiEF.Models
{

    public class StudentContext : DbContext
    {
        public StudentContext() : base("Connection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext, DemoWebApiEF.Migrations.Configuration>("Connection"));
        }
        public DbSet<Student> Students { get; set; }
    }
}
