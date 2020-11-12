using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;
using System.Web.Helpers;
using webapp.EF;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        private TemplateDBEntities _dbContext;
        public HomeController()
        {
            _dbContext = new TemplateDBEntities();
        }

        public ActionResult Index()
        {
           string pageid =  Request.QueryString.Get("PageID");
            if (pageid == null)
            {
                pageid = "1";
            }
            ViewBag.pageID = pageid;
            return View();
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
        
        [HttpPost, ValidateInput(false)]
        public ActionResult EditSection(dynamic data)
        {
            string receivedData  = HttpUtility.HtmlEncode(Request.Form["body"]);
            var stream = HttpUtility.HtmlDecode(receivedData);
            return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
        }
    }
}