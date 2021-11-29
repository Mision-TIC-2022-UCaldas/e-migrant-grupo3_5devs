using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migrant.App.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoServicio",
                table: "Servicio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoServicio",
                table: "Servicio");
        }
    }
}
