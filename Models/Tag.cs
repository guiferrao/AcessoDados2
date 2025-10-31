using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace AcessoDados2.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}