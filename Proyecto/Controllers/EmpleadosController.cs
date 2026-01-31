using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
 

    namespace Proyecto.Controllers
    {
        public class EmpleadosController : Controller
        {
            private readonly AppDbContext _context;

            public EmpleadosController(AppDbContext context)
            {
                _context = context;
            }

            // GET: /Empleados
            public IActionResult Index()
            {
                var empleados = _context.Empleados.ToList();
                return View(empleados);
            }

            // GET: /Empleados/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: /Empleados/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(Empleado empleado)
            {
                if (ModelState.IsValid)
                {
                    _context.Empleados.Add(empleado);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                return View(empleado);
            }
        }
    }

}
