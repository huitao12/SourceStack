using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            context.Users.Add(new User { Name = "lx", Password = "1111" });
            context.SaveChanges();
        }
    }
}
