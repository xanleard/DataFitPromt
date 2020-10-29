using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.DetalleFacturas
{
    public class DetalleFacturaManager : IDetalleFacturaManager
    {
        public Task<bool> CreateAsync(DetalleFactura factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DetalleFactura factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(DetalleFactura factura)
        {
            throw new NotImplementedException();
        }

        public Task<DetalleFactura> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetalleFactura>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
