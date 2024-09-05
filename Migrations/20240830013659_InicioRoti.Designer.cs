﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Roticeria3ero.Migrations
{
    [DbContext(typeof(RoticeriaContex))]
    [Migration("20240830013659_InicioRoti")]
    partial class InicioRoti
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Roticeria3ero.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Calle Falsa 123",
                            Email = "juan.perez@example.com",
                            Nombre = "Juan Pérez",
                            Telefono = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "Avenida Siempre Viva 742",
                            Email = "maria.lopez@example.com",
                            Nombre = "María López",
                            Telefono = "987654321"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "Boulevard de los Sueños 456",
                            Email = "carlos.garcia@example.com",
                            Nombre = "Carlos García",
                            Telefono = "555555555"
                        });
                });

            modelBuilder.Entity("Roticeria3ero.Modelos.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            Estado = "Pendiente",
                            Fecha = new DateTime(2024, 8, 29, 22, 36, 58, 291, DateTimeKind.Local).AddTicks(347)
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            Estado = "En Proceso",
                            Fecha = new DateTime(2024, 8, 29, 22, 36, 58, 291, DateTimeKind.Local).AddTicks(371)
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 3,
                            Estado = "Completado",
                            Fecha = new DateTime(2024, 8, 29, 22, 36, 58, 291, DateTimeKind.Local).AddTicks(373)
                        });
                });

            modelBuilder.Entity("Roticeria3ero.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Pizza con salsa de tomate, mozzarella y albahaca",
                            Nombre = "Pizza Margherita",
                            Precio = 555m
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Empanada rellena de carne picada",
                            Nombre = "Empanada de Carne",
                            Precio = 1234m
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Ensalada con lechuga, pollo, crutones y aderezo César",
                            Nombre = "Ensalada César",
                            Precio = 4090m
                        });
                });

            modelBuilder.Entity("Roticeria3ero.Modelos.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Proveedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contacto = "Ana Torres",
                            Email = "ana.torres@distribuidora.com",
                            Nombre = "Distribuidora Alimentos SA",
                            Telefono = "111222333"
                        },
                        new
                        {
                            Id = 2,
                            Contacto = "Luis Martínez",
                            Email = "luis.martinez@frutasyverduras.com",
                            Nombre = "Frutas y Verduras SRL",
                            Telefono = "444555666"
                        });
                });

            modelBuilder.Entity("Roticeria3ero.Modelos.Pedido", b =>
                {
                    b.HasOne("Roticeria3ero.Modelos.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
