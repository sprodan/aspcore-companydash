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

        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо " + order.User + " за покупку!";
        }

        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }
    }
}
