using Microsoft.EntityFrameworkCore;
using ProyectoTurnos.Models;

namespace ProyectoTurnos.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base (options)
        {

        }
        public DbSet <Administrador> Administrador { get; set;}
        public DbSet <Usuarios> Usuarios { get; set;}
        public DbSet <Turnos> Turnos { get; set;}
        public DbSet <TipoDocumento> TipoDocumento { get; set;}
        public DbSet <TipoTurno> TipoTurno { get; set;}


    }
}