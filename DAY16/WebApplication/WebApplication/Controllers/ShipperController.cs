using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ShipperController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<Shipper> list = new List<Shipper>();
            list.Add(new Shipper() { ShipperId = 1, CompanyName = "Company1", Phone = "1234567899" });
            list.Add(new Shipper() { ShipperId = 2, CompanyName = "Company2", Phone = "1234567899" });
            list.Add(new Shipper() { ShipperId = 3, CompanyName = "Company3", Phone = "1234567899" });
            return View(list);
        }
    }
}