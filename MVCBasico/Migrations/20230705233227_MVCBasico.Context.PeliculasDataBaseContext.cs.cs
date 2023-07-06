using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasico.Migrations
{
    public partial class MVCBasicoContextPeliculasDataBaseContextcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contenido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    genero = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    duracion = table.Column<double>(nullable: true),
                    cantCapitulos = table.Column<int>(nullable: true),
                    cantTemporadas = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    correo = table.Column<string>(nullable: false),
                    contrasenia = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resenas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    calificacion = table.Column<int>(nullable: false),
                    comentario = table.Column<string>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    contenidoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resenas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resenas_Contenido_contenidoId",
                        column: x => x.contenidoId,
                        principalTable: "Contenido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resenas_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resenas_contenidoId",
                table: "Resenas",
                column: "contenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Resenas_usuarioId",
                table: "Resenas",
                column: "usuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resenas");

            migrationBuilder.DropTable(
                name: "Contenido");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
