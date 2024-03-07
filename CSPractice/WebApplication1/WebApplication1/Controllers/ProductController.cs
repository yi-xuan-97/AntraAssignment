using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            // return Content("This will give the list of product");
            return View();
        }
    }
}