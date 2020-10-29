using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Clientes
{
   public interface IClientesManager
    {
        Task<IEnumerable<DataFit.DataBase.Models.Clientes>> GetAllAsync();

        Task<DataFit.DataBase.Models.Clientes> FindByIdAsync(int id);

        Task<bool> CreateAsync(DataFit.DataBase.Models.Clientes cliente);

        Task<bool> EditAsync(DataFit.DataBase.Models.Clientes cliente);

        Task<bool> DeleteAsync(DataFit.DataBase.Models.Clientes cliente);
    }
}
