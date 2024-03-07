using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Name1", Salary = 1000, DepartmentId = 1 });
            employees.Add(new Employee() { Id = 2, Name = "Name2", Salary = 2000, DepartmentId = 2 });
            employees.Add(new Employee() { Id = 3, Name = "Name3", Salary = 3000, DepartmentId = 1 });
            return View(employees);
        }
    }
}