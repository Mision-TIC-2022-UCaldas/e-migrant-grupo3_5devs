using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migrant.App.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<int>(type: "int", nullable: false),
                    TipoServicio = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaginaWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    evaluacionGerencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Novedad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiasNovedad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudEmergencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoEmergencia = table.Column<int>(type: "int", nullable: false),
                    estadoEmergencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudEmergencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rol = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoDocumento = table.Column<int>(type: "int", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacionLaboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoServicio = table.Column<int>(type: "int", nullable: false),
                    EntidadId = table.Column<int>(type: "int", nullable: true),
                    Cupo = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Entidad_EntidadId",
                        column: x => x.EntidadId,
                        principalTable: "Entidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mensaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoMensaje = table.Column<int>(type: "int", nullable: false),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmisorId = table.Column<int>(type: "int", nullable: true),
                    ReceptorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensaje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensaje_Usuario_EmisorId",
                        column: x => x.EmisorId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mensaje_Usuario_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MigranteMigrante",
                columns: table => new
                {
                    AmigosId = table.Column<int>(type: "int", nullable: false),
                    FamiliaresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigranteMigrante", x => new { x.AmigosId, x.FamiliaresId });
                    table.ForeignKey(
                        name: "FK_MigranteMigrante_Usuario_AmigosId",
                        column: x => x.AmigosId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigranteMigrante_Usuario_FamiliaresId",
                        column: x => x.FamiliaresId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicioId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nivelPrioridad = table.Column<int>(type: "int", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAceptacionSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estadoSolicitud = table.Column<int>(type: "int", nullable: false),
                    EntidadId = table.Column<int>(type: "int", nullable: true),
                    migranteId = table.Column<int>(type: "int", nullable: true),
                    Evaluacion = table.Column<int>(type: "int", nullable: false),
                    ComportamientoMigrante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudServicio_Entidad_EntidadId",
                        column: x => x.EntidadId,
                        principalTable: "Entidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudServicio_Servicio_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudServicio_Usuario_migranteId",
                        column: x => x.migranteId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensaje_EmisorId",
                table: "Mensaje",
                column: "EmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensaje_ReceptorId",
                table: "Mensaje",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteMigrante_FamiliaresId",
                table: "MigranteMigrante",
                column: "FamiliaresId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_EntidadId",
                table: "Servicio",
                column: "EntidadId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudServicio_EntidadId",
                table: "SolicitudServicio",
                column: "EntidadId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudServicio_migranteId",
                table: "SolicitudServicio",
                column: "migranteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudServicio_ServicioId",
                table: "SolicitudServicio",
                column: "ServicioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensaje");

            migrationBuilder.DropTable(
                name: "MigranteMigrante");

            migrationBuilder.DropTable(
                name: "Novedad");

            migrationBuilder.DropTable(
                name: "SolicitudEmergencia");

            migrationBuilder.DropTable(
                name: "SolicitudServicio");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Entidad");
        }
    }
}
