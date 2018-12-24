using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Books.Controllers
{
    public class BookController : Controller
    {
        // GET: Read
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Navigation()
        {
            return View();
        }

        public ActionResult welcome()
        {
            return View();
        }
    }
}