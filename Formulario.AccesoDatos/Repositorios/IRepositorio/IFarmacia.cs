using Formulario.Modelos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Repositorios.IRepositorio
{
    public interface IFarmacia : IRepositorio<Farmacia>
    {
        void Actualizar(Farmacia farmacia);

    }
}
