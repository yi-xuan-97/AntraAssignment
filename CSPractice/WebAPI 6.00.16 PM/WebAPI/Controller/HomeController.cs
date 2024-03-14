using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controller;

[Route("[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("This is okay");
    }

    [Route("{id:int:min(1)}")]
    public IActionResult GetData(int id)
    {
        return Ok("This is get data method " + id);

    }
}