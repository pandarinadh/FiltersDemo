using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiltersDemo.Controllers.Filters;

namespace FiltersDemo.Controllers
{
    public class HomeController : Controller
    {   
        [CustomAuthorization]
        [CustomAction]
        [CustomResultAttribute]
        [CustomExceptionAttribute]
        public ActionResult Index()
        {
            //throw new Exception("Dummy Exception");
            ViewBag.Message = "Index Action of Home controller is being called.";
            return View();
        }

    }
}
