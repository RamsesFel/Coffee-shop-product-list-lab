using Coffee_shop_product_list_lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_shop_product_list_lab.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext dbcontext = new ProductDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = dbcontext.Products.ToList();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product result = dbcontext.Products.Find(id);
            return View(result);
        }
    }
}
