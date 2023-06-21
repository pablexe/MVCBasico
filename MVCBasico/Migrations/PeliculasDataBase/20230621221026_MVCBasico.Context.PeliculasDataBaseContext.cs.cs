using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasico.Migrations.PeliculasDataBase
{
    public partial class MVCBasicoContextPeliculasDataBaseContextcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    titulo = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    genero = table.Column<int>(nullable: false),
                    duracion = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.titulo);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    titulo = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    genero = table.Column<int>(nullable: false),
                    cantCapitulos = table.Column<int>(nullable: false),
                    cantTemporadas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.titulo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    contrasenia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
