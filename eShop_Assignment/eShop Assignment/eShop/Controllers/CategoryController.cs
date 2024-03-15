using eShop.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class CategoryController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(IProductRepository prepo, ICategoryRepository crepo)
    {
        _productRepository = prepo;
        _categoryRepository = crepo;
    }
    
    // GET
    public IActionResult Index()
    {
        var result = _categoryRepository.GetAll();
        return View(result);
    }
}