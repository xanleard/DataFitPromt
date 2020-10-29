using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.DetalleFacturas
{
   public interface IDetalleFacturaManager
    {
        Task<IEnumerable<DataFit.DataBase.Models.DetalleFactura>> GetAllAsync();

        Task<DataFit.DataBase.Models.DetalleFactura> FindByIdAsync(int id);

        Task<bool> CreateAsync(DataFit.DataBase.Models.DetalleFactura factura);

        Task<bool> EditAsync(DataFit.DataBase.Models.DetalleFactura factura);

        Task<bool> DeleteAsync(DataFit.DataBase.Models.DetalleFactura factura);
    }
}
