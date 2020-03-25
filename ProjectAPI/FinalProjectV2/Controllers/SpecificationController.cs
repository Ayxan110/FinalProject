using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectV2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data;
using ProjectAPI.Data.Entities;

namespace FinalProjectV2.Controllers
{
    public class SpecificationController : Controller
    {
        private readonly ProjectDbContext _dbContext;
        public SpecificationController(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(int id)
        {
            ViewBag.Properties = _dbContext.ProductSpec.Where(x => x.ProductId == id).Select(x => x.Specification.Name).ToList();
            ViewBag.PropertyValues = _dbContext.ProductSpec.Where(x => x.ProductId == id).Select(x => x.Value).ToList();
            var product = _dbContext.Products.Where(x => x.Id == id).ToList();
            return View(product);
        }
    }
}