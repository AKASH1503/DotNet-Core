using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controller
{
    public class HomeController : ControllerBase
    {
        public JsonResult Index()
        {
            return new JsonResult(new { id = 1, Name = "Akash" });
        }
    }
}
