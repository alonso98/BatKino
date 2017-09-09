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
        public ActionResult Create(Film film, HttpPostedFileBase imgFront)
        {
            if (ModelState.IsValid && imgFront != null/* && imgBack != null*/)
            {
                byte[] FrontImage = null, BackImage = null;
                using (var reader = new BinaryReader(imgFront.InputStream))
                {
                    FrontImage = reader.ReadBytes(imgFront.ContentLength);
                }
                /*using (var reader = new BinaryReader(imgBack.InputStream))
                {
                    BackImage = reader.ReadBytes(imgBack.ContentLength);
                }*/
                film.ImgFront = FrontImage;
                //film.ImgBack = BackImage;
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}