using System.ComponentModel.DataAnnotations;

namespace dotnetCore_EntityFramework.Models
{
    public class Post
    {
        public int ID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}