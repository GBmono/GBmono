using Gbmono.Models.Models;
using System.Data.Entity.ModelConfiguration;


namespace Gbmono.Models.ModelConfigs
{
    public class CdInstanceMap : EntityTypeConfiguration<CdInstance>
    {
        public CdInstanceMap()
        {
            ToTable("CdInstance");

            HasKey(m => m.Id); // primary key
        }

    }
}
