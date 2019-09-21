using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace URF.Core.Abstractions
{
    public interface IQueryableRepository<TEntity> where TEntity : class
    {
        //Task LoadPropertyAsync(TEntity item, Expression<Func<TEntity, object>> property, CancellationToken cancellationToken = default);
        IQueryable<TEntity> Queryable();
        IQueryable<TEntity> QueryableSql(string sql, params object[] parameters);
        IQuery<TEntity> Query();
    }
}
