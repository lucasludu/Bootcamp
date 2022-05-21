using EFCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCF.Repository
{
    public class BlogPostRepository
    {

        public List<BlogPost> ObtenerTodos()
        {
            using(var db = new BlogContext())
            {
                return db.BlogPosts.Include(x => x.Comentarios).ToList();
            }
        }

        public void Crear(BlogPost model)
        {
            using(var db = new BlogContext())
            {
                db.BlogPosts.Add(model);
                db.SaveChanges();   // Siembre de una accion hay que guardar cambios
            }
        }
    }
}