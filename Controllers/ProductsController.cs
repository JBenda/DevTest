using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevTaskJulianBenda.Models;

namespace DevTaskJulianBenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProduktContext _context;

        public ProductsController(ProduktContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<ProductList> GetProducts()
        {
            return _context.Products.Select<Product, ProductList>(product => new ProductList{
                id = product.id, prodcut_name = product.product_name, product_id = product.product_id
            }) ;
        }
      
        // POST: api/Products
        [HttpPost]
        public ProductRequestRespond PostProduct(ProductRequest request)
        {
            return new ProductRequestRespond { can_fulfill = 
                request.quantity > 0
                && _context.Products
                    .Where(pro => pro.product_id == request.product_id)
                    .Select(pro => pro.stock_available)
                    .Sum() >= request.quantity
            };
        }

    }
}
