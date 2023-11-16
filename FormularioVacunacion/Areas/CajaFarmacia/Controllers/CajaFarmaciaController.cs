
using Formulario.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using FormularioVacunacion.AccesoDAtos;
using Formulario.AccesoDatos.MapeoFormularioVacunas;
using Formulario.Utilidades;
using Formulario.Modelos.ViewModels;
using Formulario.AccesoDatos.Repositorios;
using Formulario.AccesoDatos.MapeoFormularioVacunas.EntidadesTables;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Formulario.AccesoDatos.Querys.Interfaz;

namespace FormularioVacunacion.Areas.CajaFarmacia.Controllers
{
    [Area("CajaFarmacia")]
    public class CajaFarmaciaController : Controller
    {
        private readonly IConsulta consulta;

        public CajaFarmaciaController(IConsulta consultas)
        {
            consulta = consultas;
            //_unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index(int id)
        {
            Vacunas vacunas = new Vacunas();
            //ConsultasFormulario consultas = new ConsultasFormulario();

            if (id == 0)
            {
                //farma.Estado = true;
                return View("");
            }

            //object tprueba = await _unidadTrabajo.Farmacias.Obtener(id);
            //Farmacia vacunaprueba = (Farmacia)tprueba;

            vacunas = consulta.Obtener(id);



            if (vacunas == null)
            {
                return NotFound();
            }
            return View(vacunas);
           
        }

        public async Task<IActionResult> Upsert(int id)
        {
            Vacunas vacunas = new Vacunas();
            //ConsultasFormulario consultas = new ConsultasFormulario();

            if (id == 0)
            {
                //farma.Estado = true;
                return View("");
            }

            //object tprueba = await _unidadTrabajo.Farmacias.Obtener(id);
            //Farmacia vacunaprueba = (Farmacia)tprueba;

            vacunas = consulta.Obtener(id);



            if (vacunas == null)
            {
                return NotFound();
            }
            return View(vacunas);
        }

        #region API

        //[HttpGet]
        //public async Task<IActionResult> ObtenerTodos()
        //{
        //    var todos = await _unidadTrabajo.Farmacias.ObtenerTodos();
        //    return Json(new { data = todos });
        //}

        #endregion

    }
}
