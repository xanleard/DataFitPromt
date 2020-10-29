using DataFit.DataBase.Models;
using DataFit.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataFit.Core.Clientes
{
    public class ClientesManager : IClientesManager
    {
        private readonly IRepository<DataBase.Models.Clientes> clientesrepository;

        public ClientesManager(IRepository<DataBase.Models.Clientes> clientesrepository)
        {
            this.clientesrepository = clientesrepository;
        }
        public async Task<bool> CreateAsync(DataBase.Models.Clientes cliente)
        {
            try
            {
                clientesrepository.Create(cliente);
                await clientesrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(DataBase.Models.Clientes cliente)
        {
            try
            {
                clientesrepository.Delete(cliente);
                await clientesrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<bool> EditAsync(DataBase.Models.Clientes cliente)
        {
            try
            {
                clientesrepository.Update(cliente);
                await clientesrepository.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public async Task<DataBase.Models.Clientes> FindByIdAsync(int id)
        {
            var clientes = await clientesrepository.FirstOrDefaultAsync(m => m.Id == id);
            return clientes;
        }

        public async Task<IEnumerable<DataBase.Models.Clientes>> GetAllAsync()
        {
         return await clientesrepository.All().ToListAsync();
        }
    }
}
