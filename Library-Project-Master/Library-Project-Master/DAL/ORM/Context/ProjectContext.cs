using Library_Project_Master.DAL.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project_Master.DAL.ORM.Context
{
    public class ProjectContext:DbContext 
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"server=.;database = Library-Project-Master; Integrated Security=True";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Concrete.AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
