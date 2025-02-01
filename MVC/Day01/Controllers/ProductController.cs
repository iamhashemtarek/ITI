using Day01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day01.Controllers
{
    public class ProductController : Controller
    {
        ProductBL productBL = new ProductBL();
        public IActionResult All()
        {
            List<Product> productListModel = productBL.GetAll();
            
            return View("AllProducts", productListModel);
        }

        public IActionResult Details(int id)
        {
            Product productModel = productBL.GetByID(id);

            return View("Details", productModel);
        }
    }
}
