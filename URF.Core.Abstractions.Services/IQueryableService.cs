using System;
using System.Collections.Generic;
using System.Text;

namespace URF.Core.Abstractions.Services
{
    public interface IQueryableService<TEntity> : IQueryableRepository<TEntity> where TEntity : class
    {
    }
}
