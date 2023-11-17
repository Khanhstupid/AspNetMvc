using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;

namespace AspNetMvc.Controllers
{
    public class PlanetController : Controller
    {
        private readonly PlanetService? _planetService;
        private readonly ILogger<PlanetController>? _logger;
        public PlanetController(PlanetService planetService, ILogger<PlanetController> logger){
            _planetService = planetService;
            _logger = logger;
        }

        [BindProperty(SupportsGet =true,Name ="action")]
        public string? Name {set;get;}
        public IActionResult Index()
        {
            return View();
        }
        // public IActionResult Mercury(){
        //     #pragma warning disable
        //     var planet = _planetService.Where(p=>p.Name == Name).FirstOrDefault();
        //     return View("Detail",planet);
        // }
        public IActionResult DetailPlanet(int? id){
            #pragma warning disable
            var planet = _planetService.Where(p=>p.Id == id).FirstOrDefault();
            return View("Detail",planet);
        }
    }
}