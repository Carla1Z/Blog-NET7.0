using Blog.AccesoDatos.Data.Repository.IRepository;
using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriasController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public CategoriasController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }




        #region Llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            //Opcion 1
            return Json(new { data = _contenedorTrabajo.Categoria.GetAll() });
        }

        #endregion
    }
}
