using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Sample
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("19B")
        {
            Database.Log = Console.WriteLine;
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("Users");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
