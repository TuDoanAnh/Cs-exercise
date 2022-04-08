using System.Collections.Generic;
using System.Linq;
using TheSecondWenApp.Models;

namespace TheSecondWenApp.Logics
{
    public class CategoryLogic
    {
        public List<Category> getAllCategories()
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}
