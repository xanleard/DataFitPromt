using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Productos
{
  public  interface IProductosManager
    {
        Task<IEnumerable<DataFit.DataBase.Models.Productos>> GetAllAsync();

        Task<DataFit.DataBase.Models.Productos> FindByIdAsync(int id);

        Task<bool> CreateAsync(DataFit.DataBase.Models.Productos producto);

        Task<bool> EditAsync(DataFit.DataBase.Models.Productos producto);

        Task<bool> DeleteAsync(DataFit.DataBase.Models.Productos producto);
    }
}
