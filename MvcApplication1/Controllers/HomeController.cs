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
        
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(string pname, int uprice, int qty)
        {
            int t = uprice * qty;
            ViewData["prdname"] = pname;
            ViewBag.total = t;
            return View();
        }
        public ActionResult Details( int dno )
        {
            Response.Write("Request Dept"+ dno);
            return View();
        }
        public ActionResult Details2(int id)
        {
            Response.Write("Request Dept" + id);
            return View();
        }
        public ActionResult Details1()
        {
             return View();
        }
    }
}
