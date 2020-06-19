using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Data.Migrations
{
    public partial class Modelo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imagems",
                columns: table => new
                {
                    ImagemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagems", x => x.ImagemId);
                });

            migrationBuilder.CreateTable(
                name: "Imovels",
                columns: table => new
                {
                    ImovelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeImovel = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: false),
                    Rua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Cep = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    ContratoId = table.Column<int>(nullable: true),
                    ImovelId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovels", x => x.ImovelId);
                    table.ForeignKey(
                        name: "FK_Imovels_Imovels_ImovelId1",
                        column: x => x.ImovelId1,
                        principalTable: "Imovels",
                        principalColumn: "ImovelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locadores",
                columns: table => new
                {
                    LocadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    SobreNome = table.Column<string>(nullable: false),
                    Cpf = table.Column<decimal>(nullable: false),
                    Rg = table.Column<decimal>(nullable: false),
                    OrgaoEmissor = table.Column<string>(nullable: false),
                    Profissao = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Tel = table.Column<decimal>(nullable: false),
                    TelTestemunha = table.Column<decimal>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    ContratoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locadores", x => x.LocadorId);
                });

            migrationBuilder.CreateTable(
                name: "Locatarios",
                columns: table => new
                {
                    LocatarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    SobreNome = table.Column<string>(nullable: false),
                    Cpf = table.Column<decimal>(nullable: false),
                    Rg = table.Column<decimal>(nullable: false),
                    OrgaoEmissor = table.Column<string>(nullable: false),
                    Profissao = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Tel = table.Column<decimal>(nullable: false),
                    TelTestemunha = table.Column<decimal>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    ContratoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatarios", x => x.LocatarioId);
                });

            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    ContratoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocadorId = table.Column<int>(nullable: false),
                    LocatarioId = table.Column<int>(nullable: false),
                    imovelId = table.Column<int>(nullable: false),
                    DataContrato = table.Column<DateTime>(nullable: false),
                    DiaVencimentoAlguel = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.ContratoId);
                    table.ForeignKey(
                        name: "FK_Contratos_Locadores_LocadorId",
                        column: x => x.LocadorId,
                        principalTable: "Locadores",
                        principalColumn: "LocadorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_Locatarios_LocatarioId",
                        column: x => x.LocatarioId,
                        principalTable: "Locatarios",
                        principalColumn: "LocatarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratos_Imovels_imovelId",
                        column: x => x.imovelId,
                        principalTable: "Imovels",
                        principalColumn: "ImovelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_LocadorId",
                table: "Contratos",
                column: "LocadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_LocatarioId",
                table: "Contratos",
                column: "LocatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_imovelId",
                table: "Contratos",
                column: "imovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Imovels_ContratoId",
                table: "Imovels",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Imovels_ImovelId1",
                table: "Imovels",
                column: "ImovelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Locadores_ContratoId",
                table: "Locadores",
                column: "ContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locatarios_ContratoId",
                table: "Locatarios",
                column: "ContratoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imovels_Contratos_ContratoId",
                table: "Imovels",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "ContratoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locadores_Contratos_ContratoId",
                table: "Locadores",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "ContratoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locatarios_Contratos_ContratoId",
                table: "Locatarios",
                column: "ContratoId",
                principalTable: "Contratos",
                principalColumn: "ContratoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Locadores_LocadorId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Locatarios_LocatarioId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Imovels_imovelId",
                table: "Contratos");

            migrationBuilder.DropTable(
                name: "Imagems");

            migrationBuilder.DropTable(
                name: "Locadores");

            migrationBuilder.DropTable(
                name: "Locatarios");

            migrationBuilder.DropTable(
                name: "Imovels");

            migrationBuilder.DropTable(
                name: "Contratos");
        }
    }
}
