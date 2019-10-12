﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(HelpIncContext))]
    partial class HelpIncContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.DTO.Consumidor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Celular")
                        .HasColumnType("bigint(11)")
                        .HasMaxLength(11);

                    b.Property<long>("Cpf")
                        .HasMaxLength(11);

                    b.Property<long>("IdEndereco");

                    b.Property<long>("IdLogin");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Rg")
                        .HasMaxLength(9);

                    b.Property<int>("Telefone")
                        .HasColumnType("int(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("IdEndereco");

                    b.HasIndex("IdLogin");

                    b.HasIndex("Rg")
                        .IsUnique();

                    b.ToTable("Consumidor");
                });

            modelBuilder.Entity("Domain.DTO.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Cnpj")
                        .HasMaxLength(14);

                    b.Property<long>("IdEndereco");

                    b.Property<long>("IdLogin");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(60);

                    b.Property<int>("Telefone")
                        .HasColumnType("int(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.HasIndex("IdEndereco");

                    b.HasIndex("IdLogin");

                    b.HasIndex("RazaoSocial")
                        .IsUnique();

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Domain.DTO.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(80);

                    b.Property<int>("Cep")
                        .HasColumnType("int(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("Complemento")
                        .HasColumnType("int(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Numero")
                        .HasColumnType("int(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Domain.DTO.Grupo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<long>("IdPrestadorLider");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Nome")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("IdPrestadorLider");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("Domain.DTO.Habilidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.Property<long>("ValorBase")
                        .HasColumnType("bigint(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Habilidade");
                });

            modelBuilder.Entity("Domain.DTO.Login", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(60);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnType("char(1)")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Domain.DTO.Mensagem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaminhoTxt")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasMaxLength(8);

                    b.Property<long>("IdDestinatario")
                        .HasColumnType("bigint(11)")
                        .HasMaxLength(1);

                    b.Property<long>("IdRemetente")
                        .HasColumnType("bigint(11)")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.ToTable("Mensagem");
                });

            modelBuilder.Entity("Domain.DTO.Prestador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Celular")
                        .HasColumnType("bigint(11)")
                        .HasMaxLength(11);

                    b.Property<long>("Cpf")
                        .HasMaxLength(11);

                    b.Property<long>("IdEndereco");

                    b.Property<long>("IdLogin");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Rg")
                        .HasMaxLength(9);

                    b.Property<string>("Sobrenome")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Telefone")
                        .HasColumnType("int(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("IdEndereco");

                    b.HasIndex("IdLogin");

                    b.HasIndex("Rg")
                        .IsUnique();

                    b.ToTable("Prestador");
                });

            modelBuilder.Entity("Domain.DTO.Consumidor", b =>
                {
                    b.HasOne("Domain.DTO.Endereco", "EmpresaEndereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.DTO.Login", "EmpresaLogin")
                        .WithMany()
                        .HasForeignKey("IdLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.DTO.Empresa", b =>
                {
                    b.HasOne("Domain.DTO.Endereco", "EmpresaEndereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.DTO.Login", "EmpresaLogin")
                        .WithMany()
                        .HasForeignKey("IdLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.DTO.Grupo", b =>
                {
                    b.HasOne("Domain.DTO.Prestador", "GrupoPrestadorLider")
                        .WithMany()
                        .HasForeignKey("IdPrestadorLider")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.DTO.Habilidade", b =>
                {
                    b.HasOne("Domain.DTO.Prestador", "PrestadorHabilidade")
                        .WithMany("HabilidadePrestador")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.DTO.Prestador", b =>
                {
                    b.HasOne("Domain.DTO.Grupo", "GrupoPrestador")
                        .WithMany("GrupoPrestador")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.DTO.Endereco", "EmpresaEndereco")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.DTO.Login", "EmpresaLogin")
                        .WithMany()
                        .HasForeignKey("IdLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
