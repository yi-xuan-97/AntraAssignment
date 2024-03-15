using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository productRepository;
    public ProductController(IProductRepository repo)
    {
        productRepository = repo;
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
    
}