using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletronicos" });
            departments.Add(new Department { Id = 2, Name = "T1" });
            departments.Add(new Department { Id = 3, Name = "T2" });
            departments.Add(new Department { Id = 4, Name = "T3" });
            return View(departments);
        }
    }
}
