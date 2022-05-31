﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaOctoTi.Data;

namespace SistemaOctoTi.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaOctoTi.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF_CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento_DataFundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdEndereco")
                        .HasColumnType("int");

                    b.Property<int>("QtdTelefone")
                        .HasColumnType("int");

                    b.Property<string>("RG_IE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaOctoTi.Models.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodigoClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEndereco")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CodigoClienteId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SistemaOctoTi.Models.TelefoneModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CodigoClienteId")
                        .HasColumnType("int");

                    b.Property<string>("DDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoTelefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoClienteId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("SistemaOctoTi.Models.EnderecoModel", b =>
                {
                    b.HasOne("SistemaOctoTi.Models.ClienteModel", "CodigoCliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("CodigoClienteId");

                    b.Navigation("CodigoCliente");
                });

            modelBuilder.Entity("SistemaOctoTi.Models.TelefoneModel", b =>
                {
                    b.HasOne("SistemaOctoTi.Models.ClienteModel", "CodigoCliente")
                        .WithMany("Telefones")
                        .HasForeignKey("CodigoClienteId");

                    b.Navigation("CodigoCliente");
                });

            modelBuilder.Entity("SistemaOctoTi.Models.ClienteModel", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
