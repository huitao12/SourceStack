using CSharp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class SqlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Suggest> Suggests { get; set; }
        public DbSet<Content> Contents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=18B;Integrated Security=True;Connect Timeout=30;";

            optionsBuilder
                .UseSqlServer(connectionString)
#if DEBUG
                .EnableSensitiveDataLogging()
#endif
                //.UseLoggerFactory(new LoggerFactory(  //无LogTo()方法的版本可以使用
                // new ILoggerProvider[]
                // {
                //     //new DebugLoggerProvider((s, l) => true)
                //     //为了更清晰的获取需要的log信息，通常会对log信息进行过滤
                //     new DebugLoggerProvider((s,l)=> l == LogLevel.Debug)
                // }));
                .LogTo((
                    id, level) => level == Microsoft.Extensions.Logging.LogLevel.Debug,//过滤条件
                    log => Console.WriteLine(log)//如何记录log
                );

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasCheckConstraint("CK_CreateTime", "CreateTime>='2000/1/1'")//自定义约束
                .ToTable("Register")//修改表名
                .Property(m => m.Name).HasMaxLength(256).HasColumnName("UserName")//修改属性类型
                ;
            //modelBuilder.Entity<User>()
            //    .HasOne<Email>(u => u.Email)
            //    .WithOne()
            //    .HasForeignKey<User>(u => u.EmailId);

       

            base.OnModelCreating(modelBuilder);
        }
    }
}
