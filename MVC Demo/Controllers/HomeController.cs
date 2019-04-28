using MVC_Demo.CustomFIlters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        int a = 10;
        int b = 0;
        //[CustExceptionFilter]
        public ActionResult Default()
        {
            //int x = a / b;
            return View();
        }
        /// <summary>
        /// 'OutputCacheAttribute for child actions only supports Duration, VaryByCustom, and VaryByParam values. Please do not set CacheProfile, Location, NoStore, SqlDependency, VaryByContentEncoding, or VaryByHeader values for child actions.'
        /// The 'ChildActionOnly' attribute ensures that an action method can be called only as a child method from within a view. An action method doesn’t need to have this attribute to be used as a child action, but we tend to use this attribute to prevent the action methods from being invoked as a result of a user request.
        /// </summary>
        /// <returns></returns>
        [OutputCache(Duration =100,VaryByParam ="*")]
        [ChildActionOnly]
        public PartialViewResult CachingPartialView1()
        {
            string date = DateTime.Now.ToString();
            ViewBag.Date = date;
            return PartialView("CachingPartialView1");
        }

        /// <summary>
        /// Even though we have not written 'PartiaViewResult' as a return type or even though we have not marked a method as [CHildActionOnly], 
        /// this method is still ChildAction as it is being called as Partial View using 'Action' OR 'PartialAction'.
        /// </summary>
        /// <returns></returns>
        
        // This OutputCache attribute will not work
        // [OutputCache(Duration = 100, VaryByParam = "*", Location = System.Web.UI.OutputCacheLocation.Server)]
        [OutputCache(Duration = 100, VaryByParam = "*")]
        public ViewResult CachingPartialView2()
        {
            return View();
        }

        public ViewResult PartailView3()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            TempData["t1"] = "das";
            //return RedirectToAction("Method1");
            return View();
        }

        public ActionResult Method1()
        {
            //return RedirectToAction("Method2");
            return View("About");
        }

        public ActionResult Method2()
        {
            string val = TempData["t1"].ToString();
            //return RedirectToAction("Method3");
            return View("About");
        }

        public ActionResult Method3()
        {
            string v1 = TempData["t1"].ToString();
            if (v1 != "user")
            {
                // Carry this dat from TempData to next method else don't carry
                TempData.Keep("t1");
            }
            TempData.Peek("t1");
            //return RedirectToAction("Method4");
            return View("About");
        }
        public ActionResult Method4()
        {
            string v1 = TempData.Peek("t1").ToString();

            //return RedirectToAction("Method1");
            return View("About");
        }

        public ActionResult Method5()
        {
            string v1 = TempData["t1"].ToString();
            TempData.Keep("t1");
            //return RedirectToAction("Method1");
            return View("About");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}