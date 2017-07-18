using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleMVCProject.Models;
namespace ExampleMVCProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            
            return View();
        }
       
        public JsonResult RGBColor()
        {
            RGB color=new RGB();
            return Json(color);
        }
	}
}