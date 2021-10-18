using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbol.App.Persistencia.Migrations
{
    public partial class Correcciondos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquiposId",
                table: "Jugadores");

            migrationBuilder.RenameColumn(
                name: "MarcadorFinal",
                table: "Partidos",
                newName: "MarcadorFinalVisitante");

            migrationBuilder.AddColumn<int>(
                name: "MarcadorFinalLocal",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcadorFinalLocal",
                table: "Partidos");

            migrationBuilder.RenameColumn(
                name: "MarcadorFinalVisitante",
                table: "Partidos",
                newName: "MarcadorFinal");

            migrationBuilder.AddColumn<int>(
                name: "EquiposId",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
