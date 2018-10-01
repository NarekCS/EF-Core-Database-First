using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExistingDb.Models.Manual;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExistingDb.Controllers
{
    public class ManualController : Controller
    {
        private ManualContext context;
        public ManualController(ManualContext ctx) => context = ctx;
        public IActionResult Index() => View(context.Shoes);
    }
}
