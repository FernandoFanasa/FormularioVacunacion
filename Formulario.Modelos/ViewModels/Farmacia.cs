using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Modelos.ViewModels
{
    public class Farmacia
    {
        [Key]
        public int IdPrimario { get; set; }
        [Required]
        public string vEmpleado_conServicio { get; set; }

        [Required (ErrorMessage ="Numero de empleado es requerido")]
        [MaxLength (10, ErrorMessage = "verifique el numero de empleado")]
        public string nNumEmpleado { get; set; }

        [Required]
        public string vRegionPerteneciente { get; set; }
        
        [Required]
        public string vSedeAcudiendo { get; set; }
        
        [Required]
        public string dtAsistencia_aplicación { get; set; }

        public string vRangoEdad { get; set; }

        public string vNombre { get; set; }

        public string vAPaterno { get; set; }

        public string vAMaterno { get; set; }

        public string nEdad { get; set; }

        public string vSexo { get; set; }

        public string vCorreo { get; set; }

        public string nTelefonoContacto { get; set; }

        public string vAcompaniante { get; set; }

        public int nNumeroAcompaniantes { get; set; }

        public string vVacunaAplicada { get; set; }

        public string vCobro { get; set; }

        public string vVacunado { get; set; }
    }
}
