using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee EM)
        {
            if (ModelState.IsValid)
            {
                TempData["mydata"] = EM; 
                return RedirectToAction("Index2","Home");
            
            }
            return View("Index");
        }
        public ActionResult Index2()
        {
            Employee data = TempData["mydata"] as Employee;
           // TempData.Keep();
           return View(data);

            }
            
        }

    }

