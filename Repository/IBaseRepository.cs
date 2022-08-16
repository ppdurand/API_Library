namespace WebApi.Repository;

public interface IBaseRepository
{
    void Add<TEntity>(TEntity entity) where TEntity : class;
    void Update<TEntity>(TEntity entity) where TEntity : class;
    void Delete<TEntity>(TEntity entity) where TEntity : class;
    IEnumerable<TEntity> List<TEntity>() where TEntity : class;
}