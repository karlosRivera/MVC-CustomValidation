using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthTest.Models;

namespace AuthTest.Controllers
{
    public class DatValController : Controller
    {
        // GET: DatVal
        public ActionResult Index()
        {
            DateValTest d = new DateValTest();
            return View(d);
        }

        [HttpPost]
        public ActionResult Index(DateValTest d)
        {
            //DateValTest d = null;
            if (ModelState.IsValid)
            {
                //d = new DateValTest();
            }
            return View(d);
        }
    }
}