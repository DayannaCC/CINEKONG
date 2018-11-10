using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CINEKONG.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Butaca",
                columns: table => new
                {
                    idbut = table.Column<string>(maxLength: 30, nullable: false),
                    estbut = table.Column<string>(nullable: true),
                    tipbut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butaca", x => x.idbut);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Correo = table.Column<string>(maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    FecNac = table.Column<DateTime>(nullable: false),
                    Nombres = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Correo);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioButaca",
                columns: table => new
                {
                    idbut = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    costo = table.Column<double>(nullable: false),
                    subtotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioButaca", x => new { x.idbut, x.Correo });
                    table.ForeignKey(
                        name: "FK_UsuarioButaca_Usuario_Correo",
                        column: x => x.Correo,
                        principalTable: "Usuario",
                        principalColumn: "Correo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioButaca_Butaca_idbut",
                        column: x => x.idbut,
                        principalTable: "Butaca",
                        principalColumn: "idbut",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioButaca_Correo",
                table: "UsuarioButaca",
                column: "Correo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioButaca");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Butaca");
        }
    }
}
