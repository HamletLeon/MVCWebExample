using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebTest.Models
{
    public class ContactCategory
    {
        public int Id { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}