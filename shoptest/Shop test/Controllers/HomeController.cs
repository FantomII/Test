using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_test.Models;

namespace Shop_test.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();
        public ActionResult Index()
        {
            IEnumerable<Phone> phones = phoneContext.Phones;

            ViewBag.Phones = phones;

            return View();
        }
    [HttpGet]

    public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;
            phoneContext.Purchases.Add(purchase);
            phoneContext.SaveChanges();
            return $"Уважаемый, {purchase.Fio} , ждите ответа";
        }

    }
}