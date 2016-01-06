using System;
using System.Data.Entity.ModelConfiguration;

namespace Gbmono.Models.ModelConfigs
{
    /// <summary>
    /// entity map class
    /// map class into actual table in db with specific table name, primary key, foreign key....
    /// </summary>
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category"); // table name in db

            HasKey(m => m.Id); // primary key
        }
    }
}
