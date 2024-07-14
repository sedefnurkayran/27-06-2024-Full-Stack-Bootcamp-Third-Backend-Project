using DBTechcareer.Data;
using Microsoft.AspNetCore.Mvc;

namespace DBTechcareer.Controllers
{

    public class StudentController : Controller
    {

        //constructor
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}