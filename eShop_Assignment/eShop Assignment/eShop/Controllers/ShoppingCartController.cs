using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ShoppingCartController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}