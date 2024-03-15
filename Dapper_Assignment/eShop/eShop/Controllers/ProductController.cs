using eShop.ApplicationCore.Models;
using eShop.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eShop.Controllers;

public class ProductController : Controller
{

    private readonly IProductRepsitory productRepsitory;

    public ProductController(IProductRepsitory repo)
    {
        productRepsitory = repo;
    }
    // GET
    public IActionResult Index()
    {
        var result = productRepsitory.GetAll();
        return View(result);
    }

    [HttpGet]
    public IActionResult Create()
    {

        // ViewBag.Department = new SelectList(productRepsitory.GetAll(), 
        //     "Id", "ProductName", "Description", "");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product obj)
    {
        productRepsitory.Insert(obj);
        return View();
    }
}