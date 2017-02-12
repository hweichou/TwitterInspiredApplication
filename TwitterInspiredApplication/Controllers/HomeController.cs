using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterInspiredApplication.DAL;
using TwitterInspiredApplication.Models;

namespace TwitterInspiredApplication.Controllers
{
    public class HomeController : Controller
    {
        //private TwitterContext dbContext = new TwitterContext();
        public ActionResult Index()
        {
            //DateTime time = DateTime.Now;
            /**dbContext.Hashtag.Add(new Hashtag()
            {
                tagname = "#testing"
            });
            try
            {
                dbContext.SaveChanges();
            }catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }**/
            
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
    }
}