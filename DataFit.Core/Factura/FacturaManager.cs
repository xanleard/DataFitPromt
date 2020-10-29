using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Factura
{
    public class FacturaManager : IFacturasManager
    {
        public Task<bool> CreateAsync(Facturas factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Facturas factura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(Facturas factura)
        {
            throw new NotImplementedException();
        }

        public Task<Facturas> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Facturas>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
