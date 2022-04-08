using System.Collections.Generic;
using System.Linq;
using TheSecondWenApp.Models;

namespace TheSecondWenApp.Logics
{
    public class ProductLogic
    {
        public List<Product> getAllProducts()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> getProductById(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Where(x => x.CategoryId == id).ToList();
            }
        }
        
        public Product getByProductId(int id)
        {
            using(var context = new NorthwindContext())
            {
                return context.Products.FirstOrDefault(x => x.ProductId == id);
            }
        }
    }
}
