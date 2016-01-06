using Gbmono.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gbmono.Models.ModelConfigs
{
    public class CdInstancePropertyMap : EntityTypeConfiguration<CdInstanceProperty>
    {
        public CdInstancePropertyMap()
        {
            ToTable("CdInstanceProperty");

            HasKey(m =>new { m.CdInstanceId, m.CdPropertyId }); 
        }

    }
}
