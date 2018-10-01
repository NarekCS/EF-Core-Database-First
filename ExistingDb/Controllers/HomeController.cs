using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExistingDb.Models.Scaffold;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExistingDb.Controllers
{
    public class HomeController : Controller
    {
        private ScaffoldContext context;
        public HomeController(ScaffoldContext ctx) => context = ctx;
        public IActionResult Index()
        {
            return View(context.Shoes
                .Include(s => s.Color)
                .Include(s => s.SalesCampaigns)
                .Include(s => s.ShoeCategoryJunction)
                    .ThenInclude(junct => junct.Category)
                .Include(s => s.Fitting));
        }
    }
}
