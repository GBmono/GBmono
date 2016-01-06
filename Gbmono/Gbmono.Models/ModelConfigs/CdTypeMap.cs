using Gbmono.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gbmono.Models.ModelConfigs
{
    public class CdTypeMap : EntityTypeConfiguration<CdType>
    {
        public CdTypeMap()
        {
            ToTable("CdType");
            HasKey(m => m.Id);
        }

    }
}
