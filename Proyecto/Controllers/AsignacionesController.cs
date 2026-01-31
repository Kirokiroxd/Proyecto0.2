using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{

    namespace Proyecto.Controllers
    {
        public class AsignacionesController : Controller
        {
            private readonly AppDbContext _context;

            public AsignacionesController(AppDbContext context)
            {
                _context = context;
            }

            // GET: /Asignaciones/Create
            public IActionResult Create()
            {
                ViewBag.Proyectos = new SelectList(_context.Proyectos, "ProyectoId", "Nombre");
                ViewBag.Empleados = new SelectList(_context.Empleados, "EmpleadoId", "Nombre");
                return View();
            }

            // POST: /Asignaciones/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(Asignacion asignacion)
            {
                if (ModelState.IsValid)
                {
                    asignacion.FechaAsignacion = DateTime.Now;
                    _context.Asignaciones.Add(asignacion);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Proyectos");
                }

                ViewBag.Proyectos = new SelectList(_context.Proyectos, "ProyectoId", "Nombre");
                ViewBag.Empleados = new SelectList(_context.Empleados, "EmpleadoId", "Nombre");
                return View(asignacion);
            }
        }
    }

}
