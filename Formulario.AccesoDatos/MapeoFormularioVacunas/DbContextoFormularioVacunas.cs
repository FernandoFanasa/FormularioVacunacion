using Formulario.AccesoDatos.MapeoFormularioVacunas.EntidadesTables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.MapeoFormularioVacunas
{
    public class DbContextoFormularioVacunas:DbContext
    {

        public DbSet<Vacunas> Vacunas { get; set; }

        public DbContextoFormularioVacunas( DbContextOptions<DbContextoFormularioVacunas> options) :base(options)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vacunas>().HasKey(x => new { x.IdPrimario});
        }

    }
}
