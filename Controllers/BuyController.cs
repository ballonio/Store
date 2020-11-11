using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class BuyController : Controller
    {
        ItemContext db = new ItemContext();
        OrderContext db1 = new OrderContext();
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ItemId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            order.Price = 1000;
            db1.Orders.Add(order);
            db1.SaveChanges();
            return "Thank's for you purchase";
        }
    }
}