using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
using System.IO;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        CinemaContext db = new CinemaContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Film film, HttpPostedFileBase imgFront, HttpPostedFileBase imgBack)
        {

            return RedirectToAction("Index");
        }
    }
}