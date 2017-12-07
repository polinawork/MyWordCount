using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                string[] textMass;
                string text = inputString.Replace('\n', ' ');
                textMass = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int res = textMass.Length;
                if (textMass[textMass.Length - 1] == "")
                {
                    res = res - 1;
                }
                return PartialView((object)res.ToString());
        }

        public ActionResult CurWordCount(string inputString, string CurWord)
        {
            string[] textMass;
            string text = inputString.Replace('\n', ' ');
            textMass = text.Split(new char[] {' '});
            int res = 0;
            for (int i = 0; i < textMass.Length; ++i)
            {
                if (textMass[i] == CurWord)
                {
                    res = res + 1;
                }
            }
            return PartialView((object)res.ToString());
        }
    }
}