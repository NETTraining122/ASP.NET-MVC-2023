using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            using (var myentity = new Database1Entities1())
            {

                List<Table> um = myentity.Tables.ToList();

                return View(um);
            }

        }


    }
}