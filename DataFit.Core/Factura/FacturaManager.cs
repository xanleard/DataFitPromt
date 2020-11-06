using DataFit.DataBase.Models;
using DataFit.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Factura
{
    public class FacturaManager : IFacturasManager
    {
        private readonly IRepository<Facturas> facturarepository;


        public FacturaManager(IRepository<Facturas> facturarepository)
        {
            this.facturarepository = facturarepository;
        }

        public async Task<bool> CreateAsync(Facturas factura)
        {
            try
            {
                facturarepository.Create(factura);
                await facturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(Facturas factura)
        {
            try
            {
                facturarepository.Delete(factura);
                await facturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> EditAsync(Facturas factura)
        {
            try
            {
                facturarepository.Update(factura);
                await facturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<Facturas> FindByIdAsync(int id)
        {
            var clientes = await facturarepository.FirstOrDefaultAsync(m => m.Id == id);
            return clientes;
        }

        public async Task<IEnumerable<Facturas>> GetAllAsync()
        {
            return await facturarepository.All().ToListAsync();
        }
    }
}
