﻿// <auto-generated />
using System;
using CriadoresCaesDia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CriadoresCaesDia.Migrations
{
    [DbContext(typeof(CriadoresCaesDB))]
    [Migration("20210407092016_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CriadoresCaesDia.Models.Caes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LOP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RacaFK")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RacaFK");

                    b.ToTable("Caes");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Criadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telemóvel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("morada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Criadores");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.CriadoresCaes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaesFK")
                        .HasColumnType("int");

                    b.Property<int>("CriadoresFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CaesFK");

                    b.HasIndex("CriadoresFK");

                    b.ToTable("CriadoresCaes");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Fotografias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaoFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaoFK");

                    b.ToTable("Fotografias");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Racas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Racas");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Caes", b =>
                {
                    b.HasOne("CriadoresCaesDia.Models.Racas", "Raca")
                        .WithMany("ListaDeCaes")
                        .HasForeignKey("RacaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.CriadoresCaes", b =>
                {
                    b.HasOne("CriadoresCaesDia.Models.Caes", "Cao")
                        .WithMany("ListaCriadores")
                        .HasForeignKey("CaesFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CriadoresCaesDia.Models.Criadores", "Criador")
                        .WithMany("ListadeCaes")
                        .HasForeignKey("CriadoresFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");

                    b.Navigation("Criador");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Fotografias", b =>
                {
                    b.HasOne("CriadoresCaesDia.Models.Caes", "Cao")
                        .WithMany("ListaDeFotografias")
                        .HasForeignKey("CaoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Caes", b =>
                {
                    b.Navigation("ListaCriadores");

                    b.Navigation("ListaDeFotografias");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Criadores", b =>
                {
                    b.Navigation("ListadeCaes");
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Racas", b =>
                {
                    b.Navigation("ListaDeCaes");
                });
#pragma warning restore 612, 618
        }
    }
}
