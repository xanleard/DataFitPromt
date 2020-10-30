using DataFit.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Productos
{
    public class ProductosManager : IProductosManager
    {

        private readonly IRepository<DataBase.Models.Productos> productosrepository;


        public ProductosManager(IRepository<DataBase.Models.Productos> productosrepository)
        {
            this.productosrepository = productosrepository;
        }

        public async Task<bool> CreateAsync(DataBase.Models.Productos producto)
        {
            try
            {
                productosrepository.Create(producto);
                await productosrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(DataBase.Models.Productos producto)
        {
            try
            {
                productosrepository.Delete(producto);
                await productosrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> EditAsync(DataBase.Models.Productos producto)
        {
            producto.FechaModificacion = DateTime.Now;
            try
            {
                productosrepository.Update(producto);
                await productosrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<DataBase.Models.Productos> FindByIdAsync(int id)
        {
            var productos = await productosrepository.FirstOrDefaultAsync(m => m.Id == id);
            return productos;
        }

        public async Task<IEnumerable<DataBase.Models.Productos>> GetAllAsync()
        {
            return await productosrepository.All().ToListAsync();
        }
    }
}
