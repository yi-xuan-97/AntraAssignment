using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Order.API.Helper;

namespace Order.API.Controller;

[ApiController]
[Route("[controller]/[action]")]
public class OrderController : ControllerBase
{
    private Notification _notification;

    public OrderController()
    {
        _notification = new Notification();
    }
    [HttpPost]
    public IActionResult CreateOrder(string message)
    {
        _notification.AddMessageToQueue(message);
        return Ok();
    }
    
    
}