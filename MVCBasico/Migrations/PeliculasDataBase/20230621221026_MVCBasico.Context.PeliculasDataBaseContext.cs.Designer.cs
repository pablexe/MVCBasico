﻿// <auto-generated />
using MVCBasico.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCBasico.Migrations.PeliculasDataBase
{
    [DbContext(typeof(PeliculasDataBaseContext))]
    [Migration("20230621221026_MVCBasico.Context.PeliculasDataBaseContext.cs")]
    partial class MVCBasicoContextPeliculasDataBaseContextcs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCBasico.Models.Pelicula", b =>
                {
                    b.Property<string>("titulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("duracion")
                        .HasColumnType("float");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.HasKey("titulo");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("MVCBasico.Models.Serie", b =>
                {
                    b.Property<string>("titulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("cantCapitulos")
                        .HasColumnType("int");

                    b.Property<int>("cantTemporadas")
                        .HasColumnType("int");

                    b.Property<string>("director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.HasKey("titulo");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MVCBasico.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
