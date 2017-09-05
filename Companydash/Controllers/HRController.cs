using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Companydash.Controllers
{
    public class HRController : Controller
    {
        // GET: /<controller>/
        public IActionResult Recruitment()
        {
            return View();
        }
        public IActionResult Teams()
        {
            return View();
        }
        public IActionResult Staff()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult ELearning()
        {
            return View();
        }
        public IActionResult Structure()
        {
            return View();
        }
        public IActionResult Grading()
        {
            return View();
        }
    }
}
