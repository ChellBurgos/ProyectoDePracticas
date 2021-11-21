using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaArtesaniasMarielos.Data.Entities;

namespace TiendaArtesaniasMarielos.Data
{
    public class ArtesaniasDbContext: DbContext
    {
        public ArtesaniasDbContext(DbContextOptions<ArtesaniasDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> CatCategoria { get; set; }

        public DbSet<Cliente> CatCliente{ get; set; }
        public DbSet<DetalleVenta> TblDetalleVenta { get; set; }
        public DbSet<Venta> TblVenta { get; set; }
        public DbSet<Articulo> TblArticulo { get; set; }
        public DbSet<Rol> TblRol { get; set; }
        public DbSet<Usuario> TblUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Categorias
            var categorias = modelBuilder.Entity<Categoria>();
            categorias.HasKey(x => x.IdCategoria);
            categorias.Property(x => x.IdCategoria).ValueGeneratedOnAdd();
            categorias.HasMany(x => x.Articulos)
                     .WithOne(x => x.Categoria)
                     .HasForeignKey(x => x.TA_IdCategoria);


            //Clientes
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.HasKey(x => x.IdCliente);
            clientes.Property(x => x.IdCliente).ValueGeneratedOnAdd();
            clientes.HasMany(x => x.Ventas)
                     .WithOne(x => x.Cliente)
                     .HasForeignKey(x => x.TV_IdCliente);

            //Roles
            var roles = modelBuilder.Entity<Rol>();
            roles.HasKey(x => x.IdRol);
            roles.Property(x => x.IdRol).ValueGeneratedOnAdd();
            roles.HasMany(x => x.Usuarios)
                     .WithOne(x => x.Rol)
                     .HasForeignKey(x => x.TU_IdRol);


            //Articulos
            var articulos = modelBuilder.Entity<Articulo>();
            articulos.HasKey(x => x.IdArticulo);
            articulos.Property(x => x.IdArticulo).ValueGeneratedOnAdd();
            articulos.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Articulo)
                     .HasForeignKey(x => x.TDV_IdArticulo);


            //Ventas
            var ventas = modelBuilder.Entity<Venta>();
            ventas.HasKey(x => x.IdVenta);
            ventas.Property(x => x.IdVenta).ValueGeneratedOnAdd();
            ventas.HasMany(x => x.DetalleVentas)
                     .WithOne(x => x.Venta)
                     .HasForeignKey(x => x.TDV_IdVenta);

            //Detalle Ventas
            var detalles = modelBuilder.Entity<DetalleVenta>();
            detalles.HasKey(x => x.IdDetalleVenta);
            detalles.Property(x => x.IdDetalleVenta).ValueGeneratedOnAdd();


            //Usuarios
            var usuarios = modelBuilder.Entity<Usuario>();
            usuarios.HasKey(x => x.IdUsuario);
            usuarios.Property(x => x.IdUsuario).ValueGeneratedOnAdd();
        }
    }
}
