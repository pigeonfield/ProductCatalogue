using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatalogue.API.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}