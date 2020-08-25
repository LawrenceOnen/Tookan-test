using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Femet_app.Models
{

    //The DbContext class for the Blogs and Post
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguration(DbContextBuilder options){
            
        }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        //List of posts belonging to a blog
        public List<Post> Posts { get; } = new List<Post>();
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set;}
        public string Content { get; set; }
        //Create the relationship between the blog and post by addng the BlogId
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}