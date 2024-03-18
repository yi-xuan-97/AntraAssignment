using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.ApplicationCore.ServiceInterface;
using eShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository productRepository;
    private readonly IShoppingCartService _shoppingCartService;
    public ProductController(IProductRepository repo, IShoppingCartService srepo)
    {
        productRepository = repo;
        _shoppingCartService = srepo;
    }
    // GET
    public IActionResult Index()
    {
        var content = productRepository.GetAll();
        return View(content);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Product obj)
    {
        if (ModelState.IsValid)
        {
            try
            {
                productRepository.Insert(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }

        return View(obj);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = productRepository.GetById(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Delete(Product obj)
    {
        productRepository.Delete(obj.Id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var product = productRepository.GetById(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product obj)
    {
        try
        {
            productRepository.Update(obj);
            return RedirectToAction("Index");
        }
        catch(Exception ex)
        {
            return View(obj);
        }
    }
    
    [HttpGet]
    public IActionResult AddCart(int id)
    {
        var result = productRepository.GetById(id);
        return View(result);
    }
    
    [HttpPost]
    public IActionResult AddToCart(int id)
    {
        if (!ModelState.IsValid)
        {
            // Return the view with the invalid model
            return RedirectToAction("Index");
        }

        int? userId = HttpContext.Session.GetInt32("uid");
        if (userId == null)
        {
            // Handle the case where the user is not logged in
            return RedirectToAction("Index", "Customer"); // Redirect to the login page
        }

        // If the user is logged in, add the product to the cart
        _shoppingCartService.AddToCart(userId.Value, id);

        // Redirect to the shopping cart index page
        return RedirectToAction("Index", "ShoppingCart");
    }
    
}