using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gbmono.Models;

namespace Gbmono.Models.ModelConfigs
{
    public class RetailerMap : EntityTypeConfiguration<Retailer>
    {
        public RetailerMap()
        {
            ToTable("Retailer"); // table name in db

            HasKey(m => m.RetailerId); // primary key
            HasMany(m => m.Shops).WithRequired(m=>m.Retailer).HasForeignKey(m => m.RetailderId); // foreign key in same table
        }

    }
}
