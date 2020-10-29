using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFit.DataBase.Repositories
{
    public class ProcuctosRepository : DataFitDbContextRepositoryBase<Productos>
    {
        public ProcuctosRepository(DataFitDbContext context)
         : base(context)
        {
        }

        public override IQueryable<Productos> All()
        {
            return this.Context.Productos;
        }

        protected Productos MapNewValuesToOld(Productos oldEntity, Productos newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
