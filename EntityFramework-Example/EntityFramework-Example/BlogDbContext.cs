using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Example
{
    class BlogDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }

    public class Article
    {
        public int id { get; set; }
        
        public string Title { get; set; }

        public  string Content { get; set; }

        public virtual User Owner { get; set; }

    }

    public class User
    {
        public int id { get; set; }
        [Required]
        [MinLength(1)]
        [Index(IsUnique = true)]
        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
