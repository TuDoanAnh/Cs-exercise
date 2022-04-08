using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using TheSecondWenApp.Logics;
using TheSecondWenApp.Models;

namespace TheSecondWenApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int id, int page)
        {
            List<Category> categories = (new CategoryLogic()).getAllCategories();
            List<Product> products = new List<Product>();
            List<Product> pageProducts = new List<Product>();
            if (id == 0)
            {
                products = (new ProductLogic()).getAllProducts();
            }
            else
            {
                products = (new ProductLogic()).getProductById(id);
            }
            int pageSize = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetValue<int>("SizeOfPage");
            if (page <= 0) page = 1;
            if(page > products.Count/pageSize) page = products.Count / pageSize;
            if(products.Count > 0)
            {
                for (int i = (pageSize*(page-1)); i < (pageSize * (page - 1) + pageSize); i++)
                {
                    pageProducts.Add(products[i]);
                }
            }
            ViewBag.CategoryId = id;
            ViewBag.TotalPage = products.Count / pageSize;
            ViewBag.PageSize = pageSize*page;
            ViewBag.Categories = categories;
            return View(pageProducts);
        }

        public IActionResult AddtoCart(int id, int page, int pId)
        {
            string deserialize = HttpContext.Session.GetString("cart");
            Product product=new Product();
            using(var context = new NorthwindContext())
            {
                 product = context.Products.FirstOrDefault(x => x.ProductId == pId);
            }
            if (product != null)
            {
                if (deserialize == null)
                {
                    Dictionary<int, int> cart = new Dictionary<int, int>();
                    cart.Add(product.ProductId, 1);
                    string proSerialize = JsonSerializer.Serialize(cart);
                    HttpContext.Session.SetString("cart", proSerialize);                
                }
                else
                {
                    Dictionary<int, int> p = JsonSerializer.Deserialize<Dictionary<int, int>>(deserialize);
                    Boolean check = false;
                    foreach (int temp in p.Keys)
                    {
                        if (temp == pId)
                        {
                            p[temp]++;  
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        p.Add(product.ProductId, 1);
                    }
                    string proSerialize = JsonSerializer.Serialize(p);
                    HttpContext.Session.SetString("cart", proSerialize);
                }
            }
            return Redirect($"/Product/List/{id}/{page}");
        }
    }
}
