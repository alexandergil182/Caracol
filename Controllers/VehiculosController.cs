using CaracolTanqueos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace CaracolTanqueos.Controllers
{
    public class VehiculosController : Controller
    {

        private readonly TanqueosContext _context;
        public VehiculosController(TanqueosContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var areas = _context.Areas
                      .OrderBy(area => area.Nombre)
                      .ToList();

            ViewBag.Areas = areas;

            var vehiculos = (from vehiculo in _context.Vehiculos
                             join area in _context.Areas on vehiculo.IdArea equals area.Id
                             join tipo_equipos in _context.TiposEquipos on vehiculo.IdTipo equals tipo_equipos.Id
                             join tipos_combustible in _context.TiposCombustibles on vehiculo.IdTipoCombustible equals tipos_combustible.Id
                             join estados in _context.Estados on vehiculo.IdEstado equals estados.Id
                             orderby vehiculo.IdArea
                             select new
                             {
                                 Vehiculo = vehiculo,
                                 Area = area,
                                 Tipo = tipo_equipos,
                                 TiposCombustible = tipos_combustible,
                                 Estado = estados,
                             }).ToList();


            ViewBag.Vehiculos = vehiculos;


            return View();
        }

        public IActionResult Create()
        {
            var areas_lista = _context.Areas
                      .OrderBy(areas_lista => areas_lista.Nombre)
                      .ToList();

            ViewBag.Areas = areas_lista;

            var tipos_equipos_lista = _context.TiposEquipos
                      .OrderBy(tipos_equipos_lista => tipos_equipos_lista.Nombre)
                      .ToList();

            ViewBag.TiposEquipos = tipos_equipos_lista;

            var tipos_combustibles_lista = _context.TiposCombustibles
                      .OrderBy(tipos_combustibles_lista => tipos_combustibles_lista.Nombre)
                      .ToList();

            ViewBag.TiposCombustibles = tipos_combustibles_lista;

            var estados_lista = _context.Estados
                      .OrderBy(estados_lista => estados_lista.Nombre)
                      .ToList();

            ViewBag.Estados = estados_lista;


            return View();
        }

        [HttpPost]
        public IActionResult Create(Vehiculo vehiculo) {
            if (ModelState.IsValid)
            {
                
                _context.Add(vehiculo);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Modelo no válido");
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }


            var vehiculos = (from vehiculo_lista in _context.Vehiculos
                             join area in _context.Areas on vehiculo_lista.IdArea equals area.Id
                             join tipo_equipos in _context.TiposEquipos on vehiculo_lista.IdTipo equals tipo_equipos.Id
                             join tipos_combustible in _context.TiposCombustibles on vehiculo_lista.IdTipoCombustible equals tipos_combustible.Id
                             join estados in _context.Estados on vehiculo_lista.IdEstado equals estados.Id
                             orderby vehiculo_lista.IdArea
                             select new
                             {
                                 Vehiculo = vehiculo_lista,
                                 Area = area,
                                 Tipo = tipo_equipos,
                                 TiposCombustible = tipos_combustible,
                                 Estado = estados,
                             }).ToList();


            ViewBag.Vehiculos = vehiculos;


            return View("Index");
        }
    }
}
