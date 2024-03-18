using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.ApplicationCore.ServiceInterface;
using eShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ShoppingCartController : Controller
{
    private IShoppingCartService _shoppingCartService;
    public ShoppingCartController(IShoppingCartService repo)
    {
        _shoppingCartService = repo;
    }
    // GET
    public IActionResult Index()
    {
        if ( HttpContext.Session.GetInt32("uid") != null)
        {
            var result = _shoppingCartService.GetAllProducts((int)HttpContext.Session.GetInt32("uid"));
            return View(result);
        }

        return View();
    }

    public IActionResult CheckOut()
    {
        if (HttpContext.Session.GetInt32("uid") != null && _shoppingCartService != null)
        {
            var result = _shoppingCartService.GetTotal((int)HttpContext.Session.GetInt32("uid"));
            return View(result);
        }
        
        return View(0);
    }
}