using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gbmono.Models;

namespace Gbmono.Models.ModelConfigs
{
    public class RetailShopMap : EntityTypeConfiguration<RetailShop>
    {
        public RetailShopMap()
        {
            ToTable("RetailerShop"); // table name in db

            HasKey(m => m.RetailShopId); // primary key
            // HasOptional(m => m.ParentCategory).WithMany().HasForeignKey(m => m.ParentId); // foreign key in same table
        }
    }
}
