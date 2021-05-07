//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CSharp
//{
//    class SqlDbContext:DbContext
//    {
//        public DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";

//            optionsBuilder.UseSqlServer(connectionString);

//            base.OnConfiguring(optionsBuilder); 
//        }
//    }
//}
