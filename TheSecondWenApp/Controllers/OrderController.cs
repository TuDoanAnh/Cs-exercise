using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using TheSecondWenApp.Logics;
using TheSecondWenApp.Models;
namespace TheSecondWenApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            using(var context = new NorthwindContext())
            {
                List<Customer> customers = context.Customers.ToList();
                List<Employee> employees = context.Employees.ToList();
                List<Shipper> shippers = context.Shippers.ToList();
                ViewBag.Customer = customers;
                ViewBag.Employee = employees;
                ViewBag.Shipper = shippers;
            }
            return View();
        }

        public IActionResult DoCreate(Order NewOrder)
        {
            using( var context = new NorthwindContext())
            {
                DateTime dt = DateTime.Now;
                NewOrder.OrderDate = dt;
                string deserialize = HttpContext.Session.GetString("cart");
                if (deserialize != null)
                {
                    context.Orders.Add(NewOrder);
                    context.SaveChanges();

                    Order o = context.Orders.FirstOrDefault(x => 
                    x.OrderDate == dt);

                
                    Dictionary<Product, int> cart = new Dictionary<Product, int>();

                
                    Dictionary<int, int> p = JsonSerializer.Deserialize<Dictionary<int, int>>(deserialize);
                    foreach (int item in p.Keys)
                    {
                        Product tempProduct = new ProductLogic().getByProductId(item);
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderId = o.OrderId;
                        orderDetail.ProductId = tempProduct.ProductId;
                        orderDetail.UnitPrice = (decimal)tempProduct.UnitPrice;
                        orderDetail.Quantity = (short)p[item];
                        orderDetail.Discount = 0;

                        context.OrderDetails.Add(orderDetail);
                        context.SaveChanges();
                    }
                    HttpContext.Session.Remove("cart");
                    TempData["notiCreateOrder"] = "Thanh Cong Nek!";
                }
            }
            return Redirect("/Product/List");
        }
    }
}
