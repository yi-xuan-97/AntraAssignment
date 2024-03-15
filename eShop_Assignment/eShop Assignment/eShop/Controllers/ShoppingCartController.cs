using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ShoppingCartController : Controller
{
    private readonly IShoppingCartRepository _shoppingCartRepository;
    private readonly ICartItemRepository _cartItemRepository;
    public ShoppingCartController(IShoppingCartRepository repo)
    {
        _shoppingCartRepository = repo;
    }
    // GET
    public IActionResult Index()
    {
        var shoppingCart = _shoppingCartRepository.GetByCustomerId((int)TempData["uid"]).Id;
        var result = _cartItemRepository.GetbyShoppingCartId(shoppingCart);
        return View(result);
        try
        {
            
        }
        catch (Exception ex)
        {
            return View();
        }
    }
}