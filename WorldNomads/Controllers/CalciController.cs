using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldNomads.Models;

namespace WorldNomads.Controllers
{
    public class CalciController : Controller
    {
        // GET: Calc
        public ActionResult Calc()
        {
            CalciClass Cal = new CalciClass();
            return View(Cal);
        }
        [HttpPost]
        public ActionResult Calc(CalciClass Model)
        {
            if (ModelState.IsValid)
            {
                Model.successCritera = true;
            }
            return View(Model);
        }
    }
}