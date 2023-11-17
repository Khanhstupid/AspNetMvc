using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService? _productservice;
        private readonly ILogger<ProductController>? _logger;
        public ProductController(ProductService productservice, ILogger<ProductController> logger){
            _productservice = productservice;
            _logger = logger;
        }
        public IActionResult Index()
        {   
            #pragma warning disable
            var products = _productservice.OrderBy(p => p.Name).ToList();
            return View(products);
        }
    }
}