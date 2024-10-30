using Microsoft.EntityFrameworkCore;
using Roticeria3ero.Modelos;
using System;

public class RoticeriaContex : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }

    public RoticeriaContex(DbContextOptions<RoticeriaContex> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de relaciones
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany()
            .HasForeignKey(p => p.ClienteId);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Producto) // Configuración de relación Producto
            .WithMany()
            .HasForeignKey(p => p.ProductoId);

        // Datos semilla para Clientes
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { Id = 1, Nombre = "Juan Pérez", Direccion = "Calle Falsa 123", Telefono = "123456789", Email = "juan.perez@example.com" },
            new Cliente { Id = 2, Nombre = "María López", Direccion = "Avenida Siempre Viva 742", Telefono = "987654321", Email = "maria.lopez@example.com" },
            new Cliente { Id = 3, Nombre = "Carlos García", Direccion = "Boulevard de los Sueños 456", Telefono = "555555555", Email = "carlos.garcia@example.com" }
        );

        // Datos semilla para Productos
        modelBuilder.Entity<Producto>().HasData(
            new Producto { Id = 1, Nombre = "Pizza Margherita", Descripcion = "Pizza con salsa de tomate, mozzarella y albahaca", Precio = 555 },
            new Producto { Id = 2, Nombre = "Empanada de Carne", Descripcion = "Empanada rellena de carne picada", Precio = 1234 },
            new Producto { Id = 3, Nombre = "Ensalada César", Descripcion = "Ensalada con lechuga, pollo, crutones y aderezo César", Precio = 4090 }
        );

        // Datos semilla para Pedidos (con ProductoId)
        modelBuilder.Entity<Pedido>().HasData(
            new Pedido { Id = 1, ClienteId = 1, ProductoId = 1, Fecha = DateTime.Now, Estado = "Pendiente" },
            new Pedido { Id = 2, ClienteId = 2, ProductoId = 2, Fecha = DateTime.Now, Estado = "En Proceso" },
            new Pedido { Id = 3, ClienteId = 3, ProductoId = 3, Fecha = DateTime.Now, Estado = "Completado" }
        );

        // Datos semilla para Proveedores
        modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor { Id = 1, Nombre = "Distribuidora Alimentos SA", Contacto = "Ana Torres", Telefono = "111222333", Email = "ana.torres@distribuidora.com" },
            new Proveedor { Id = 2, Nombre = "Frutas y Verduras SRL", Contacto = "Luis Martínez", Telefono = "444555666", Email = "luis.martinez@frutasyverduras.com" }
        );
    }
}
