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
    public IActionResult Index()
    {
        ViewBag.Title = "Customer List";
        ViewData["Title"] = "Customer List";
        var result = customerRepository.GetAll();
        return View(result);
    }
}