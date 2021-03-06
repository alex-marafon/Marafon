﻿// <auto-generated />
using System;
using Aluguel.Data.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aluguel.Data.Migrations
{
    [DbContext(typeof(AluguelDbContext))]
    [Migration("20200617134230_Modelo1")]
    partial class Modelo1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aluguel.Dominio.Models.Contrato", b =>
                {
                    b.Property<int>("ContratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataContrato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiaVencimentoAlguel")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocadorId")
                        .HasColumnType("int");

                    b.Property<int>("LocatarioId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("imovelId")
                        .HasColumnType("int");

                    b.HasKey("ContratoId");

                    b.HasIndex("LocadorId");

                    b.HasIndex("LocatarioId");

                    b.HasIndex("imovelId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Imagem", b =>
                {
                    b.Property<int>("ImagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImagemId");

                    b.ToTable("Imagems");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Imovel", b =>
                {
                    b.Property<int>("ImovelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContratoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImovelId1")
                        .HasColumnType("int");

                    b.Property<string>("NomeImovel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ImovelId");

                    b.HasIndex("ContratoId");

                    b.HasIndex("ImovelId1");

                    b.ToTable("Imovels");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Locador", b =>
                {
                    b.Property<int>("LocadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContratoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cpf")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgaoEmissor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("Tel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TelTestemunha")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LocadorId");

                    b.HasIndex("ContratoId");

                    b.ToTable("Locadores");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Locatario", b =>
                {
                    b.Property<int>("LocatarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContratoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cpf")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrgaoEmissor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("Tel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TelTestemunha")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LocatarioId");

                    b.HasIndex("ContratoId");

                    b.ToTable("Locatarios");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Contrato", b =>
                {
                    b.HasOne("Aluguel.Dominio.Models.Locador", "Locador")
                        .WithMany()
                        .HasForeignKey("LocadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aluguel.Dominio.Models.Locatario", "Locatario")
                        .WithMany()
                        .HasForeignKey("LocatarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aluguel.Dominio.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("imovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Imovel", b =>
                {
                    b.HasOne("Aluguel.Dominio.Models.Contrato", null)
                        .WithMany("Imovels")
                        .HasForeignKey("ContratoId");

                    b.HasOne("Aluguel.Dominio.Models.Imovel", null)
                        .WithMany("Imovels")
                        .HasForeignKey("ImovelId1");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Locador", b =>
                {
                    b.HasOne("Aluguel.Dominio.Models.Contrato", null)
                        .WithMany("Locadores")
                        .HasForeignKey("ContratoId");
                });

            modelBuilder.Entity("Aluguel.Dominio.Models.Locatario", b =>
                {
                    b.HasOne("Aluguel.Dominio.Models.Contrato", null)
                        .WithMany("Locatarios")
                        .HasForeignKey("ContratoId");
                });
#pragma warning restore 612, 618
        }
    }
}
