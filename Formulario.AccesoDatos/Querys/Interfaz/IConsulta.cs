using Formulario.AccesoDatos.MapeoFormularioVacunas.EntidadesTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Querys.Interfaz
{
    public interface IConsulta 
    {
         Vacunas Obtener(int id);
    }
}
