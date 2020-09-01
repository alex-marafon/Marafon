using Microsoft.EntityFrameworkCore.Migrations;

namespace Aluguel.Data.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Imovel


            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('Ap','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('Kitnet5','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('Kitnet1','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('AP2','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('Ap3','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");
            mb.Sql("INSERT INTO Imovels(NomeImovel,Cidade,Estado,Bairro,Rua,Numero,Cep,Status,ContratoId,ImovelId1) " +
                "VALUES('Kitnet2','Sinop','MT','jd jacarandas','Primaveras','254','354785256','false',null,null)");



            ////Locador
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Joao','Silva','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Maria','Ssilva','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Carlos','Sillva','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Joze','Silvva','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Ana','Silvvva','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Pedro','Silvaaa','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Carla','Silvaa','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locadores(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Carol','Silvaaaaa','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");



            ////Locatario
            mb.Sql("INSERT INTO Locatarios(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Chefe','Silvaa','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");
            mb.Sql("INSERT INTO Locatarios(Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha,Status,ContratoId) " +
                "VALUES( 'Administrador','Silvaaaaa','000000','0000','SSPMT','Trabalh','Solteiro','Joao@gmail.com','01012120','000000','false',null)");


        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delite from Contratos");
            mb.Sql("Delite from Locatarios");
            mb.Sql("Delite from Locadores");
            mb.Sql("Delite from Imovels");

        }
    }
}
