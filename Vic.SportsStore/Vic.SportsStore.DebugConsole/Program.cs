using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");

            using (var ctx = new EFDbContext())
            {
                //for (int i = 0; i < 7; i++)
                //{
                //    var product = new Product()
                //    {
                //        Name = $"Football{i}",
                //        Price = i + 12,
                //        Description = $"This is football {i }",
                //          Category="Football",
                //    };

                //    ctx.Products.Add(product);

                //}

                var product = new Product()
                {
                    Name = "c",
                    Price = 39,
                    Description = "cb",
                    Category = "c"
                };

                ctx.Products.Add(product);

                ctx.SaveChanges();
            }

            Console.WriteLine("End");
            Console.ReadLine();


        }
    }
}
