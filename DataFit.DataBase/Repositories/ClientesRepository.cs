using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFit.DataBase.Repositories
{
    public class ClientesRepository : DataFitDbContextRepositoryBase<Clientes>
    {
        public ClientesRepository(DataFitDbContext context)
         : base(context)
        {
        }

        public override IQueryable<Clientes> All()
        {
            return this.Context.Clientes;
        }

        protected Clientes MapNewValuesToOld(Clientes oldEntity, Clientes newEntity)
        {
            throw new NotImplementedException();
        }
    }

}
