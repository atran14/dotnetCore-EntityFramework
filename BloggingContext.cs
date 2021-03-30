using System;
using dotnetCore_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore_EntityFramework
{
    public class BloggingDbContext : DbContext
    {

        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=localhost;Database=testDB;Trusted_Connection=True;");


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Blog>()
                .Property(x => x.Url)
                .IsRequired();            
        }

        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello World!");
        // }
    }
}
