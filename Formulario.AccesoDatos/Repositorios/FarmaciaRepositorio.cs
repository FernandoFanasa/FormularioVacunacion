using Formulario.AccesoDatos.Repositorios.IRepositorio;
using Formulario.Modelos.ViewModels;
using FormularioVacunacion.AccesoDAtos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Repositorios
{
    public class FarmaciaRepositorio :Repositorio<Farmacia>, IFarmacia
    {
        
        private readonly ApplicationDbContext _db;

        public FarmaciaRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Actualizar(Farmacia farmacia)
        {
            var farmacoBD = _db.Vacunas.FirstOrDefault(v => v.IdPrimario == farmacia.IdPrimario);
            if (farmacoBD != null)
            {
                farmacoBD.vVacunado = farmacia.vVacunado;
                    _db.SaveChanges();
            }
        }
    }
}
