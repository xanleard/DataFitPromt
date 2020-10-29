using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Factura
{
   public interface IFacturasManager
    {
        Task<IEnumerable<DataFit.DataBase.Models.Facturas>> GetAllAsync();

        Task<DataFit.DataBase.Models.Facturas> FindByIdAsync(int id);

        Task<bool> CreateAsync(DataFit.DataBase.Models.Facturas factura);

        Task<bool> EditAsync(DataFit.DataBase.Models.Facturas factura);

        Task<bool> DeleteAsync(DataFit.DataBase.Models.Facturas factura);
    }
}
