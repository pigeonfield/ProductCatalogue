using Newtonsoft.Json;
using ProductCatalogue.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ProductCatalogue.API.Services
{
    public class ProductRepo 
    {
        public ProductRepo()
        {
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var mockData = HostingEnvironment.MapPath(@"~/App_Data/MockData.json");
            var json = System.IO.File.ReadAllText(mockData);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);

            return products;
        }

        //public IEnumerable<Product> GetFilteredResult(SearchFilter filter)
        //{
        //    return null;
        //}
    }

    
}