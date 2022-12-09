using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramaIdeias.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Ideia",
                columns: table => new
                {
                    IDIdeia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ganho = table.Column<float>(type: "real", nullable: true),
                    DescricaoGanho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investimento = table.Column<float>(type: "real", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEquipe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideia", x => x.IDIdeia);
                });

            migrationBuilder.CreateTable(
                name: "EquipeIdeia",
                columns: table => new
                {
                    IDEquipeIdeia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDFuncionario = table.Column<int>(type: "int", nullable: false),
                    IDIdeia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipeIdeia", x => x.IDEquipeIdeia);
                    table.ForeignKey(
                        name: "FK_EquipeIdeia_Funcionario_IDFuncionario",
                        column: x => x.IDFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IDFuncionario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipeIdeia_Ideia_IDIdeia",
                        column: x => x.IDIdeia,
                        principalTable: "Ideia",
                        principalColumn: "IDIdeia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipeIdeia_IDFuncionario",
                table: "EquipeIdeia",
                column: "IDFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_EquipeIdeia_IDIdeia",
                table: "EquipeIdeia",
                column: "IDIdeia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipeIdeia");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Ideia");
        }
    }
}
