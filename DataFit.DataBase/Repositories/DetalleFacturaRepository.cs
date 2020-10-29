using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFit.DataBase.Repositories
{
    public class DetalleFacturaRepository : DataFitDbContextRepositoryBase<DetalleFactura>
    {
        public DetalleFacturaRepository(DataFitDbContext context)
         : base(context)
        {
        }

        public override IQueryable<DetalleFactura> All()
        {
            return this.Context.DetalleFactura;
        }

        protected DetalleFactura MapNewValuesToOld(DetalleFactura oldEntity, DetalleFactura newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
