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
    [Migration("20210505112516_HonorariosVet03")]
    partial class HonorariosVet03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaesVeterinarios", b =>
                {
                    b.Property<int>("ListaCaesTratadosPeloVeterinarioId")
                        .HasColumnType("int");

                    b.Property<string>("ListadeVeterinariosQueTrataramOCaoId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ListaCaesTratadosPeloVeterinarioId", "ListadeVeterinariosQueTrataramOCaoId");

                    b.HasIndex("ListadeVeterinariosQueTrataramOCaoId");

                    b.ToTable("CaesVeterinarios");
                });

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446793",
                            Nome = "Aguia da Quinta do Conde",
                            RacaFK = 1,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446795",
                            Nome = "Aileen da Quinta do Lordy",
                            RacaFK = 1,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446801",
                            Nome = "Aladim do Canto do Bairro Pimenta",
                            RacaFK = 5,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 4,
                            DataNasc = new DateTime(2008, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446804",
                            Nome = "Albert do Canto do Bairro Pimenta",
                            RacaFK = 5,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 5,
                            DataNasc = new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446807",
                            Nome = "Alabaster da Casa do Sobreiral",
                            RacaFK = 2,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 6,
                            DataNasc = new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446809",
                            Nome = "Gannett do Quintal de Cima",
                            RacaFK = 6,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 7,
                            DataNasc = new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446811",
                            Nome = "Gardenia da Tapada de Cima",
                            RacaFK = 3,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 8,
                            DataNasc = new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446799",
                            Nome = "Forte da Flecha do Indio",
                            RacaFK = 7,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 9,
                            DataNasc = new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446812",
                            Nome = "Garbo da Flecha do Indio",
                            RacaFK = 7,
                            Sexo = "M"
                        },
                        new
                        {
                            Id = 10,
                            DataNasc = new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446814",
                            Nome = "Garfunkle da Quinta do Lordy",
                            RacaFK = 4,
                            Sexo = "F"
                        },
                        new
                        {
                            Id = 11,
                            DataNasc = new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LOP = "LOP446816",
                            Nome = "Garnet do Quintal de Cima",
                            RacaFK = 8,
                            Sexo = "M"
                        });
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Criadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NomeComercial")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telemovel")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Criadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodPostal = "2305 - 515 PAIALVO",
                            Email = "Marisa.Freitas@iol.pt",
                            Morada = "Largo do Pelourinho",
                            Nome = "Marisa Vieira",
                            NomeComercial = "da Quinta do Conde",
                            Telemovel = "967197885"
                        },
                        new
                        {
                            Id = 2,
                            CodPostal = "2300 - 551 TOMAR",
                            Email = "Fátima.Machado@gmail.com",
                            Morada = "Praça Infante Dom Henrique",
                            Nome = "Fátima Ribeiro",
                            NomeComercial = "da Quinta do Lordy",
                            Telemovel = "963737476"
                        },
                        new
                        {
                            Id = 4,
                            CodPostal = "2300 - 324 TOMAR",
                            Email = "Paula.Lopes@iol.pt",
                            Morada = "Bairro Pimenta",
                            Nome = "Paula Silva",
                            NomeComercial = "do Canto do Pimenta",
                            Telemovel = "967517256"
                        },
                        new
                        {
                            Id = 5,
                            CodPostal = "2305 - 127 ASSEICEIRA TMR",
                            Email = "Mariline.Martins@sapo.pt",
                            Morada = "Zona Industrial",
                            Nome = "Mariline Marques",
                            NomeComercial = "da Casa do Sobreiral",
                            Telemovel = "967212144"
                        },
                        new
                        {
                            Id = 6,
                            CodPostal = "2475 - 013 BENEDITA",
                            Email = "Marcos.Rocha@sapo.pt",
                            Morada = "Rua de Bacelos",
                            Nome = "Marcos Rocha",
                            NomeComercial = "da Casa do Sol",
                            Telemovel = "962125638"
                        },
                        new
                        {
                            Id = 7,
                            CodPostal = "7630 - 782 ZAMBUJEIRA DO MAR",
                            Email = "Alexandre.Dias@hotmail.com",
                            Morada = "Rua João Pedro Costa",
                            Nome = "Alexandre Vieira",
                            NomeComercial = "do Quintal de Cima",
                            Telemovel = "961493756"
                        },
                        new
                        {
                            Id = 8,
                            CodPostal = "2300 - 551 TOMAR",
                            Email = "Paula.Vieira@clix.pt",
                            Morada = "Praça Infante Dom Henrique",
                            Nome = "Paula Soares",
                            NomeComercial = "da Tapada de Cima",
                            Telemovel = "961937768"
                        },
                        new
                        {
                            Id = 9,
                            CodPostal = "2300 - 390 TOMAR",
                            Email = "Mariline.Ribeiro@iol.pt",
                            Morada = "Rua Corredora do Mestre (Palhavã de Cima)",
                            Nome = "Mariline Santos",
                            NomeComercial = "da Quinta do Bacelo",
                            Telemovel = "964106478"
                        },
                        new
                        {
                            Id = 10,
                            CodPostal = "2300 - 635 TOMAR",
                            Email = "Roberto.Vieira@sapo.pt",
                            Morada = "Largo do Flecheiro",
                            Nome = "Roberto Pinto",
                            NomeComercial = "da Flecha do Indio",
                            Telemovel = "964685937"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaesFK = 1,
                            CriadoresFK = 1,
                            DataCompra = new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CaesFK = 2,
                            CriadoresFK = 2,
                            DataCompra = new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CaesFK = 3,
                            CriadoresFK = 4,
                            DataCompra = new DateTime(2011, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CaesFK = 4,
                            CriadoresFK = 5,
                            DataCompra = new DateTime(2008, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CaesFK = 5,
                            CriadoresFK = 6,
                            DataCompra = new DateTime(2012, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CaesFK = 6,
                            CriadoresFK = 7,
                            DataCompra = new DateTime(2010, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CaesFK = 7,
                            CriadoresFK = 8,
                            DataCompra = new DateTime(2011, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CaesFK = 8,
                            CriadoresFK = 9,
                            DataCompra = new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CaesFK = 9,
                            CriadoresFK = 10,
                            DataCompra = new DateTime(2011, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CaesFK = 10,
                            CriadoresFK = 5,
                            DataCompra = new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CaesFK = 11,
                            CriadoresFK = 8,
                            DataCompra = new DateTime(2018, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaoFK = 1,
                            DataFoto = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 2,
                            CaoFK = 1,
                            DataFoto = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador_2.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 3,
                            CaoFK = 2,
                            DataFoto = new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Retriever_do_labrador_3.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 4,
                            CaoFK = 3,
                            DataFoto = new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "s.bernardo.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 5,
                            CaoFK = 4,
                            DataFoto = new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "s.bernardo_2.jpg",
                            LocalFoto = "casa"
                        },
                        new
                        {
                            Id = 6,
                            CaoFK = 5,
                            DataFoto = new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "serra_da_estrela.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 7,
                            CaoFK = 5,
                            DataFoto = new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "serra_da_estrela_2.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 8,
                            CaoFK = 6,
                            DataFoto = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Rafeiro_do_Alentejo.jpg",
                            LocalFoto = "Quinta"
                        },
                        new
                        {
                            Id = 9,
                            CaoFK = 7,
                            DataFoto = new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "pastor_alemao_2.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 10,
                            CaoFK = 7,
                            DataFoto = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "pastor_alemao.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 11,
                            CaoFK = 8,
                            DataFoto = new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "golden-retriever_2.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 12,
                            CaoFK = 8,
                            DataFoto = new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "golden-retriever.jpg",
                            LocalFoto = "ninhada"
                        },
                        new
                        {
                            Id = 13,
                            CaoFK = 9,
                            DataFoto = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Golden-Retriever-1.jpg",
                            LocalFoto = ""
                        },
                        new
                        {
                            Id = 14,
                            CaoFK = 10,
                            DataFoto = new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "Dogue_Alemao.jpg",
                            LocalFoto = "Casa da tia Ana"
                        },
                        new
                        {
                            Id = 15,
                            CaoFK = 11,
                            DataFoto = new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fotografia = "border_collie.jpg",
                            LocalFoto = "quintal"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Designacao = "Retriever do Labrador"
                        },
                        new
                        {
                            Id = 2,
                            Designacao = "Serra da Estrela"
                        },
                        new
                        {
                            Id = 3,
                            Designacao = "Pastor Alemão"
                        },
                        new
                        {
                            Id = 4,
                            Designacao = "Dogue Alemão"
                        },
                        new
                        {
                            Id = 5,
                            Designacao = "S. Bernardo"
                        },
                        new
                        {
                            Id = 6,
                            Designacao = "Rafeiro do Alentejo"
                        },
                        new
                        {
                            Id = 7,
                            Designacao = "Golden Retriever"
                        },
                        new
                        {
                            Id = 8,
                            Designacao = "Border Collie"
                        });
                });

            modelBuilder.Entity("CriadoresCaesDia.Models.Veterinarios", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Honorarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("CaesVeterinarios", b =>
                {
                    b.HasOne("CriadoresCaesDia.Models.Caes", null)
                        .WithMany()
                        .HasForeignKey("ListaCaesTratadosPeloVeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CriadoresCaesDia.Models.Veterinarios", null)
                        .WithMany()
                        .HasForeignKey("ListadeVeterinariosQueTrataramOCaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
