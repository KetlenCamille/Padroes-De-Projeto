﻿// <auto-generated />
using System;
using ExemplosPadrõesProjeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExemplosPadroesProjeto.Migrations
{
    [DbContext(typeof(ResidenciaContext))]
    partial class ResidenciaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Casa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estilo");

                    b.HasKey("Id");

                    b.ToTable("Casas");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Movel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CasaId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Modelo");

                    b.HasKey("Id");

                    b.HasIndex("CasaId");

                    b.ToTable("Moveis");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Movel");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Barroco.CadeiraBarroca", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("CadeiraBarroca");

                    b.HasDiscriminator().HasValue("CadeiraBarroca");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.CadeiraFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("CadeiraFuturista");

                    b.HasDiscriminator().HasValue("CadeiraFuturista");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.MesaBarroca", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("MesaBarroca");

                    b.HasDiscriminator().HasValue("MesaBarroca");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.MesaFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("MesaFuturista");

                    b.HasDiscriminator().HasValue("MesaFuturista");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Movel", b =>
                {
                    b.HasOne("ExemplosPadrõesProjeto.Models.Casa")
                        .WithMany("Moveis")
                        .HasForeignKey("CasaId");
                });
#pragma warning restore 612, 618
        }
    }
}
