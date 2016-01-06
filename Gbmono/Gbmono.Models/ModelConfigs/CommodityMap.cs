using Gbmono.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models.ModelConfigs
{
    public class CommodityMap:EntityTypeConfiguration<Commodity>
    {
        public CommodityMap()
        {
            ToTable("Commodity");

            HasKey(m => m.Id);
        }

    }
}
