using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using startupconnector.Models;

namespace startupconnector.DAL
{
    public class StartupConnectorDB : DbContext
    {
        public StartupConnectorDB() : base("StartupConnectorDB")
        {

        }

        public DbSet<StartupCard> StartupCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}




