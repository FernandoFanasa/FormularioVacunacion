using Formulario.AccesoDatos.MapeoFormularioVacunas;
using Formulario.AccesoDatos.MapeoFormularioVacunas.EntidadesTables;
using Formulario.AccesoDatos.Querys.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Querys
{
    public class ConsultasFormulario : IConsulta
    {

        public readonly string vcontexto;
        private readonly DbContextoFormularioVacunas dbContext;

        //public ConsultasFormulario()
        //{

        //}

        public DbContextoFormularioVacunas basedatos {get; set ;}
        public ConsultasFormulario(DbContextoFormularioVacunas dbContexto)
        {
            dbContext = dbContexto;

            basedatos = dbContexto;
        }


        public Vacunas Obtener(int id)
        {
            Vacunas vacuna = new Vacunas();

            return vacuna = basedatos.Vacunas.Where(x => x.IdPrimario == id).FirstOrDefault();    // select * from (Solo por Id)
        }


    }
}
