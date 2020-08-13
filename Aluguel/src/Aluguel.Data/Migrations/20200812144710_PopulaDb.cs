using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Data.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Imovel
            //mb.Sql("Insert into Imovel(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status) Values('Ap1','Sinop','MT','Jd Jacarandas','Primaveras',249,78550000,'true')");
            
            for (int i = 0; i < 5; i++)
            {
                mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) VALUES('testeVS','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
                i++;
            }



            ////Locador
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Joao','Silva',0000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Maria','Silva',00000000000,000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Joze','Silva',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Carlos','Silva',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000')");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Pedro','Silva',00000000000,000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Ana','Silva',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Kiko','Silva',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Joao','Silva',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locador(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','Joao','Silva',0000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");

            ////Locatario
            //mb.Sql("insert into Locatario(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','LocatarioA','AAA',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");
            //mb.Sql("insert into Locatario(Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha) " +
            //                   "Values('true','LocatarioB','BBB',00000000000,0000000,'SSSP','Trabalho','Solteiro','joao@gmail.com',35310000, 35310000)");



        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delite from Contrato");
            mb.Sql("Delite from Locatario");
            mb.Sql("Delite from Locador");
            mb.Sql("Delite from Imovel");
            
        }
    }
}
