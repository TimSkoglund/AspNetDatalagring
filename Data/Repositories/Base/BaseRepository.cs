using System.Linq.Expressions;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Base;

public abstract class BaseRepository<TEntity>(DataContext context)
    : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DataContext Context = context;
    protected readonly DbSet<TEntity> Db = context.Set<TEntity>();

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await Db.AddAsync(entity, cancellationToken);
        await Context.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<TEntity>> GetAsync(CancellationToken cancellationToken)
    {
        var entities = await Db.ToListAsync(cancellationToken: cancellationToken);
        
        return entities;
    }
    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken)
    {
        var entity = await Db.FirstOrDefaultAsync(expression, cancellationToken: cancellationToken);
        return entity;
    }
    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        Db.Update(entity);
        await Context.SaveChangesAsync(cancellationToken);
    }
    public async Task RemoveAsync(TEntity entity, CancellationToken cancellationToken)
    {
        Db.Remove(entity);
        await Context.SaveChangesAsync(cancellationToken);
    }
}
//CREATE
//READ
//UPDATE
//DELETE

