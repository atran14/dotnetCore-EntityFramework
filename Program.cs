using System;
using System.Linq;
using dotnetCore_EntityFramework.Models;

namespace dotnetCore_EntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("----------Inserting data----------");
            using (var db = new BloggingDbContext())
            {
                db.Add(new Blog
                {
                    Url = "google.com"
                });
                db.SaveChangesAsync();
                
                Console.WriteLine("----------Inserting data----------");
                var blogs = db.Blogs.AsQueryable<Blog>();
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Blog: {blog.ID}, {blog.Url}");
                }

                Console.WriteLine("----------Deleting data----------");
                var blogs2 = db.Blogs.ToList();                
                db.Blogs.RemoveRange(blogs2);
                db.SaveChanges();
            }
        }
    }
}