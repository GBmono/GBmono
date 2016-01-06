
using Gbmono.Models.ModelConfigs;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Gbmono.Models.DataContext
{
    public class GbmonoSqlContext: DbContext
    {
        public GbmonoSqlContext() : base("SqlConnection") // connection string name
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove default table name convention
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // add category map
            modelBuilder.Configurations.Add(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
