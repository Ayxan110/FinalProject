using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectV2.Data;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Data;

namespace FinalProjectV2.Controllers
{
    public class BlogController : Controller
    {
        private readonly ProjectDbContext _dbContext;
        public BlogController(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewModel model = new ViewModel();
            model.Products = _dbContext.Products.ToList();
            model.Contacts = _dbContext.Contacts.ToList();
            model.Categories = _dbContext.Categories.ToList();
            model.Socials = _dbContext.Socials.ToList();
            model.News = _dbContext.News.ToList();
            return View(model);
        }
    }
}