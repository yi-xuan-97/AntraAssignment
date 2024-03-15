using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class ShipperController : Controller
{
    private readonly IShipperRepository _shipperRepository;

    public ShipperController(IShipperRepository repo)
    {
        _shipperRepository = repo;
    }
    // GET
    public IActionResult Index()
    {
        var result = _shipperRepository.GetAll();
        return View(result);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Shipper obj)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _shipperRepository.Insert(obj);
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
    public IActionResult Edit(int id)
    {
        var product = _shipperRepository.GetById(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Shipper obj)
    {
        try
        {
            _shipperRepository.Update(obj);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
        return View(obj);
        }
    }
}