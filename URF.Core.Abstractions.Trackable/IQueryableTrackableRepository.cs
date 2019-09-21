using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace URF.Core.Abstractions.Trackable
{
    public interface IQueryableTrackableRepository<TEntity> : IQueryableRepository<TEntity> where TEntity : class
    {
        Task LoadRelatedEntities(params TEntity[] entities);
    }
}
