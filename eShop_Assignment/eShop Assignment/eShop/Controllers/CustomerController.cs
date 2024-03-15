using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class CustomerController : Controller
{
    protected readonly ICustomerRepository customerRepository;
    
    public CustomerController(ICustomerRepository repo)
    {
        customerRepository = repo;
    }
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(int id)
    {
        TempData["uid"] = id;
        return RedirectToAction("Display", new { id = id });
    }

    public IActionResult Display(int id)
    {
        var result = customerRepository.GetById(id);
        return View(result);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var result = customerRepository.GetById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Edit(Customer obj)
    {
        try
        {
            customerRepository.Update(obj);
            return RedirectToAction("Display", new { id = obj.Id });
        }
        catch (Exception ex)
        {
            return View("Index");
        }
    }
}