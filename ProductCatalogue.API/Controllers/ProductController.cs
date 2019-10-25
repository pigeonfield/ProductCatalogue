using ProductCatalogue.API.Models;
using ProductCatalogue.API.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData;

namespace ProductCatalogue.API.Controllers
{
    [EnableCors("https://localhost:44357", "*", "*")]
    public class ProductController : ApiController
    {
        //private readonly ProductRepo repo;
        public ProductController()
        {
            //this.repo = repo;
        }

        [EnableQuery()]
        public IQueryable<Product> GetProducts()
        {
            var repo = new ProductRepo();
            var productsFromRepo = repo.GetAllProducts().AsQueryable();
            return productsFromRepo;
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            var repo = new ProductRepo();
            var products = repo.GetAllProducts();
            return products.Where(p => p.Name.Contains(filter));
        }
    }
}
