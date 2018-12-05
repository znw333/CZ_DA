using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CZ_DA.DBContext
{
    public class EntityFramework : DbContext
    {
        public EntityFramework()
            : base(Config.ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Housing>();
            modelBuilder.Entity<Housing>().Property(t => t.MeasureArea).HasPrecision(18, 3);
            modelBuilder.Entity<Housing>().Property(t => t.TotalPrice).HasPrecision(18, 3);
            modelBuilder.Entity<Housing>().Property(t => t.UnitPrice).HasPrecision(18, 3);

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();//解决表名会自动加S问题
            modelBuilder.Conventions.Remove<System.Data.Entity.Infrastructure.IncludeMetadataConvention>();     //不创建EdmMetadata表  //防止黑幕交易 要不然每次都要访问 EdmMetadata这个表

            base.OnModelCreating(modelBuilder);
        }

    }
}
