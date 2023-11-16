using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using System.Threading.Tasks;


namespace Formulario.AccesoDatos.MapeoFormularioVacunas.EntidadesTables
{

    [Table("Vacunas")]
    public class Vacunas
    {
            [Key]
            [Column("IdPrimario")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int IdPrimario { get; set; }

        [Column("vEmpleado_conServicio")]

        public string vEmpleadoconServicio { get; set; }

        [Column("nNumEmpleado")]

        public string nNumEmpleado { get; set; }

        [Column("vRegionPerteneciente")]

        public string vRegionPerteneciente { get; set; }

        [Column("vSedeAcudiendo")]

        public string vSedeAcudiendo { get; set; }

        [Column("dtAsistencia_aplicación")]

        public string dtAsistencia_aplicación { get; set; }

        [Column("vRangoEdad")]

        public string vRangoEdad { get; set; }

        [Column("vNombre")]

        public string vNombre { get; set; }

        [Column("vAPaterno")]

        public string vAPaterno { get; set; }

        [Column("vAMaterno")]

        public string  vAMaterno { get; set; }

        [Column("nEdad")]

        public string nEdad { get; set; }

        [Column("vSexo")]

        public string  vSexo { get; set; }

        [Column("vCorreo")]

        public string vCorreo { get; set; }

        [Column("nTelefonoContacto")]

        public string nTelefonoContacto { get; set; }

        [Column("vAcompaniante")]

        public string vAcompaniante { get; set; }

        [Column("nNumeroAcompaniantes")]

        public int  nNumeroAcompaniantes { get; set; }

        [Column("vVacunaAplicada")]

        public string  vVacunaAplicada { get; set; }

        [Column("vCobro")]

        public string  vCobro { get; set; }

        [Column("vVacunado")]

        public string vVacunado  { get; set; }

    }
}
