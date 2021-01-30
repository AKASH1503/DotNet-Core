using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandeling(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sory, requested page not Found";
                    ViewBag.QS= statusCodeResult.OriginalQueryString;
                    ViewBag.Path = statusCodeResult.OriginalPath;
                    break;
                default:
                    break;
            }
            return View("NotFound");
        }
    }
}
