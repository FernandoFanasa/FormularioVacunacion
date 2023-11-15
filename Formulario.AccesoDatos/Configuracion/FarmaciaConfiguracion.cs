using Formulario.Modelos.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.AccesoDatos.Configuracion
{
    public class FarmaciaConfiguracion : IEntityTypeConfiguration<Farmacia>
    {
        public void Configure(EntityTypeBuilder<Farmacia> builder)
        {
            builder.Property(x => x.IdPrimario).IsRequired();
            builder.Property(x => x.vEmpleado_conServicio);
            builder.Property(x => x.nNumEmpleado);
            builder.Property(x => x.vRegionPerteneciente);
            builder.Property(x => x.vSedeAcudiendo);
            builder.Property(x => x.dtAsistencia_aplicación);
            builder.Property(x => x.vRangoEdad);
            builder.Property(x => x.vNombre);
            builder.Property(x => x.vAPaterno);
            builder.Property(x => x.vAMaterno);
            builder.Property(x => x.nEdad);
            builder.Property(x => x.vSexo);
            builder.Property(x => x.vCorreo);
            builder.Property(x => x.nTelefonoContacto);
            builder.Property(x => x.vAcompaniante);
            builder.Property(x => x.nNumeroAcompaniantes);
            builder.Property(x => x.vVacunaAplicada);
            builder.Property(x => x.vCobro);
        }
    }
}
