﻿// <auto-generated />
using System;
using ApiEstudo.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiEstudo.Data.Migrations
{
    [DbContext(typeof(ApiEstudoContext))]
    partial class ApiEstudoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiEstudo.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasMaxLength(20);

                    b.Property<int?>("CursoId");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<bool>("Sexo");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ApiEstudo.Domain.Entities.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargaHoraria");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ApiEstudo.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("ApiEstudo.Domain.Entities.Curso", "Curso")
                        .WithMany("Clientes")
                        .HasForeignKey("CursoId");
                });
#pragma warning restore 612, 618
        }
    }
}
