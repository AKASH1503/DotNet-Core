using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string List()
        {
            return "List() of departments Controller";
        }
        public string Details()
        {
            return "Details() of departments Controller";
        }
    }
}
