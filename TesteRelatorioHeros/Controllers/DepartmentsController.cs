using Microsoft.AspNetCore.Mvc;
using TesteRelatorioHeros.Models;

namespace TesteRelatorioHeros.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Super Herois da Água" });
            list.Add(new Department { Id = 1, Name = "Super Herois do Fogo" });



            return View(list);
        }
    }
}
