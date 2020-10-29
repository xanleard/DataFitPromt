using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Productos
{
    public class ProductosManager : IProductosManager
    {
        public Task<bool> CreateAsync(DataBase.Models.Productos producto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DataBase.Models.Productos producto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(DataBase.Models.Productos producto)
        {
            throw new NotImplementedException();
        }

        public Task<DataBase.Models.Productos> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DataBase.Models.Productos>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
