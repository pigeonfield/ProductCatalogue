using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatalogue.API.Models
{ 
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Category Category { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}