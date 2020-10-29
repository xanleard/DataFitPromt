using DataFit.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DataBase.Contexts
{
    public class DataFitDbContext : DbContext
    {
        public DataFitDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Facturas> Facturas {get;set;}

        public DbSet<DetalleFactura> DetalleFactura { get; set; }

    }
}
