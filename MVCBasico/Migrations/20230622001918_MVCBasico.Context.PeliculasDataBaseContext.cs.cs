using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasico.Migrations
{
    public partial class MVCBasicoContextPeliculasDataBaseContextcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resena",
                columns: table => new
                {
                    calificacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comentario = table.Column<string>(nullable: true),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resena", x => x.calificacion);
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

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: true),
                    director = table.Column<string>(nullable: true),
                    genero = table.Column<int>(nullable: false),
                    Resenacalificacion = table.Column<int>(nullable: true),
                    duracion = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Resena_Resenacalificacion",
                        column: x => x.Resenacalificacion,
                        principalTable: "Resena",
                        principalColumn: "calificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: true),
                    director = table.Column<string>(nullable: true),
                    genero = table.Column<int>(nullable: false),
                    Resenacalificacion = table.Column<int>(nullable: true),
                    cantCapitulos = table.Column<int>(nullable: false),
                    cantTemporadas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Resena_Resenacalificacion",
                        column: x => x.Resenacalificacion,
                        principalTable: "Resena",
                        principalColumn: "calificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_Resenacalificacion",
                table: "Peliculas",
                column: "Resenacalificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Series_Resenacalificacion",
                table: "Series",
                column: "Resenacalificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Resena");
        }
    }
}
