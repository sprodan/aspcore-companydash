using Companydash.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companydash.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;

        public HomeController(MobileContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }
    }
}
