using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoTurnos.Data;


namespace ProyectoTurnos.Controllers
{
    public class UsuariosController : Controller
    {
     public readonly BaseContext _context;

        public UsuariosController (BaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}