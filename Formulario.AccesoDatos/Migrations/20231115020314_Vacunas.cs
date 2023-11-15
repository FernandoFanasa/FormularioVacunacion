using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Formulario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Vacunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    IdPrimario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vEmpleado_conServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nNumEmpleado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    vRegionPerteneciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vSedeAcudiendo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dtAsistencia_aplicación = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vRangoEdad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vAPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vAMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nEdad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nTelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vAcompaniante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nNumeroAcompaniantes = table.Column<int>(type: "int", nullable: false),
                    vVacunaAplicada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vCobro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vVacunado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.IdPrimario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacunas");
        }
    }
}
