using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Repositorios.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {

        IFarmacia Farmacias { get; }

        Task Guardar();

    }
}
