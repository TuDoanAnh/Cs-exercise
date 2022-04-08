using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using TheSecondWenApp.Logics;
using TheSecondWenApp.Models;

namespace TheSecondWenApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult View()
        {
            string deserialize = HttpContext.Session.GetString("cart");
            Dictionary<Product, int> cart = new Dictionary<Product, int>();
            double total = 0;
            if (deserialize != null)
            {
                Dictionary<int, int> p = JsonSerializer.Deserialize<Dictionary<int, int>>(deserialize);
                foreach (int item in p.Keys)
                {
                    Product tempProduct = new ProductLogic().getByProductId(item);
                    cart.Add(tempProduct, p[item]);
                    total += (double) tempProduct.UnitPrice * p[item];
                }
            }
            ViewBag.Total = total;
            return View(cart);
        }
    }
}
