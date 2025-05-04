using System.Linq.Expressions;

namespace Data.Repositories.Base;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity, CancellationToken cancellationToken);
    Task<List<TEntity>> GetAsync(CancellationToken cancellationToken);
    Task<TEntity?> GetAsync(Expression<Func<TEntity,bool>> predicate, CancellationToken cancellationToken);
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);
    Task RemoveAsync(TEntity entity, CancellationToken cancellationToken);
}