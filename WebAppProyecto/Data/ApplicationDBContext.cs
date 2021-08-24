using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProyecto.Models;

namespace WebAppProyecto.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }
        //Inicializar DBSets, cada uno equivale a una bd en SQL
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CatTipoUsuario> CatTipoUsuario { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<CatTipoSexo> CatTipoSexo { get; set; }

    }
}
