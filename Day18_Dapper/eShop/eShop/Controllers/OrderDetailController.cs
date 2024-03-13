using eShop.ApplicationCore.Models;
using eShop.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eShop.Controllers;

public class OrderDetailController : Controller
{
    private readonly IOrderDetailRepository orderDetailRepository;

    public OrderDetailController(IOrderDetailRepository repo)
    {
        orderDetailRepository = repo;
    }
    // GET
    public IActionResult Index()
    {
        var result = orderDetailRepository.GetAll();
        return View(result);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Product = new SelectList(orderDetailRepository.GetAll(), "Id", "name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(OrderDetail obj)
    {
        orderDetailRepository.Insert(obj);
        return View();
    }
}