using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FatihBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Post()
        {

        }
    }
}
