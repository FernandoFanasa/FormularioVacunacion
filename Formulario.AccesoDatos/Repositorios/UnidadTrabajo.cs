using Formulario.AccesoDatos.Repositorios.IRepositorio;
using FormularioVacunacion.AccesoDAtos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Repositorios
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;

        public  IFarmacia Farmacias { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Farmacias = new FarmaciaRepositorio(db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
