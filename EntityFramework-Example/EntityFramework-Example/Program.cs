using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogDbContext db = new BlogDbContext();

             db.Articles.Add(new Article()
             {
                 Title = "Statiiika",
                 Content = "Nqkakwo sudarjanie"
             });
            
            //// db.Articles.Add(new Article()
            //// {
            ////     Title = "Statiiika s authir",
            ////     Content = "Nqkakwo sudarjanie",
            ////     Owner = new User()
            ////     {
            ////         UserName = "Pesho",
            ////         PasswordHash = "asd123123asd"
            ////     }
            //// });
            ////
            // db.SaveChanges();

          // foreach (var a in db.Articles)
          // {
          //     Console.WriteLine(a.Title + "author:" + a.Owner?.UserName);
          // }
        }
    }
}
