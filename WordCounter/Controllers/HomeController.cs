using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult WordCount(string inputString)
        {
            int res = WordCountModel.WordCount(inputString);
            return PartialView((object)res.ToString());
        }

        public ActionResult CurWordCount(string inputString, string CurWord)
        {
            int res = WordCountModel.CurWordCount(inputString, CurWord);
            return PartialView((object)res.ToString());
        }
    }
}