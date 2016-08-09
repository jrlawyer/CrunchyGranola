using CrunchyGranola.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrunchyGranola.DAL
{
    public class CrunchyGranolaContext : DbContext
    {
        public CrunchyGranolaContext() : base("CrunchyGranolaContext")
        {

        }

        public DbSet<Customer>Customers { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Department>Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}