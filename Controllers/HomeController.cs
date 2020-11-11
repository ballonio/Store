using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        ItemContext db = new ItemContext();
        public ActionResult Index()
        {
            IEnumerable<Item> items = db.Items;
            ViewBag.Items = items;
            return View();
        }
    }
}