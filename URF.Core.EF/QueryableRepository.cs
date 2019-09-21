using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using URF.Core.Abstractions;

namespace URF.Core.EF
{
    public class QueryableRepository<TEntity> :IQueryableRepository<TEntity> where TEntity: class
    {
        public QueryableRepository(DbContext context)
        {
            Context = context;
            Set = context.Query<TEntity>();
        }

        protected DbContext Context { get; }
        protected DbQuery<TEntity> Set { get; }

        public virtual IQueryable<TEntity> Queryable() => Set;

        public virtual IQueryable<TEntity> QueryableSql(string sql, params object[] parameters)
            => Set.FromSql(sql, parameters);

        public virtual IQuery<TEntity> Query() => new Query<TEntity>(this);
    }
}
