using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;
using ProyectoEntity = Proyecto.Models.Proyecto;

namespace Proyecto.Controllers
{
    namespace Proyecto.Controllers
    {
        public class ProyectosController : Controller
        {
            private readonly AppDbContext _context;

            public ProyectosController(AppDbContext context)
            {
                _context = context;
            }

            // GET: /Proyectos
            public IActionResult Index()
            {
                var proyectos = _context.Proyectos.ToList();
                return View(proyectos);
            }

            // GET: /Proyectos/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: /Proyectos/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(ProyectoEntity proyecto)
            {
                if (ModelState.IsValid)
                {
                    _context.Proyectos.Add(proyecto);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                return View(proyecto);
            }
        }
    }

}
