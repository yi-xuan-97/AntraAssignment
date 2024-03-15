using eShop.ApplicationCore.Entities;
using eShop.ApplicationCore.RepositoryInterface;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers;

public class PromotionController : Controller
{
    private readonly IPromotionRepository _promotionRepository;

    public PromotionController(IPromotionRepository repo)
    {
        _promotionRepository = repo;
    }
    // GET
    public IActionResult Index()
    {

        ViewBag.availablePromotion = _promotionRepository.GetAll()
            .Where(x=> x.StartDate<DateTime.Now && x.EndDate>DateTime.Now);
        ViewBag.nonavailablePromotion = _promotionRepository.GetAll()
            .Where(x=> x.StartDate>DateTime.Now);
        
        return View(ViewBag);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Promotion obj)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _promotionRepository.Insert(obj);
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
        var result = _promotionRepository.GetById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Edit(Promotion obj)
    {
        try
        {
            _promotionRepository.Update(obj);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return View(obj);
        }
    }
}