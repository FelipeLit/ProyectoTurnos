using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoEmpleado.Data;

namespace ProyectoTurnos.Controllers
{
    public class TurnosController : Controller
    {
     public readonly BaseContext _context;

        public TurnosController (BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(u=>u.Id == id);
            if(user != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", user.Id);
            }
            return View();
        }

        public IActionResult TipoTurno()
        {

            return View();
        }

    }
}