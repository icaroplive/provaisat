using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISAT.Developer.Exam.Infrastructure.Migrations
{
    public partial class CRIA_TABELA_USUARIOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastAction = table.Column<string>(nullable: true),
                    LastLoginAction = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Nome_Sobrenome",
                table: "Usuario",
                columns: new[] { "Nome", "Sobrenome" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
