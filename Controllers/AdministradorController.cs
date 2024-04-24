using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoTurnos.Data;

namespace ProyectoTurnos.Controllers
{
    public class AdministradorController : Controller
    {
     public readonly BaseContext _context;

        public AdministradorController (BaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}