using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using RegistroPedidosBlazor.Models;

namespace RegistroPedidosBlazor.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = Data/Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 1, Costo = 150, Descripcion = "Cerveza Presidente", Inventario = 100 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 2, Costo = 950, Descripcion = " FIREBALL ", Inventario = 100 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 3, Costo = 170, Descripcion = " desperados beer ", Inventario = 100 });
            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 4, Costo = 100, Descripcion = "Corona", Inventario = 100 });
          

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 1, Nombres = "Cervecería Nacional Dominicana" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 2, Nombres = "Sazerac Company" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 3, Nombres = "Heineken International" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores { SuplidorId = 4, Nombres = "Grupo Modelo, AB InBev" });

        }




    }
}
