using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.DataBase.Seed
{
  public  class DataFitSeedData
    {
        public static async Task EnsureDataFitSeedData(IServiceProvider serviceProvider)
        {
            bool databaseCreated = false;
            try
            {
                databaseCreated = await serviceProvider.GetRequiredService<DataFitDbContext>().Database.EnsureCreatedAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            if (!databaseCreated)
            {
                return;
            }

            var context = serviceProvider.GetRequiredService<DataFitDbContext>();

            await InsertProduct(context);
            await InsertCliente(context);

        }


        private static async Task InsertCliente(DataFitDbContext context)
        {
            context.Clientes.Add(new Clientes { Nombre = "ClienteA", Dirrecion = "TestA", Telefono = "9239432", FechaCreacion = DateTime.Now});
            context.Clientes.Add(new Clientes { Nombre = "ClienteB", Dirrecion = "TestB", Telefono = "92339932", FechaCreacion = DateTime.Now });

            context.Database.OpenConnection();

            try
            {
                await context.SaveChangesAsync();
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }

        private static async Task InsertProduct(DataFitDbContext context)
        {
            context.Productos.Add(new Productos { Nombre = "ProductoA", Descripcion="TestA", PrecioReal = (decimal)13 , PrecioVenta = (decimal)18,FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now });
            context.Productos.Add(new Productos { Nombre = "ProductoB", Descripcion = "TestB", PrecioReal = (decimal)16, PrecioVenta = (decimal)23, FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now });

            context.Database.OpenConnection();

            try
            {
                await context.SaveChangesAsync();
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }
    }
}
