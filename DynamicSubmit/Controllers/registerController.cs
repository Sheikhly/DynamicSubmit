using DynamicSubmit.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicSubmit.Controllers
{
    public class registerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }






        [HttpPost]
        public ActionResult Index(Info model)
        {
            
            return Content("R");
        }

       


    }
}
