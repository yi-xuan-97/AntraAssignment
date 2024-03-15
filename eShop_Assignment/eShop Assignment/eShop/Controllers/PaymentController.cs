using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class PaymentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}