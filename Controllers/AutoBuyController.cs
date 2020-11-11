using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;
using System.Threading;

namespace Store.Controllers
{
    public class AutoBuyController : Controller
    {
        OrderContext db1 = new OrderContext();
        Random rnd = new Random();
        public  int Randomizer()
        {
            int num = rnd.Next(1, 10);
            return num;
        }
        public int RandomId()
        {
            int rid = rnd.Next(1, 4);
            return rid;
        }
        public string GenName()
        {
            List<string> lst = new List<string>();
            string name = string.Empty;
            lst.Add("Aiden");
            lst.Add("Jackson");
            lst.Add("Mason");
            name = lst.OrderBy(xx => rnd.Next()).First();
            return name;
        }
        [HttpGet]
        public ActionResult AutoBuy()
        {
            ViewBag.ItemId = RandomId();
            return View();
        }
        [HttpPost]
        public ActionResult PartialAutoBuy(Order order)
        {
            int i = 10;
            while (i > 0)
            {
                order.ClientName = GenName();
                order.Quanity = Randomizer();
                order.ItemId = RandomId();
                db1.Orders.Add(order);
                db1.SaveChanges();
                i--;
            }
            ViewBag.Message = order.ClientName + order.Price + order.Quanity;
            return PartialView();//added branchdwd
        }
    }
}