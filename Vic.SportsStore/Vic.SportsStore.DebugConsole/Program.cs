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
                var product = new Product() { };



                ctx.Products.Add(product);
                ctx.SaveChanges();
            }



        }
    }
}
