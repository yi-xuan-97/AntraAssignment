using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductCatalogController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<ProductCatalog> list = new List<ProductCatalog>();
            list.Add(new ProductCatalog()
            {
                CatalogId = 1, ProductId = 1, ProductName = "Ice Cream", SupplierId = 1,
                UnitInStock = 12, UnitPrice = 30
            });
            list.Add(new ProductCatalog()
            {
                CatalogId = 1, ProductId = 2, ProductName = "Frozen Yogurt", SupplierId = 2,
                UnitInStock = 20, UnitPrice = 35
            });
            list.Add(new ProductCatalog()
            {
                CatalogId = 2, ProductId = 3, ProductName = "Ramen", SupplierId = 3,
                UnitInStock = 32, UnitPrice = 6
            });
            return View(list);
        }
    }
}