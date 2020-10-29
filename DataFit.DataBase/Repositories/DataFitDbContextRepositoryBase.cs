using DataFit.DataBase.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DataBase.Repositories
{
    public abstract  class DataFitDbContextRepositoryBase<TEntity> : RepositoryBase<TEntity, DataFitDbContext>
        where TEntity : class
    {
        public DataFitDbContextRepositoryBase(DataFitDbContext context)
            : base(context)
        {
            this.Context = context;
        }
    }
    
}
