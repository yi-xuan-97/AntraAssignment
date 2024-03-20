using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controller;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}