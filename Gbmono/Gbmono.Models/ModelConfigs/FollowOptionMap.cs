using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models.ModelConfigs
{
    public class FollowOptionMap: EntityTypeConfiguration<FollowOption>
    {
        public FollowOptionMap()
        {
            ToTable("FollowOption");
        }
    }
}
