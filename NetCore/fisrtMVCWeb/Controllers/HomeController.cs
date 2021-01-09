using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fisrtMVCWeb.Models;
using fisrtMVCWeb.Services;

namespace fisrtMVCWeb.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        //[Route("Home/Index")]
        public IActionResult Index(int id)
        {
            return View(_productService.getAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
