using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstWebApp.models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstWebApp.controllers
{
    public class Blahcontroller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(calculatormodel model)
        {
            return View();
        }
    }
}
