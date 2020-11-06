using DataFit.DataBase.Models;
using DataFit.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.DetalleFacturas
{
    public class DetalleFacturaManager : IDetalleFacturaManager
    {

        private readonly IRepository<DetalleFactura> detalleFacturarepository;


        public DetalleFacturaManager(IRepository<DetalleFactura> detalleFacturarepository)
        {
            this.detalleFacturarepository = detalleFacturarepository;
        }

        public async Task<bool> CreateAsync(DetalleFactura factura)
        {
            try
            {
                detalleFacturarepository.Create(factura);
                await detalleFacturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(DetalleFactura factura)
        {
            try
            {
                detalleFacturarepository.Delete(factura);
                await detalleFacturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> EditAsync(DetalleFactura factura)
        {
            try
            {
                detalleFacturarepository.Update(factura);
                await detalleFacturarepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<DetalleFactura> FindByIdAsync(int id)
        {
            var clientes = await detalleFacturarepository.FirstOrDefaultAsync(m => m.Id == id);
            return clientes;
        }

        public  async Task<IEnumerable<DetalleFactura>> GetAllAsync()
        {
            return await detalleFacturarepository.All().ToListAsync();
        }
    }
}
