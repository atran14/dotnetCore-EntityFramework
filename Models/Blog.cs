using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetCore_EntityFramework.Models
{
    [Table("Blog")]
    public class Blog
    {
        public int ID { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}