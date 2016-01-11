using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models.ModelConfigs
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product"); // table name in db

            HasKey(m => m.ProductId); // primary key
            //HasMany(m => m.WebShops).WithOptional().HasForeignKey(m => m.WebShopId);

            // HasOptional(m => m.ParentCategory).WithMany().HasForeignKey(m => m.ParentId); // foreign key in same table
        }
    }
}
