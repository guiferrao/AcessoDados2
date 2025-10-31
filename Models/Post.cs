using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace AcessoDados2.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}