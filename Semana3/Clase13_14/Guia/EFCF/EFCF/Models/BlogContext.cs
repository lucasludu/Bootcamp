using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCF.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}