using Ictshop.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class HomeController : Controller
    {

        Qlbanhang db = new Qlbanhang();
        public ActionResult Index()
        {
       
            return View();

        }


        public ActionResult Index_search(string searchString, int? page)
        {

            int recordsPerPage = 8;

            if (!page.HasValue)
            {
                page = 1; // set initial page value
            }
            ViewBag.Keyword = searchString;
            
            var sanPhams = db.Sanphams.ToList();
            try
            {
                if (!String.IsNullOrEmpty(searchString))
                {
                    sanPhams = sanPhams.Where(s => s.Tensp.ToLower().Contains(searchString.ToLower())).ToList();
                }
            }
            catch (Exception ex) { }
            sanPhams.OrderByDescending(v => v.Masp);
            var finalList = sanPhams.OrderByDescending(v => v.Masp).ToPagedList(page.Value, recordsPerPage);

            

            

            return View(finalList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SlidePartial()
        {
            return PartialView();

        }
    }
}