using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Data.Migrations
{
    public partial class inicial : Migration
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
                    Estado = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: false),
                    Rua = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Cep = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovels", x => x.ImovelId);
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
                    TelTestemunha = table.Column<decimal>(nullable: false)
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
                    TelTestemunha = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatarios", x => x.LocatarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagems");

            migrationBuilder.DropTable(
                name: "Imovels");

            migrationBuilder.DropTable(
                name: "Locadores");

            migrationBuilder.DropTable(
                name: "Locatarios");
        }
    }
}
