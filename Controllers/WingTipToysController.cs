using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingExercise.Models;

namespace CodingExercise.Controllers
{
    public class WingTipToysController : Controller
    {
        // GET: WingTipToys
        public ActionResult Index(string productSearch)
        {
            return View(Helper.HelperClass.DisplayData(productSearch));

        }



        public ActionResult SearchProducts()
        {


            return View();
        }
    }
}