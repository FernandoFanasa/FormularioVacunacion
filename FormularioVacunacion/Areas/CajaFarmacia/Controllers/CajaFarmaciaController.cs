using Formulario.AccesoDatos.Repositorios.IRepositorio;
using Formulario.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using FormularioVacunacion.AccesoDAtos;
using Formulario.AccesoDatos.Migrations;

namespace FormularioVacunacion.Areas.CajaFarmacia.Controllers
{
    [Area("CajaFarmacia")]
    public class CajaFarmaciaController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public CajaFarmaciaController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Upsert(int id)
        {
            ///CajaFarmacia farma = new CajaFarmacia();

            id = 2;
            if (id == 0)
            {
                //farma.Estado = true;
                return View("");
            }

            ///string vid = id.ToString();
            // Actualizamos Bodega
            //farma = await _unidadTrabajo.Farmacias.Obtener(id);
            object tprueba = await _unidadTrabajo.Farmacias.Obtener(id);

            Vacunas vacunaprueba = (Vacunas)tprueba;

            if (tprueba == null)
            {
                return NotFound();
            }
            return View(tprueba);
        }

        #region API

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var todos = await _unidadTrabajo.Farmacias.ObtenerTodos();
            return Json(new { data = todos });
        }



        #endregion



    }
}
