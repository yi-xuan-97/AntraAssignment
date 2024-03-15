using eShop.ApplicationCore.Models;
using eShop.ApplicationCore.RepositoryInterface;
using eShop.Infrustructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eShop.Controllers;

public class OrderDetailController : Controller
{
    private readonly IOrderDetailRepository orderDetailRepository;
    private readonly IProductRepsitory productRepsitory;

    public OrderDetailController(IOrderDetailRepository repo, IProductRepsitory prepo)
    {
        orderDetailRepository = repo;
        productRepsitory = prepo;
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
        ViewBag.Product = new SelectList(productRepsitory.GetAll(), "Id", "name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(OrderDetail obj)
    {
        orderDetailRepository.Insert(obj);
        return RedirectToAction("Index");
    }
}