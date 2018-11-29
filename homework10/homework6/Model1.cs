
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
namespace homework6
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("OrderDataBase")
        {
        }
        public DbSet<Order> Order { get; set; }
    }
}