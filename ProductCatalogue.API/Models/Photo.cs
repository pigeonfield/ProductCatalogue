using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatalogue.API.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsMain { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}