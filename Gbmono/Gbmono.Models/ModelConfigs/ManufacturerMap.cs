using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models.ModelConfigs
{
    public class ManufacturerMap: EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerMap()
        {
            ToTable("Manufacturer"); // table name in db

            HasKey(m => m.ManufacturerId); // primary key
            // HasOptional(m => m.ParentCategory).WithMany().HasForeignKey(m => m.ParentId); // foreign key in same table
        }
    }
}
