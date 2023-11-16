using AspNetMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers{

    public class FirstController : Controller{

        private readonly ILogger<FirstController> _logger;
        private readonly ProductService? _productService;

        public FirstController(ILogger<FirstController> logger, ProductService productService){
            _logger = logger;
            _productService = productService;

        }


        public string Index(){
            // this.HttpContext
            // this.Request
            // this.RouteData
            // this.User
            // this.Response
            // this.ModelState
            // this.ViewData
            // this.ViewBag
            // this.Url
            // this.TempData
            _logger.LogInformation("IndexAction");  
            return "im index first";
        }
        public IActionResult ViewProduct(int? id){
            #pragma warning disable
            var product = _productService.FirstOrDefault(p =>p.Id == id);
            if(product == null){
                return NotFound();
            }
            // View/First/ViewProduct.cshtml
            return View(product);
        }
    }
}