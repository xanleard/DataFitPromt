using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFit.DataBase.Repositories
{
    public class FacturasRepository : DataFitDbContextRepositoryBase<Facturas>
    {
        public FacturasRepository(DataFitDbContext context)
         : base(context)
        {
        }

        public override IQueryable<Facturas> All()
        {
            return this.Context.Facturas;
        }

        protected Facturas MapNewValuesToOld(Facturas oldEntity, Facturas newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
