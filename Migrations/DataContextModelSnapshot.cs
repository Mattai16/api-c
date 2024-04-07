﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apidotnet.Data;

#nullable disable

namespace api_dotnet.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasPeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "PeliculasPeliculaId");

                    b.HasIndex("PeliculasPeliculaId");

                    b.ToTable("CategoriaPelicula");

                    b.HasData(
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 1
                        },
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 2
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 2
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 3
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 4
                        },
                        new
                        {
                            CategoriasCategoriaId = 6,
                            PeliculasPeliculaId = 5
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 5
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 6
                        },
                        new
                        {
                            CategoriasCategoriaId = 15,
                            PeliculasPeliculaId = 6
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 7
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 8
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 8
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 10,
                            PeliculasPeliculaId = 9
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 10
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 10
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 11
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 8,
                            PeliculasPeliculaId = 12
                        },
                        new
                        {
                            CategoriasCategoriaId = 1,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 13
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 4,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 5,
                            PeliculasPeliculaId = 14
                        },
                        new
                        {
                            CategoriasCategoriaId = 2,
                            PeliculasPeliculaId = 15
                        },
                        new
                        {
                            CategoriasCategoriaId = 5,
                            PeliculasPeliculaId = 15
                        },
                        new
                        {
                            CategoriasCategoriaId = 10,
                            PeliculasPeliculaId = 15
                        });
                });

            modelBuilder.Entity("apidotnet.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Protegida")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Acción",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Aventura",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Animación",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Ciencia ficción",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Comedia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Crimen",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Documental",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Drama",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Familiar",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Fantasia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Historia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 12,
                            Nombre = "Horror",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 13,
                            Nombre = "Musica",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 14,
                            Nombre = "Misterio",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 15,
                            Nombre = "Romance",
                            Protegida = true
                        });
                });

            modelBuilder.Entity("apidotnet.Models.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PeliculaId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PeliculaId");

                    b.ToTable("Pelicula");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_SX300.jpg",
                            Sinopsis = "El banquero Andy Dufresne es arrestado por matar a su esposa y amante. Tras una dura adaptación, intenta mejorar las condiciones de la prisión y dar esperanza a sus compañeros.",
                            Titulo = "Sueño de fuga"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Anio = 1972,
                            Poster = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "El patriarca de una organización criminal transfiere el control de su clandestino imperio a su reacio hijo.",
                            Titulo = "El padrino"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Anio = 2008,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SX300.jpg",
                            Sinopsis = "Cuando el Joker emerge causando caos y violencia en Gotham, el caballero de la noches deberá aceptar una de las pruebas psicológicas y físicas más difíciles para poder luchar con las injusticias del enemigo.",
                            Titulo = "El caballero oscuro"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Anio = 2003,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Gandalf y Aragorn lideran el Mundo de los hombres, e intentarán atraer la atención de Sauron para darle a Frodo la última oportunidad de completar su misión y así tratar de evitar sucumbir a las continuas tentaciones del Anillo.",
                            Titulo = "El retorno del rey"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Las vidas de dos mafiosos, un boxeador, la esposa de un gánster y un par de bandidos se entrelazan en cuatro historias de violencia y redención.",
                            Titulo = "Tiempos violentos"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Anio = 1994,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Sinopsis = "Las presidencias de Kennedy y Johnson, los eventos de Vietnam, Watergate vistas desde la perspectiva de un hombre de Alabama con un coeficiente intelectual de 75.",
                            Titulo = "Forrest Gump"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Anio = 1999,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Un hombre deprimido conoce a un fabricante de jabones, y juntos forman un club de pelea clandestino que evoluciona en algo inesperado.",
                            Titulo = "El club de la pelea"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Anio = 2010,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
                            Sinopsis = "A un ladrón que roba secretos corporativos a través de la tecnología de entrar en el subconsciente, se le da la tarea de implantar una idea en la mente del jefe de una gran empresa.",
                            Titulo = "Inception"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Anio = 1980,
                            Poster = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Sinopsis = "Los rebeldes han vencido al Imperio en el planeta helado Hoth. Luke Skywalker empieza a entrenar como Jedi con Yoda, mientras sus amigos son perseguidos por Darth Vader.",
                            Titulo = "Star Wars: Episodio V - El imperio contraataca"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Anio = 1999,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZjJjMTg5MTEtMDkwMy00ZjUyLTg5ODYtMmNmY2ZiNGVlZTdjXkEyXkFqcGdeQXVyODA1NjQ0OTY@._V1_SX300.jpg",
                            Sinopsis = "Un hacker se da cuenta por medio de otros rebeldes de la naturaleza de su realidad y su rol en la guerra contra los controladores.",
                            Titulo = "Matrix"
                        },
                        new
                        {
                            PeliculaId = 11,
                            Anio = 2014,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg",
                            Sinopsis = "Un grupo de exploradores prueban los saltos a través de agujeros de gusano en búsqueda de la sobrevivencia de la humanidad.",
                            Titulo = "Interestelar"
                        },
                        new
                        {
                            PeliculaId = 12,
                            Anio = 2024,
                            Poster = "https://m.media-amazon.com/images/M/MV5BODdjMjM3NGQtZDA5OC00NGE4LWIyZDQtZjYwOGZlMTM5ZTQ1XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg",
                            Sinopsis = "Paul Atreides se une a Chani y los Fremen mientras busca venganza contra los conspiradores que destruyeron a su familia.",
                            Titulo = "Dune: Parte dos"
                        },
                        new
                        {
                            PeliculaId = 13,
                            Anio = 1991,
                            Poster = "https://m.media-amazon.com/images/M/MV5BMGU2NzRmZjUtOGUxYS00ZjdjLWEwZWItY2NlM2JhNjkxNTFmXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Sinopsis = "Un cyborg, idéntico al que fracasó al asesinar a Sarah Connor, ahora debe proteger al hijo adolescente de un cyborg más avanzado y poderoso.",
                            Titulo = "Terminador 2: El juicio final"
                        },
                        new
                        {
                            PeliculaId = 14,
                            Anio = 1995,
                            Poster = "https://m.media-amazon.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Sinopsis = "Marty McFly, un estudiante de 17 años, es enviado accidentalmente treinta años al pasado en un artefacto inventado por su amigo.",
                            Titulo = "Volver al futuro"
                        },
                        new
                        {
                            PeliculaId = 15,
                            Anio = 2023,
                            Poster = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg",
                            Sinopsis = "Vivir en Barbie Land es ser un ser perfecto en un lugar perfecto. A menos que tengas una crisis existencial completa. O seas Ken.",
                            Titulo = "Barbie"
                        });
                });

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.HasOne("apidotnet.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apidotnet.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasPeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
