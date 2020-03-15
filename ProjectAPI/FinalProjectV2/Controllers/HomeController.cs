using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjectV2.Models;
using ProjectAPI.Data.Entities;
using ProjectAPI.Data;
using FinalProjectV2.Data;

namespace FinalProjectV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ProjectDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Fromae()
        {
            ViewModel model = new ViewModel();
            model.Products = _dbContext.Products.ToList();
            model.Contacts = _dbContext.Contacts.ToList();
            model.Categories = _dbContext.Categories.ToList();
            model.SubCategories = _dbContext.SubCategories.ToList();
            model.SubCategoryItems = _dbContext.SubCategoryItems.ToList();
            model.Socials = _dbContext.Socials.ToList();
            return View(model);
        }
        
        public IActionResult Register()
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
