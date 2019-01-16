using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebTest.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}