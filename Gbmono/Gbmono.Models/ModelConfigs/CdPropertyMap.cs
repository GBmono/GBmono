using Gbmono.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gbmono.Models.ModelConfigs
{
    public class CdPropertyMap : EntityTypeConfiguration<CdProperty>
    {
        public CdPropertyMap()
        {
            ToTable("CdProperty");
            HasKey(m => m.Id);
        }
    }
}
